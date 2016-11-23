namespace Client
{
    partial class SheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheetForm));
            this.sheetTable = new System.Windows.Forms.DataGridView();
            this.groupsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowSheetButton = new System.Windows.Forms.Button();
            this.semestrCB = new System.Windows.Forms.ComboBox();
            this.disciplineCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveSheetButton = new System.Windows.Forms.Button();
            this.formControlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sheetTable)).BeginInit();
            this.SuspendLayout();
            // 
            // sheetTable
            // 
            this.sheetTable.AllowUserToAddRows = false;
            this.sheetTable.AllowUserToDeleteRows = false;
            this.sheetTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sheetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sheetTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sheetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sheetTable.Location = new System.Drawing.Point(12, 115);
            this.sheetTable.Name = "sheetTable";
            this.sheetTable.ReadOnly = true;
            this.sheetTable.RowHeadersVisible = false;
            this.sheetTable.Size = new System.Drawing.Size(410, 385);
            this.sheetTable.TabIndex = 4;
            // 
            // groupsCB
            // 
            this.groupsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsCB.FormattingEnabled = true;
            this.groupsCB.Location = new System.Drawing.Point(130, 5);
            this.groupsCB.Name = "groupsCB";
            this.groupsCB.Size = new System.Drawing.Size(292, 21);
            this.groupsCB.TabIndex = 0;
            this.groupsCB.SelectedIndexChanged += new System.EventHandler(this.semestrCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите группу";
            // 
            // ShowSheetButton
            // 
            this.ShowSheetButton.Location = new System.Drawing.Point(11, 86);
            this.ShowSheetButton.Name = "ShowSheetButton";
            this.ShowSheetButton.Size = new System.Drawing.Size(192, 23);
            this.ShowSheetButton.TabIndex = 3;
            this.ShowSheetButton.Text = "Показать ведомость";
            this.ShowSheetButton.UseVisualStyleBackColor = true;
            this.ShowSheetButton.Click += new System.EventHandler(this.ShowSheetButton_Click);
            // 
            // semestrCB
            // 
            this.semestrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestrCB.FormattingEnabled = true;
            this.semestrCB.Items.AddRange(new object[] {
            "Семестр 1",
            "Семестр 2",
            "Семестр 3",
            "Семестр 4",
            "Семестр 5",
            "Семестр 6",
            "Семестр 7",
            "Семестр 8"});
            this.semestrCB.Location = new System.Drawing.Point(130, 32);
            this.semestrCB.Name = "semestrCB";
            this.semestrCB.Size = new System.Drawing.Size(292, 21);
            this.semestrCB.TabIndex = 1;
            this.semestrCB.SelectedIndexChanged += new System.EventHandler(this.semestrCB_SelectedIndexChanged);
            // 
            // disciplineCB
            // 
            this.disciplineCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineCB.DropDownWidth = 250;
            this.disciplineCB.FormattingEnabled = true;
            this.disciplineCB.Location = new System.Drawing.Point(130, 59);
            this.disciplineCB.Name = "disciplineCB";
            this.disciplineCB.Size = new System.Drawing.Size(229, 21);
            this.disciplineCB.TabIndex = 2;
            this.disciplineCB.SelectedIndexChanged += new System.EventHandler(this.disciplineCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите семестр ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите дисциплину";
            // 
            // SaveSheetButton
            // 
            this.SaveSheetButton.Enabled = false;
            this.SaveSheetButton.Location = new System.Drawing.Point(219, 86);
            this.SaveSheetButton.Name = "SaveSheetButton";
            this.SaveSheetButton.Size = new System.Drawing.Size(203, 23);
            this.SaveSheetButton.TabIndex = 5;
            this.SaveSheetButton.Text = "Сохранить ведомость";
            this.SaveSheetButton.UseVisualStyleBackColor = true;
            this.SaveSheetButton.Click += new System.EventHandler(this.SaveSheetButton_Click);
            // 
            // formControlLabel
            // 
            this.formControlLabel.Location = new System.Drawing.Point(365, 59);
            this.formControlLabel.Name = "formControlLabel";
            this.formControlLabel.Size = new System.Drawing.Size(57, 21);
            this.formControlLabel.TabIndex = 9;
            this.formControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SheetForm
            // 
            this.AcceptButton = this.ShowSheetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.formControlLabel);
            this.Controls.Add(this.SaveSheetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disciplineCB);
            this.Controls.Add(this.semestrCB);
            this.Controls.Add(this.ShowSheetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupsCB);
            this.Controls.Add(this.sheetTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 1080);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "SheetForm";
            this.ShowInTaskbar = false;
            this.Text = "Заполнить ведомость группы";
            this.Load += new System.EventHandler(this.SheetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sheetTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sheetTable;
        private System.Windows.Forms.ComboBox groupsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowSheetButton;
        private System.Windows.Forms.ComboBox semestrCB;
        private System.Windows.Forms.ComboBox disciplineCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveSheetButton;
        private System.Windows.Forms.Label formControlLabel;
    }
}