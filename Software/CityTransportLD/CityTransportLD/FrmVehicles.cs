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
    public partial class FrmVehicles : Form
    {
        Employee CurrentEmployee;
        public FrmVehicles(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
        }

        private void FrmVehicles_Load(object sender, EventArgs e)
        {    
            UpdateDataGridView();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvVehicles.Columns[0].HeaderText = "Id";
            dgvVehicles.Columns[1].HeaderText = "Registracija";
            dgvVehicles.Columns[2].HeaderText = "Kapacitet";
            dgvVehicles.Columns[3].HeaderText = "Datum servisa";
            dgvVehicles.Columns[4].HeaderText = "Zaposlenik";
        }

        private void UpdateDataGridView()
        {
            dgvVehicles.DataSource = VehicleRepository.GetVehicles();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            FrmAddVehicle frmAddVehicle = new FrmAddVehicle(CurrentEmployee);
            frmAddVehicle.ShowDialog();
            UpdateDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvVehicles.SelectedRows[0];

            Vehicle selectedVehicle = selectedRow.DataBoundItem as Vehicle;

            VehicleRepository.DeleteVehicle(selectedVehicle.Id);

            UpdateDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvVehicles.SelectedRows[0];

            Vehicle selectedVehicle = selectedRow.DataBoundItem as Vehicle;

            FrmEditVehicle frmEditVehicle = new FrmEditVehicle(CurrentEmployee, selectedVehicle);
            frmEditVehicle.ShowDialog();

            UpdateDataGridView();
        }
    }

} 

