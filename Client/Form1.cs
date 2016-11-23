using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String ConnectionString;
        NpgsqlConnection npgsqlConnection;
        string operHeader = "Действия с элементом: ";

        public void RequsetQuery(string queryText)
        {
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryText, npgsqlConnection);
                NpgsqlCommandBuilder cd = new NpgsqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionString = String.Format("Server={0};Port={1};User={2};Password={3};Database={4};",
                    serverHostTB.Text, serverPortTB.Text, usernameTB.Text, passwordTB.Text, dbNameTB.Text);
                npgsqlConnection = new NpgsqlConnection(ConnectionString);
                npgsqlConnection.Open();
                statusLabel.Text = String.Format("Подключено к серверу {0}:{1}", serverHostTB.Text, serverPortTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            serverHostTB.Enabled = serverPortTB.Enabled = usernameTB.Enabled = passwordTB.Enabled = 
                dbNameTB.Enabled = connectButton.Enabled = false;
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            RequsetQuery(queryTB.Text);
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            npgsqlConnection.Close();
            statusLabel.Text = "Отключено от сервера";
            dataGrid.ClearSelection();
            queryTB.Text = "";
            serverHostTB.Enabled = serverPortTB.Enabled = usernameTB.Enabled = passwordTB.Enabled =
                dbNameTB.Enabled = connectButton.Enabled = true;
        }

        private void QueryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void devModeTSMI_Click(object sender, EventArgs e)
        {
            if (devModeTSMI.Checked)
                queryGB.Visible = true;
            else queryGB.Visible = false;
        }

        private void showGroupsTSMI_Click(object sender, EventArgs e)
        {
            RequsetQuery("select * from groups");
        }

        private void showStudentsTSMI_Click(object sender, EventArgs e)
        {
            RequsetQuery("select * from students");

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGrid.Columns[e.ColumnIndex].Name)
            {
                case "abbr_name":
                case "group_name": operationsGB.Text = operHeader + "Группа"; break;
                case "academic_plan_id": operationsGB.Text = operHeader + "Учебный план"; break;
                case "academic_year_id": operationsGB.Text = operHeader + "Поток"; break;
                case "speciality_id": operationsGB.Text = operHeader + "Специальность"; break;
                case "faculty_id": operationsGB.Text = operHeader + "Факультет"; break;

                case "student_name": operationsGB.Text = operHeader + "Студент"; break;
                case "student_check_number": operationsGB.Text = operHeader + "Номер зачетки студента"; break;
                default: operationsGB.Text = operHeader + "Неизвестный элемент"; break;
            }
            //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), 
            //dataGrid.Columns[e.ColumnIndex].Name);        
        }

    }
}
