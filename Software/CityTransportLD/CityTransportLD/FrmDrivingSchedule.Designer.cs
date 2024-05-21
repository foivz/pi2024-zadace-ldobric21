namespace CityTransportLD
{
    partial class FrmDrivingSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddDrivingSchedule = new System.Windows.Forms.Button();
            this.lbDrivingLines = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDrivingSchedule = new System.Windows.Forms.DataGridView();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDrivingSchedule
            // 
            this.btnAddDrivingSchedule.Location = new System.Drawing.Point(12, 394);
            this.btnAddDrivingSchedule.Name = "btnAddDrivingSchedule";
            this.btnAddDrivingSchedule.Size = new System.Drawing.Size(148, 44);
            this.btnAddDrivingSchedule.TabIndex = 0;
            this.btnAddDrivingSchedule.Text = "Dodaj novi zapis";
            this.btnAddDrivingSchedule.UseVisualStyleBackColor = true;
            this.btnAddDrivingSchedule.Click += new System.EventHandler(this.btnAddDrivingSchedule_Click);
            // 
            // lbDrivingLines
            // 
            this.lbDrivingLines.FormattingEnabled = true;
            this.lbDrivingLines.Location = new System.Drawing.Point(12, 59);
            this.lbDrivingLines.Name = "lbDrivingLines";
            this.lbDrivingLines.Size = new System.Drawing.Size(148, 329);
            this.lbDrivingLines.TabIndex = 1;
            this.lbDrivingLines.SelectedIndexChanged += new System.EventHandler(this.lbDrivingLines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraži:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vozni Red";
            // 
            // dgvDrivingSchedule
            // 
            this.dgvDrivingSchedule.AllowUserToAddRows = false;
            this.dgvDrivingSchedule.AllowUserToDeleteRows = false;
            this.dgvDrivingSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrivingSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrivingSchedule.Location = new System.Drawing.Point(166, 59);
            this.dgvDrivingSchedule.MultiSelect = false;
            this.dgvDrivingSchedule.Name = "dgvDrivingSchedule";
            this.dgvDrivingSchedule.ReadOnly = true;
            this.dgvDrivingSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivingSchedule.Size = new System.Drawing.Size(860, 429);
            this.dgvDrivingSchedule.TabIndex = 5;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(166, 27);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.ReadOnly = true;
            this.txtVehicle.Size = new System.Drawing.Size(120, 20);
            this.txtVehicle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vozilo:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 44);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Obriši označeni";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDrivingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 494);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.dgvDrivingSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDrivingLines);
            this.Controls.Add(this.btnAddDrivingSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDrivingSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozni red";
            this.Load += new System.EventHandler(this.FrmDrivingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDrivingSchedule;
        private System.Windows.Forms.ListBox lbDrivingLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDrivingSchedule;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
    }
}