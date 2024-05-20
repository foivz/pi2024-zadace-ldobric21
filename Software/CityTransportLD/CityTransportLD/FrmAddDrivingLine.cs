using CityTransportLD.Models;
using CityTransportLD.Repositories;
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
    public partial class FrmAddDrivingLine : Form
    {
        public FrmAddDrivingLine()
        {
            InitializeComponent();
        }

        private void FrmAddDrivingLine_Load(object sender, EventArgs e)
        {
            cmbVehicle.DataSource = VehicleRepository.GetVehicles();
            cmbVehicle.DisplayMember = "Registration";
            cmbVehicle.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DrivingLineRepository.InsertDrivingLine(int.Parse(txtId.Text), txtName.Text);
            Close();
        }

        private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = cmbVehicle.SelectedItem as Vehicle;
            txtId.Text = selectedVehicle.Id.ToString();
        }
    }
}
