using CityTransportLD.Models;
using CityTransportLD.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityTransportLD
{
    public partial class FrmEditVehicle : Form
    {
        Employee CurrentEmployee;
        Vehicle SelectedVehicle;
        public FrmEditVehicle(Employee currentEmployee, Vehicle selectedVehicle)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
            SelectedVehicle = selectedVehicle;
        }

        private void FrmEditVehicle_Load(object sender, EventArgs e)
        {
            txtId.Text = SelectedVehicle.Id.ToString();
            txtRegistration.Text = SelectedVehicle.Registration.ToString();
            txtCapacity.Text = SelectedVehicle.Capacity.ToString();
            dtpService.Value = SelectedVehicle.DateOfService;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int capacity = int.Parse(txtCapacity.Text);
            if (capacity >= 30 && capacity <= 50)
            {
                DateTime selectedDate = dtpService.Value.Date;

                string formattedDate = dtpService.Value.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                VehicleRepository.EditVehicle(int.Parse(txtId.Text), txtRegistration.Text, capacity.ToString(), formattedDate, CurrentEmployee.Id);
                Close();
            } else
            {
                MessageBox.Show("Kapacitet vozila smije biti od 30 do 50!", "Krivi kapacitet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
