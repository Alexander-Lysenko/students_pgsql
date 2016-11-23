using System;
using System.Data;
using System.Windows.Forms;

namespace Client
{
    public partial class SheetForm : Form
    {
        public SheetForm(DataForm df)
        {
            InitializeComponent();
            dataForm  = df;
        }
        DataForm dataForm;
        DataSet sheet;
        DataSet disciplines;


        private void SheetForm_Load(object sender, EventArgs e)
        {
            DataSet groups = new DataSet();
            groupsCB.DataSource = dataForm.SelectRequestQuery("select group_name from groups", groups).Tables[0];
            groupsCB.DisplayMember = "group_name";
            semestrCB.SelectedIndex = 0;
        }
        private void semestrCB_SelectedIndexChanged(object sender, EventArgs e)
        {   
            disciplines = new DataSet();
            disciplineCB.DataSource = dataForm.SelectRequestQuery(String.Format(
                @"select d.discipline_name, f.form_name
                from groups g , semesters s, disciplines d, 
                (select 'Экзамен' as form_name, true as exam, false as credit,false as credit_rating,
                false as course_work, 1 as form_control_id 
                union select 'Зачет', false, true,false,false, 2 
                union select 'Зачет с оценкой', false, false,true,false, 12 
                union select 'Курсовая', false, false,false,true, 3) f 

                where s.semester_id = {0} and g.group_name = '{1}' 
                and s.discipline_id = d.id and d.academic_plan_id = g.academic_plan_id 
                and (f.exam = s.exam or f.credit = s.credit or f.credit_rating = s.credit_rating or f.course_work = s.course_work)",
                semestrCB.SelectedIndex + 1, groupsCB.Text), disciplines).Tables[0];
            disciplineCB.DisplayMember = "discipline_name";
        }
        private void ShowSheetButton_Click(object sender, EventArgs e)
        {
            int xxx = 0;
            switch (formControlLabel.Text)
            {
                case "Зачет": xxx = 2; break;
                case "Экзамен": xxx = 1; break;
                case "Курсовая": xxx = 3; break;
                case "Зачет с оценкой": xxx = 12; break;
            }
            sheet = new DataSet();
            sheetTable.DataSource = dataForm.SelectRequestQuery(String.Format(
            @"select st.students_name,r.rating,r.sheet_number 

            from students st,ratings r,semesters s,groups g,disciplines d, 
            (select 'Экзамен' as form_name, true as exam, false as credit,false as credit_rating,
            false as course_work, 1 as form_control_id 
            union select 'Зачет', false, true,false,false, 2 
            union select 'Зачет с оценкой', false, false,true,false, 12 
            union select 'Курсовая', false, false,false,true, 3) f 


            where r.semester_id = {0} 
            and g.group_name = '{1}' 
            and d.discipline_name='{2}' 
            and r.discipline_id=d.id 
            and form_name='{3}' 
            and r.form_control_id={4} 

            and s.semester_id=r.semester_id 
            and st.id=r.student_id 
            and s.discipline_id = d.id 
            and d.academic_plan_id = g.academic_plan_id 
            and (f.exam = s.exam or f.credit = s.credit or f.credit_rating = s.credit_rating or f.course_work = s.course_work) 
            order by sheet_number,students_name,form_name",
            semestrCB.SelectedIndex + 1, groupsCB.Text, disciplineCB.Text, formControlLabel.Text, xxx), sheet).Tables[0];
            try
            {
                sheetTable.Columns[0].FillWeight = 200;
            } 
            catch (Exception)
            {}
        }
        private void SaveSheetButton_Click(object sender, EventArgs e)
        {
            string period = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void disciplineCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = disciplines.Tables[0];
            formControlLabel.Text = dt.Rows[disciplineCB.SelectedIndex][1].ToString();
        }
        
    }
}
