namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.connectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.dbNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.serverPortTB = new System.Windows.Forms.TextBox();
            this.serverHostTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queryGB = new System.Windows.Forms.GroupBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.queryTB = new System.Windows.Forms.TextBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.FileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WatchTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showGroupsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.devModeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.launchHelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationsGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.queryGB.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGrid.Location = new System.Drawing.Point(287, 27);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.Size = new System.Drawing.Size(613, 469);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 128);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(250, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Подключиться к серверу";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.dbNameTB);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.usernameTB);
            this.groupBox1.Controls.Add(this.serverPortTB);
            this.groupBox1.Controls.Add(this.serverHostTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение к серверу";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(6, 157);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(250, 23);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Отключиться от сервера";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // dbNameTB
            // 
            this.dbNameTB.Location = new System.Drawing.Point(114, 102);
            this.dbNameTB.Name = "dbNameTB";
            this.dbNameTB.Size = new System.Drawing.Size(142, 20);
            this.dbNameTB.TabIndex = 9;
            this.dbNameTB.Text = "LinJay";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(114, 76);
            this.passwordTB.MaxLength = 64;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(142, 20);
            this.passwordTB.TabIndex = 8;
            this.passwordTB.Text = "RbITIG";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(114, 50);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(142, 20);
            this.usernameTB.TabIndex = 7;
            this.usernameTB.Text = "lysenko";
            // 
            // serverPortTB
            // 
            this.serverPortTB.Location = new System.Drawing.Point(218, 24);
            this.serverPortTB.MaxLength = 5;
            this.serverPortTB.Name = "serverPortTB";
            this.serverPortTB.Size = new System.Drawing.Size(38, 20);
            this.serverPortTB.TabIndex = 6;
            this.serverPortTB.Text = "5432";
            // 
            // serverHostTB
            // 
            this.serverHostTB.Location = new System.Drawing.Point(113, 24);
            this.serverHostTB.Name = "serverHostTB";
            this.serverHostTB.Size = new System.Drawing.Size(95, 20);
            this.serverHostTB.TabIndex = 5;
            this.serverHostTB.Text = "192.168.54.21";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя базы данных:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер/Порт:";
            // 
            // queryGB
            // 
            this.queryGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryGB.Controls.Add(this.queryButton);
            this.queryGB.Controls.Add(this.queryTB);
            this.queryGB.Location = new System.Drawing.Point(287, 370);
            this.queryGB.Name = "queryGB";
            this.queryGB.Size = new System.Drawing.Size(613, 132);
            this.queryGB.TabIndex = 4;
            this.queryGB.TabStop = false;
            this.queryGB.Text = "Выполнить SQL-запрос";
            this.queryGB.Visible = false;
            // 
            // queryButton
            // 
            this.queryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.queryButton.Location = new System.Drawing.Point(6, 103);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(257, 23);
            this.queryButton.TabIndex = 10;
            this.queryButton.Text = "Выполнить";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // queryTB
            // 
            this.queryTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTB.Location = new System.Drawing.Point(6, 19);
            this.queryTB.Multiline = true;
            this.queryTB.Name = "queryTB";
            this.queryTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queryTB.Size = new System.Drawing.Size(601, 78);
            this.queryTB.TabIndex = 0;
            this.queryTB.TextChanged += new System.EventHandler(this.QueryTB_TextChanged);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSMI,
            this.WatchTSMI,
            this.ViewTSMI,
            this.HelpTSMI});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(912, 24);
            this.menuBar.TabIndex = 6;
            this.menuBar.Text = "menuStrip1";
            // 
            // FileTSMI
            // 
            this.FileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppTSMI});
            this.FileTSMI.Name = "FileTSMI";
            this.FileTSMI.Size = new System.Drawing.Size(48, 20);
            this.FileTSMI.Text = "Файл";
            // 
            // closeAppTSMI
            // 
            this.closeAppTSMI.Name = "closeAppTSMI";
            this.closeAppTSMI.Size = new System.Drawing.Size(120, 22);
            this.closeAppTSMI.Text = "Закрыть";
            // 
            // WatchTSMI
            // 
            this.WatchTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGroupsTSMI,
            this.showStudentsTSMI});
            this.WatchTSMI.Name = "WatchTSMI";
            this.WatchTSMI.Size = new System.Drawing.Size(76, 20);
            this.WatchTSMI.Text = "Просмотр";
            // 
            // showGroupsTSMI
            // 
            this.showGroupsTSMI.Name = "showGroupsTSMI";
            this.showGroupsTSMI.Size = new System.Drawing.Size(214, 22);
            this.showGroupsTSMI.Text = "Просмотр всех групп";
            this.showGroupsTSMI.Click += new System.EventHandler(this.showGroupsTSMI_Click);
            // 
            // showStudentsTSMI
            // 
            this.showStudentsTSMI.Name = "showStudentsTSMI";
            this.showStudentsTSMI.Size = new System.Drawing.Size(214, 22);
            this.showStudentsTSMI.Text = "Просмотр всех студентов";
            this.showStudentsTSMI.Click += new System.EventHandler(this.showStudentsTSMI_Click);
            // 
            // ViewTSMI
            // 
            this.ViewTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devModeTSMI});
            this.ViewTSMI.Name = "ViewTSMI";
            this.ViewTSMI.Size = new System.Drawing.Size(39, 20);
            this.ViewTSMI.Text = "Вид";
            // 
            // devModeTSMI
            // 
            this.devModeTSMI.CheckOnClick = true;
            this.devModeTSMI.Name = "devModeTSMI";
            this.devModeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.devModeTSMI.Size = new System.Drawing.Size(234, 22);
            this.devModeTSMI.Text = "Режим разработчика";
            this.devModeTSMI.Click += new System.EventHandler(this.devModeTSMI_Click);
            // 
            // HelpTSMI
            // 
            this.HelpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchHelpTSMI});
            this.HelpTSMI.Name = "HelpTSMI";
            this.HelpTSMI.Size = new System.Drawing.Size(65, 20);
            this.HelpTSMI.Text = "Справка";
            // 
            // launchHelpTSMI
            // 
            this.launchHelpTSMI.Name = "launchHelpTSMI";
            this.launchHelpTSMI.Size = new System.Drawing.Size(156, 22);
            this.launchHelpTSMI.Text = "Вызов справки";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(223, 17);
            this.statusLabel.Text = "Подключение к серверу не выполнено";
            // 
            // operationsGB
            // 
            this.operationsGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.operationsGB.Location = new System.Drawing.Point(13, 222);
            this.operationsGB.Name = "operationsGB";
            this.operationsGB.Size = new System.Drawing.Size(268, 274);
            this.operationsGB.TabIndex = 8;
            this.operationsGB.TabStop = false;
            this.operationsGB.Text = "Действия с элементом: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.operationsGB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.queryGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Редактор базы данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.queryGB.ResumeLayout(false);
            this.queryGB.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dbNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox serverPortTB;
        private System.Windows.Forms.TextBox serverHostTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox queryGB;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox queryTB;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem FileTSMI;
        private System.Windows.Forms.ToolStripMenuItem ViewTSMI;
        private System.Windows.Forms.ToolStripMenuItem HelpTSMI;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem devModeTSMI;
        private System.Windows.Forms.ToolStripMenuItem WatchTSMI;
        private System.Windows.Forms.ToolStripMenuItem showGroupsTSMI;
        private System.Windows.Forms.ToolStripMenuItem showStudentsTSMI;
        private System.Windows.Forms.ToolStripMenuItem closeAppTSMI;
        private System.Windows.Forms.ToolStripMenuItem launchHelpTSMI;
        private System.Windows.Forms.GroupBox operationsGB;
    }
}

