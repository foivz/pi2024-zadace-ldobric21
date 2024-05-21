namespace CityTransportLD
{
    partial class FrmAddDrivingSchedule
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDrivingLines = new System.Windows.Forms.ListBox();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStations = new System.Windows.Forms.ListBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lbTimeMoney = new System.Windows.Forms.ListBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraži:";
            // 
            // lbDrivingLines
            // 
            this.lbDrivingLines.FormattingEnabled = true;
            this.lbDrivingLines.Location = new System.Drawing.Point(12, 55);
            this.lbDrivingLines.Name = "lbDrivingLines";
            this.lbDrivingLines.Size = new System.Drawing.Size(148, 251);
            this.lbDrivingLines.TabIndex = 4;
            this.lbDrivingLines.SelectedIndexChanged += new System.EventHandler(this.lbDrivingLines_SelectedIndexChanged);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(184, 26);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(282, 20);
            this.txtSearch2.TabIndex = 9;
            this.txtSearch2.TextChanged += new System.EventHandler(this.txtSearch2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pretraži:";
            // 
            // lbStations
            // 
            this.lbStations.FormattingEnabled = true;
            this.lbStations.Location = new System.Drawing.Point(184, 55);
            this.lbStations.Name = "lbStations";
            this.lbStations.Size = new System.Drawing.Size(282, 251);
            this.lbStations.TabIndex = 7;
            this.lbStations.SelectedIndexChanged += new System.EventHandler(this.lbStations_SelectedIndexChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(486, 26);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(70, 20);
            this.dtpTime.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(648, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(729, 21);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(98, 28);
            this.btnRemoveSelected.TabIndex = 12;
            this.btnRemoveSelected.Text = "Makni označeno";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // lbTimeMoney
            // 
            this.lbTimeMoney.FormattingEnabled = true;
            this.lbTimeMoney.Location = new System.Drawing.Point(486, 56);
            this.lbTimeMoney.Name = "lbTimeMoney";
            this.lbTimeMoney.Size = new System.Drawing.Size(341, 251);
            this.lbTimeMoney.TabIndex = 13;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(562, 26);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(66, 20);
            this.txtMoney.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "€";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(729, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddDrivingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 352);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lbTimeMoney);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStations);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDrivingLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAddDrivingSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zapis";
            this.Load += new System.EventHandler(this.FrmAddDrivingSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDrivingLines;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbStations;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.ListBox lbTimeMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}