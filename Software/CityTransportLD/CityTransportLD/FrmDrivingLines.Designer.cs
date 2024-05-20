namespace CityTransportLD
{
    partial class FrmDrivingLines
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
            this.dgvDrivingLines = new System.Windows.Forms.DataGridView();
            this.btnAddDrivingLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrivingLines
            // 
            this.dgvDrivingLines.AllowUserToAddRows = false;
            this.dgvDrivingLines.AllowUserToDeleteRows = false;
            this.dgvDrivingLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivingLines.Location = new System.Drawing.Point(12, 12);
            this.dgvDrivingLines.MultiSelect = false;
            this.dgvDrivingLines.Name = "dgvDrivingLines";
            this.dgvDrivingLines.ReadOnly = true;
            this.dgvDrivingLines.Size = new System.Drawing.Size(676, 305);
            this.dgvDrivingLines.TabIndex = 0;
            // 
            // btnAddDrivingLine
            // 
            this.btnAddDrivingLine.Location = new System.Drawing.Point(12, 323);
            this.btnAddDrivingLine.Name = "btnAddDrivingLine";
            this.btnAddDrivingLine.Size = new System.Drawing.Size(118, 41);
            this.btnAddDrivingLine.TabIndex = 1;
            this.btnAddDrivingLine.Text = "Dodaj novu liniju";
            this.btnAddDrivingLine.UseVisualStyleBackColor = true;
            this.btnAddDrivingLine.Click += new System.EventHandler(this.btnAddDrivingLine_Click);
            // 
            // FrmDrivingLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 376);
            this.Controls.Add(this.btnAddDrivingLine);
            this.Controls.Add(this.dgvDrivingLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDrivingLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linije";
            this.Load += new System.EventHandler(this.FrmDrivingLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrivingLines;
        private System.Windows.Forms.Button btnAddDrivingLine;
    }
}