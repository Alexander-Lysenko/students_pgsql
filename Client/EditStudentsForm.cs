using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Client
{
    public partial class EditStudentsForm : Form
    {
        public EditStudentsForm(DataForm df)
        {
            InitializeComponent();
            dataForm = df;
        }
        DataForm dataForm;        
        DataSet groups;
        DataSet info;
        DataTable infoTable;
        public bool EditMode = false;
        bool groupEdited = false;
        public string ColName = "";
        public string ColValue = "";
        void AddNewStudent()
        {
            if (dataForm.RequestQuery(
                String.Format(@"
                    INSERT INTO public.students( 
                    id, students_name, student_check_number) 
                    VALUES ((select id from students order by id desc limit 1) + 1 , '{0}', {1}); 
                    insert into public.studentsgroups(students_id ,group_id ,period )values( 
                    (select id from students where students_name='{0}'), 
                    (select id from groups where group_name='{2}'),'{3}')
                    ",
                    String.Join(" ", lastNameTB.Text, firstNameTB.Text, middleNameTB.Text),
                    checkNumberTB.Text, groupNameCB.Text, periodDate.Value.ToString("yyyy-MM-dd"))
                ))
            {
                dataForm.statusLabel.Text = "Добавлен студент: " +
                    String.Join(" ", lastNameTB.Text, firstNameTB.Text, middleNameTB.Text);
                dataForm.pictureBox1.Image = Client.Properties.Resources.zachislen;
            }
            else DialogResult = DialogResult.Abort;
        }
        void EditStudent() 
        {
            //Первичные данные студента
            if (dataForm.RequestQuery(String.Format(
            @"update students set students_name = '{0}', student_check_number = {1}
            where students_name = '{2}' and student_check_number={3};
            update studentsgroups set period = '{4}' where students_id = {5}",
            String.Join(" ", lastNameTB.Text, firstNameTB.Text, middleNameTB.Text),
            checkNumberTB.Text, infoTable.Rows[0][0].ToString(), infoTable.Rows[0][1].ToString(),
            periodDate.Value.ToString("yyyy-MM-dd"), infoTable.Rows[0][4].ToString())))
            {
                dataForm.statusLabel.Text = "Изменены данные студента: " +
                    String.Join(" ", lastNameTB.Text, firstNameTB.Text, middleNameTB.Text);
            }
            else
            {
                DialogResult = DialogResult.Abort;
                return;
            }
            //Если изменена группа
            if(groupEdited)
            {
                if(dataForm.RequestQuery(String.Format(
                @"update studentsgroups set group_id = 
                (select id from groups where group_name = '{0}')
                where students_id = {1}",
                groupNameCB.Text, infoTable.Rows[0][4].ToString()
                )))
                {
                    dataForm.statusLabel.Text = "Студент переведен: " +
                    String.Join(" ", lastNameTB.Text, firstNameTB.Text, middleNameTB.Text) + " => " + 
                    groupNameCB.Text + "(" + abbrNameLabel.Text+ ")";
                    dataForm.pictureBox1.Image = Client.Properties.Resources.pereveden;
                }
                else DialogResult = DialogResult.Abort;
            }
        }
        public void FillStudentsData(string colname, string colvalue)
        {   
            string str = colvalue;
            if (new List<string>(){"group_name", "abbr_name", 
                "students_name", "academic_plan_name", 
            "discipline_name", "discipline_code",}.Contains(colname)) 
	        {str = "'" + str + "'";}
            info = new DataSet();
            dataForm.SelectRequestQuery(String.Format(
            @"select s.students_name,s.student_check_number,g.group_name,sg.period,s.id
            from students as s, groups as g, studentsgroups as sg 
            where s.id=sg.students_id and g.id=sg.group_id 
            and s.{0}={1}",
            colname , str), info);
            infoTable = info.Tables[0];
            List<string> fio = new List<string>();
            fio.AddRange(infoTable.Rows[0][0].ToString().Split(' '));
            string checkNum = infoTable.Rows[0][1].ToString();
            string groupName = infoTable.Rows[0][2].ToString();
            DateTime period = DateTime.Parse(infoTable.Rows[0][3].ToString());
            lastNameTB.Text = fio[0];
            firstNameTB.Text = fio[1];
            middleNameTB.Text = fio[2];
            checkNumberTB.Text = checkNum;
            groupNameCB.Text = groupName;
            periodDate.Value = period;
        }
        private void groupNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = groups.Tables[0];
            abbrNameLabel.Text = dt.Rows[groupNameCB.SelectedIndex][1].ToString();
            groupEdited = true;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (firstNameTB.Text == "" || lastNameTB.Text == "" || middleNameTB.Text == "" ||
                checkNumberTB.Text == "" || groupNameCB.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Abort;
            }
            else 
            {
                if (EditMode) 
                {
                    EditStudent();
                }
                else
                {
                    AddNewStudent();
                }
                Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Load&Close
        private void EditStudentsForm_Load(object sender, EventArgs e)
        {
            groups = new DataSet();
            groupNameCB.DataSource = dataForm.SelectRequestQuery(
                "select group_name, abbr_name from groups", groups).Tables[0];
            groupNameCB.DisplayMember = "group_name";
            if(EditMode)
            {
                FillStudentsData(ColName, ColValue);
                editButton.Text = "Изменить студента";
                groupEdited = false;
            }

        }
        private void EditStudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Abort) e.Cancel = true;
            else
            {
                firstNameTB.Text = lastNameTB.Text = middleNameTB.Text = 
                    checkNumberTB.Text = groupNameCB.Text = abbrNameLabel.Text = "";
                EditMode = false;
            }
        }
        #endregion
    }
}