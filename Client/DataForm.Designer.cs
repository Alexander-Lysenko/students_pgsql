namespace Client
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.queryGB = new System.Windows.Forms.GroupBox();
            this.developerQueryBtn = new System.Windows.Forms.Button();
            this.developerQueryTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.FileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.devModeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.launchHelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationsGB = new System.Windows.Forms.GroupBox();
            this.showInfoBtn = new System.Windows.Forms.Button();
            this.ColValueTB = new System.Windows.Forms.TextBox();
            this.ColNameLbl = new System.Windows.Forms.Label();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.editSheetBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.ShowGroupsBtn = new System.Windows.Forms.Button();
            this.emptyDataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.queryGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.operationsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.dataGrid.Size = new System.Drawing.Size(635, 550);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // queryGB
            // 
            this.queryGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryGB.Controls.Add(this.developerQueryBtn);
            this.queryGB.Controls.Add(this.developerQueryTB);
            this.queryGB.Location = new System.Drawing.Point(1, 0);
            this.queryGB.Name = "queryGB";
            this.queryGB.Size = new System.Drawing.Size(268, 155);
            this.queryGB.TabIndex = 4;
            this.queryGB.TabStop = false;
            this.queryGB.Text = "Выполнить SQL-запрос";
            this.queryGB.Visible = false;
            // 
            // developerQueryBtn
            // 
            this.developerQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.developerQueryBtn.Location = new System.Drawing.Point(6, 118);
            this.developerQueryBtn.Name = "developerQueryBtn";
            this.developerQueryBtn.Size = new System.Drawing.Size(256, 23);
            this.developerQueryBtn.TabIndex = 10;
            this.developerQueryBtn.Text = "Выполнить";
            this.developerQueryBtn.UseVisualStyleBackColor = true;
            this.developerQueryBtn.Click += new System.EventHandler(this.developerQueryBtn_Click);
            // 
            // developerQueryTB
            // 
            this.developerQueryTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.developerQueryTB.Location = new System.Drawing.Point(5, 13);
            this.developerQueryTB.Multiline = true;
            this.developerQueryTB.Name = "developerQueryTB";
            this.developerQueryTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.developerQueryTB.Size = new System.Drawing.Size(256, 99);
            this.developerQueryTB.TabIndex = 0;
            this.developerQueryTB.TextChanged += new System.EventHandler(this.developerQueryTB_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.queryGB);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 153);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSMI,
            this.ViewTSMI,
            this.HelpTSMI});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(934, 24);
            this.menuBar.TabIndex = 6;
            this.menuBar.Text = "menuStrip1";
            // 
            // FileTSMI
            // 
            this.FileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectTSMI,
            this.closeAppTSMI});
            this.FileTSMI.Name = "FileTSMI";
            this.FileTSMI.Size = new System.Drawing.Size(48, 20);
            this.FileTSMI.Text = "Файл";
            // 
            // disconnectTSMI
            // 
            this.disconnectTSMI.Name = "disconnectTSMI";
            this.disconnectTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.disconnectTSMI.Size = new System.Drawing.Size(279, 22);
            this.disconnectTSMI.Text = "Отключиться от сервера";
            this.disconnectTSMI.Click += new System.EventHandler(this.disconnectTSMI_Click);
            // 
            // closeAppTSMI
            // 
            this.closeAppTSMI.Name = "closeAppTSMI";
            this.closeAppTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeAppTSMI.Size = new System.Drawing.Size(279, 22);
            this.closeAppTSMI.Text = "Закрыть";
            this.closeAppTSMI.Click += new System.EventHandler(this.closeAppTSMI_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
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
            this.operationsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.operationsGB.Controls.Add(this.showInfoBtn);
            this.operationsGB.Controls.Add(this.ColValueTB);
            this.operationsGB.Controls.Add(this.ColNameLbl);
            this.operationsGB.Location = new System.Drawing.Point(13, 121);
            this.operationsGB.Name = "operationsGB";
            this.operationsGB.Size = new System.Drawing.Size(268, 90);
            this.operationsGB.TabIndex = 8;
            this.operationsGB.TabStop = false;
            this.operationsGB.Text = "Действия с элементом: ";
            // 
            // showInfoBtn
            // 
            this.showInfoBtn.Location = new System.Drawing.Point(7, 58);
            this.showInfoBtn.Name = "showInfoBtn";
            this.showInfoBtn.Size = new System.Drawing.Size(256, 23);
            this.showInfoBtn.TabIndex = 2;
            this.showInfoBtn.UseVisualStyleBackColor = true;
            this.showInfoBtn.Click += new System.EventHandler(this.ShowInfoBtn_Click);
            // 
            // ColValueTB
            // 
            this.ColValueTB.Location = new System.Drawing.Point(7, 32);
            this.ColValueTB.Name = "ColValueTB";
            this.ColValueTB.Size = new System.Drawing.Size(256, 20);
            this.ColValueTB.TabIndex = 1;
            // 
            // ColNameLbl
            // 
            this.ColNameLbl.AutoEllipsis = true;
            this.ColNameLbl.Location = new System.Drawing.Point(6, 16);
            this.ColNameLbl.Name = "ColNameLbl";
            this.ColNameLbl.Size = new System.Drawing.Size(256, 13);
            this.ColNameLbl.TabIndex = 0;
            this.ColNameLbl.Text = "Элемент";
            this.ColNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.Enabled = false;
            this.deleteStudentBtn.Location = new System.Drawing.Point(7, 77);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(256, 23);
            this.deleteStudentBtn.TabIndex = 7;
            this.deleteStudentBtn.Text = "Отчислить студента";
            this.deleteStudentBtn.UseVisualStyleBackColor = true;
            this.deleteStudentBtn.Click += new System.EventHandler(this.deleteStudentBtn_Click);
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.Enabled = false;
            this.editStudentBtn.Location = new System.Drawing.Point(7, 48);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(256, 23);
            this.editStudentBtn.TabIndex = 6;
            this.editStudentBtn.Text = "Изменить данные студента";
            this.editStudentBtn.UseVisualStyleBackColor = true;
            this.editStudentBtn.Click += new System.EventHandler(this.editStudentBtn_Click);
            // 
            // editSheetBtn
            // 
            this.editSheetBtn.Location = new System.Drawing.Point(6, 50);
            this.editSheetBtn.Name = "editSheetBtn";
            this.editSheetBtn.Size = new System.Drawing.Size(256, 23);
            this.editSheetBtn.TabIndex = 5;
            this.editSheetBtn.Text = "Заполнить/Изменить ведомость группы";
            this.editSheetBtn.UseVisualStyleBackColor = true;
            this.editSheetBtn.Click += new System.EventHandler(this.editSheetBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(7, 19);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(256, 23);
            this.addStudentBtn.TabIndex = 4;
            this.addStudentBtn.Text = "Добавить студента";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // ShowGroupsBtn
            // 
            this.ShowGroupsBtn.Location = new System.Drawing.Point(6, 19);
            this.ShowGroupsBtn.Name = "ShowGroupsBtn";
            this.ShowGroupsBtn.Size = new System.Drawing.Size(256, 23);
            this.ShowGroupsBtn.TabIndex = 3;
            this.ShowGroupsBtn.Text = "Показать список всех групп";
            this.ShowGroupsBtn.UseVisualStyleBackColor = true;
            this.ShowGroupsBtn.Click += new System.EventHandler(this.ShowGroupsBtn_Click);
            // 
            // emptyDataSet
            // 
            this.emptyDataSet.DataSetName = "NewDataSet";
            this.emptyDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.addStudentBtn);
            this.groupBox2.Controls.Add(this.editStudentBtn);
            this.groupBox2.Controls.Add(this.deleteStudentBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 107);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия со студентами";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.ShowGroupsBtn);
            this.groupBox3.Controls.Add(this.editSheetBtn);
            this.groupBox3.Location = new System.Drawing.Point(13, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 80);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия с группами";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 602);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.operationsGB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "DataForm";
            this.Text = "Редактор базы данных";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.queryGB.ResumeLayout(false);
            this.queryGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.operationsGB.ResumeLayout(false);
            this.operationsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox queryGB;
        private System.Windows.Forms.Button developerQueryBtn;
        private System.Windows.Forms.TextBox developerQueryTB;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem FileTSMI;
        private System.Windows.Forms.ToolStripMenuItem ViewTSMI;
        private System.Windows.Forms.ToolStripMenuItem HelpTSMI;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem devModeTSMI;
        private System.Windows.Forms.ToolStripMenuItem closeAppTSMI;
        private System.Windows.Forms.ToolStripMenuItem launchHelpTSMI;
        private System.Windows.Forms.GroupBox operationsGB;
        private System.Windows.Forms.TextBox ColValueTB;
        private System.Windows.Forms.Label ColNameLbl;
        private System.Windows.Forms.Button showInfoBtn;
        private System.Windows.Forms.Button ShowGroupsBtn;
        private System.Windows.Forms.ToolStripMenuItem disconnectTSMI;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button editSheetBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button editStudentBtn;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.DataSet emptyDataSet;
        private System.Data.DataTable dataTable1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

