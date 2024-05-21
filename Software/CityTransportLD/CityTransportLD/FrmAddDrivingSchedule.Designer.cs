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
            this.dgvDrivingSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrivingSchedule
            // 
            this.dgvDrivingSchedule.AllowUserToAddRows = false;
            this.dgvDrivingSchedule.AllowUserToDeleteRows = false;
            this.dgvDrivingSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivingSchedule.Location = new System.Drawing.Point(12, 133);
            this.dgvDrivingSchedule.MultiSelect = false;
            this.dgvDrivingSchedule.Name = "dgvDrivingSchedule";
            this.dgvDrivingSchedule.ReadOnly = true;
            this.dgvDrivingSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDrivingSchedule.Size = new System.Drawing.Size(662, 319);
            this.dgvDrivingSchedule.TabIndex = 0;
            // 
            // FrmAddDrivingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 482);
            this.Controls.Add(this.dgvDrivingSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAddDrivingSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zapis";
            this.Load += new System.EventHandler(this.FrmAddDrivingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrivingSchedule;
    }
}