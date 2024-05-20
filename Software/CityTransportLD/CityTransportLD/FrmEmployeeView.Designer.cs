namespace CityTransportLD
{
    partial class FrmEmployeeView
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.txtDrivingLine = new System.Windows.Forms.Button();
            this.btnStations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(12, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(354, 23);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Prijavljeni Korisnik";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(51, 55);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(279, 37);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Text = "Vozila";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // txtDrivingLine
            // 
            this.txtDrivingLine.Location = new System.Drawing.Point(51, 178);
            this.txtDrivingLine.Name = "txtDrivingLine";
            this.txtDrivingLine.Size = new System.Drawing.Size(279, 37);
            this.txtDrivingLine.TabIndex = 2;
            this.txtDrivingLine.Text = "Linije";
            this.txtDrivingLine.UseVisualStyleBackColor = true;
            this.txtDrivingLine.Click += new System.EventHandler(this.txtDrivingLine_Click);
            // 
            // btnStations
            // 
            this.btnStations.Location = new System.Drawing.Point(51, 117);
            this.btnStations.Name = "btnStations";
            this.btnStations.Size = new System.Drawing.Size(279, 37);
            this.btnStations.TabIndex = 3;
            this.btnStations.Text = "Stanice";
            this.btnStations.UseVisualStyleBackColor = true;
            this.btnStations.Click += new System.EventHandler(this.btnStations_Click);
            // 
            // FrmEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 589);
            this.Controls.Add(this.btnStations);
            this.Controls.Add(this.txtDrivingLine);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.lblEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenik";
            this.Load += new System.EventHandler(this.FrmEmployeeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button txtDrivingLine;
        private System.Windows.Forms.Button btnStations;
    }
}