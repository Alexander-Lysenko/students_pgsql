using System;
using System.Windows.Forms;
using Npgsql;

namespace Client
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        DataForm dataForm;
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
            dataForm = new DataForm(this);
                dataForm.ConnectionString = String.Format("Server={0};Port={1};User={2};Password={3};Database={4};",
                    serverHostTB.Text, serverPortTB.Text, usernameTB.Text, passwordTB.Text, dbNameTB.Text);
                dataForm.npgsqlConnection = new NpgsqlConnection(dataForm.ConnectionString);
                dataForm.npgsqlConnection.Open();
                dataForm.statusLabel.Text = String.Format("Подключено к серверу {0}:{1}", serverHostTB.Text, serverPortTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataForm.Show();
            this.Hide();
        }
    }
}
