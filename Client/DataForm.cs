using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Globalization;

namespace Client
{
    public partial class DataForm : Form
    {
        public DataForm(AuthorizationForm AF)
        {
            InitializeComponent();
            authForm = AF;
            editForm = new EditStudentsForm(this);
        }
        AuthorizationForm authForm;
        EditStudentsForm editForm;
        SheetForm sheetForm;
        DataSet table;
        public String ConnectionString;
        public NpgsqlConnection npgsqlConnection;
        string ColumnName;
        string ColumnValue;
        void GetActions()
        {
            editStudentBtn.Enabled = deleteStudentBtn.Enabled = false;
        switch (ColumnName)
            {
                case "abbr_name":
                case "group_name": ColNameLbl.Text = "Группа";
                    showInfoBtn.Text = "Показать список студентов группы";
                    break;
                case "academic_plan_name": ColNameLbl.Text = "Учебный план";
                    showInfoBtn.Text = "Показать нагрузку учебного плана";
                    break;
                case "academic_year_id": ColNameLbl.Text = "Поток";
                    showInfoBtn.Text = "Показать список студентов потока";
                    break;
                case "specialty_id": ColNameLbl.Text = "Специальность";
                    showInfoBtn.Text = "Показать список студентов специальности";
                    break;

                case "discipline_name":
                    ColNameLbl.Text = "Имя дисциплины";
                    showInfoBtn.Text = "Показать группы, изучающие этот предмет";
                    break;
                case "discipline_code":
                    ColNameLbl.Text = "Код дисциплины";
                    showInfoBtn.Text = "Показать группы, изучающие этот предмет";
                    break;
                case "students_name": ColNameLbl.Text = "Студент";
                    showInfoBtn.Text = "Показать успеваемость студента";
                    editStudentBtn.Enabled = deleteStudentBtn.Enabled = true;
                    break;
                case "student_check_number": ColNameLbl.Text = "Номер зачетки студента";
                    showInfoBtn.Text = "Показать успеваемость студента";
                    editStudentBtn.Enabled = deleteStudentBtn.Enabled = true;
                    break;
                default: ColNameLbl.Text = ColumnName;
                    showInfoBtn.Text = "(Нет доступных действий)";
                    break;
            }
        ColValueTB.Text = ColumnValue;
        }
        public DataSet SelectRequestQuery(string queryText, DataSet reserveDS)
        {
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryText, npgsqlConnection);
                NpgsqlCommandBuilder cd = new NpgsqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(reserveDS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return emptyDataSet;
            }
            return reserveDS;
        }
        public bool RequestQuery(string queryText)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(queryText, npgsqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ColumnName = dataGrid.Columns[e.ColumnIndex].Name;
                ColumnValue = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                GetActions();
            }
            catch (Exception)
            {} 
            //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), 
            //dataGrid.Columns[e.ColumnIndex].Name);        
        }
        #region DeveloperMode
        private void developerQueryBtn_Click(object sender, EventArgs e)
        {
            table = new DataSet();
            if(developerQueryTB.Text.StartsWith("select", true, CultureInfo.InvariantCulture))
            {
                dataGrid.DataSource = SelectRequestQuery(developerQueryTB.Text, table).Tables[0];
            }
            else
            {
                RequestQuery(developerQueryTB.Text);
            }
            
        }
        private void developerQueryTB_TextChanged(object sender, EventArgs e)
        {
            if (developerQueryTB.Text.Length > 1)
                AcceptButton = developerQueryBtn;
            else AcceptButton = null;
        }
        private void devModeTSMI_Click(object sender, EventArgs e)
        {
            if (devModeTSMI.Checked)
            {
                queryGB.Visible = true;
                developerQueryTB.Focus();
            }
                
            else 
            {
                queryGB.Visible = false;
                ShowGroupsBtn.Focus();
            }
        }
        #endregion
        #region Buttons&Actions
        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            table = new DataSet();
            string str = ColValueTB.Text;
            if (new List<string>(){"group_name", "abbr_name", 
                "students_name", "academic_plan_name", 
            "discipline_name", "discipline_code",}.Contains(ColumnName)) 
	        {
                str = "'" + str + "'";
	        }
            switch (ColumnName)
            {
                case "abbr_name":
                case "group_name":
                case "academic_year_id":
                case "specialty_id":
                    SelectRequestQuery(String.Format(@"select s.students_name,s.student_check_number,g.abbr_name,g.group_name,g.academic_year_id,g.specialty_id
                        from students s,groups g,studentsgroups sg
                        where s.id=sg.students_id and g.id=sg.group_id
                        and {0} = {1}", ColumnName, str), table); 
                    break; //показать список студентов группы //Показать список студентов потока //Показать список студентов специальности
                case "academic_plan_name":
                    SelectRequestQuery(String.Format(" select academic_plan_name, specialty_id, " +
                    " (select count(g.id) as \"Количество групп\" from groups g,academic_plans ap " +
                    " where ap.id=g.academic_plan_id and  academic_plan_name ={0}), " +
                    " s.semester_id,discipline_name,discipline_code,d.gos as \"Количество часов\" " +
                    " from academic_plans ap, disciplines d,semesters s " +
                    " where ap.id=d.academic_plan_id and ap.academic_plan_name ={0} and s.discipline_id=d.id " +
                    " order by semester_id, discipline_name ", str), table);
                    break; //Показать нагрузку учебного плана

                case "discipline_name":
                case "discipline_code":
                    SelectRequestQuery(String.Format(@" 
                    select g.group_name,g.abbr_name,g.specialty_id,discipline_name,d.discipline_code,gos
                    from groups g,disciplines d
                    where g.academic_plan_id=d.academic_plan_id and {0}={1}",
                    ColumnName, str), table);
                    break; //Показать группы с таким предметом
                case "students_name":
                case "student_check_number":
                    SelectRequestQuery(String.Format(@"select g.abbr_name, 'Семестр ' || s.semester_id , d.discipline_name , f.form_name,
                         (select r.rating
                         from ratings r, students st
                         where r.student_id = st.id and st.{0} = {1} and r.discipline_id = d.id and s.semester_id = r.semester_id and f.form_control_id = r.form_control_id order by r.period DESC limit 1
                         ) 
                    from groups g , semesters s, disciplines d, 
                         (select 'Экзамен' as form_name, true as exam, false as credit,false as credit_rating,false as course_work, 1 as form_control_id
                         union select 'Зачет', false, true,false,false, 2
                         union select 'Зачет с оценкой', false, false,true,false, 12
                         union select 'Курсовая', false, false,false,true, 3) f
                    where  g.abbr_name = (select groups.abbr_name from students,groups,studentsgroups where students.{0} = {1} and students.id=studentsgroups.students_id and studentsgroups.group_id=groups.id)
                    and s.discipline_id = d.id and d.academic_plan_id = g.academic_plan_id and (f.exam = s.exam or f.credit = s.credit or f.credit_rating = s.credit_rating or f.course_work = s.course_work) 
                    order by s.semester_id",
                    ColumnName, str), table);
                    break; //Показать успеваемость студента
                default: return;
            }
            dataGrid.DataSource = table.Tables[0];
        }
        private void ShowGroupsBtn_Click(object sender, EventArgs e)
        {
            table = new DataSet();
            dataGrid.DataSource =  SelectRequestQuery(
            @"select group_name, abbr_name,groups.academic_year_id, groups.specialty_id, academic_plan_name
            from groups
            left join academic_plans
            on groups.academic_plan_id=academic_plans.id ", 
            table).Tables[0];
        }
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            editForm.editButton.Text = "Добавить студента";
            editForm.ShowDialog();
        }
        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            editForm.EditMode = true;
            editForm.ColName = ColumnName;
            editForm.ColValue = ColumnValue;
            editForm.ShowDialog();
        }
        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            string str = ColumnValue;
            if(MessageBox.Show("Вы действительно желаете отчислить этого студента?\n" +
                ColNameLbl.Text + ": " + ColValueTB.Text, "Подтвердите отчисление студента",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                if (ColumnName == "students_name") { str = String.Format("'{0}'", str); }
                if (RequestQuery(String.Format(@"delete from studentsgroups where students_id = 
            (select id from students where {0} = {1});
            delete from students where {0} = {1};
            ", ColumnName, str)))
                {
                    statusLabel.Text = "Студент отчислен. " + ColNameLbl.Text + ": " + ColValueTB.Text;
                    pictureBox1.Image = Client.Properties.Resources.otchislen;
                }
            }
        }
        private void editSheetBtn_Click(object sender, EventArgs e)
        {
            sheetForm = new SheetForm(this);
            sheetForm.Show();
        }
        #endregion
        #region Disconnect&exit
        private void disconnectTSMI_Click(object sender, EventArgs e)
        {
            npgsqlConnection.Close();
            Close();
        }
        private void DataForm_Load(object sender, EventArgs e)
        {

        }
        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm.Show();
        }
        private void closeAppTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
