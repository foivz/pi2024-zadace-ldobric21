using CityTransportLD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityTransportLD
{
    public partial class FrmEmployeeView : Form
    {
        Employee CurrentEmployee;
        public FrmEmployeeView(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
            
        }

        private void FrmEmployeeView_Load(object sender, EventArgs e)
        {
            lblEmployee.Text = CurrentEmployee.ToString();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            FrmVehicles frmVehicles = new FrmVehicles(CurrentEmployee);
            frmVehicles.ShowDialog();
        }

        private void txtDrivingLine_Click(object sender, EventArgs e)
        {
            FrmDrivingLines frmDrivingLines = new FrmDrivingLines();
            frmDrivingLines.ShowDialog();
        }

        private void btnStations_Click(object sender, EventArgs e)
        {
            FrmStations frmStations = new FrmStations();
            frmStations.ShowDialog();
        }

        private void btnDrivingSchedule_Click(object sender, EventArgs e)
        {
            FrmDrivingSchedule frmDrivingSchedule = new FrmDrivingSchedule(CurrentEmployee);
            frmDrivingSchedule.Show();
        }
    }
}
