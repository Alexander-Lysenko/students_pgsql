using System.Windows.Forms;
namespace Client
{
    partial class EditStudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentsForm));
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.groupNameCB = new System.Windows.Forms.ComboBox();
            this.periodDate = new System.Windows.Forms.DateTimePicker();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.checkNumberTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.abbrNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 190);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(410, 30);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Создать студента";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(145, 15);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(277, 20);
            this.lastNameTB.TabIndex = 0;
            // 
            // groupNameCB
            // 
            this.groupNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupNameCB.FormattingEnabled = true;
            this.groupNameCB.Location = new System.Drawing.Point(145, 137);
            this.groupNameCB.Name = "groupNameCB";
            this.groupNameCB.Size = new System.Drawing.Size(200, 21);
            this.groupNameCB.TabIndex = 4;
            this.groupNameCB.SelectedIndexChanged += new System.EventHandler(this.groupNameCB_SelectedIndexChanged);
            // 
            // periodDate
            // 
            this.periodDate.CustomFormat = "yyyy-MM-dd";
            this.periodDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.periodDate.Location = new System.Drawing.Point(145, 164);
            this.periodDate.Name = "periodDate";
            this.periodDate.Size = new System.Drawing.Size(277, 20);
            this.periodDate.TabIndex = 5;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(145, 41);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(277, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(145, 67);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(277, 20);
            this.middleNameTB.TabIndex = 2;
            // 
            // checkNumberTB
            // 
            this.checkNumberTB.Location = new System.Drawing.Point(145, 111);
            this.checkNumberTB.Name = "checkNumberTB";
            this.checkNumberTB.Size = new System.Drawing.Size(277, 20);
            this.checkNumberTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номер зачетной книжки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Группа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата зачисления:";
            // 
            // abbrNameLabel
            // 
            this.abbrNameLabel.Location = new System.Drawing.Point(371, 137);
            this.abbrNameLabel.Name = "abbrNameLabel";
            this.abbrNameLabel.Size = new System.Drawing.Size(51, 21);
            this.abbrNameLabel.TabIndex = 13;
            this.abbrNameLabel.Text = "----";
            this.abbrNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(410, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditStudentsForm
            // 
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.abbrNameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkNumberTB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.periodDate);
            this.Controls.Add(this.groupNameCB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudentsForm";
            this.Text = "Редактирование студента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStudentsForm_FormClosing);
            this.Load += new System.EventHandler(this.EditStudentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label abbrNameLabel;
        private Button cancelButton;
        public Button editButton;
        public TextBox lastNameTB;
        public ComboBox groupNameCB;
        public DateTimePicker periodDate;
        public TextBox firstNameTB;
        public TextBox middleNameTB;
        public TextBox checkNumberTB;
    }
}