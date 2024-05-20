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
    public partial class FrmStations : Form
    {
        Employee CurrentEmployee;
        public FrmStations(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
        }

        private void FrmStations_Load(object sender, EventArgs e)
        {     
            UpdateDataGridView();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvStations.Columns[0].HeaderText = "Id";
            dgvStations.Columns[1].HeaderText = "Adresa";
            dgvStations.Columns[2].HeaderText = "Dodatni opis";
        }

        private void UpdateDataGridView()
        {
            dgvStations.DataSource = StationRepository.GetStations();
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            FrmAddStation frmAddStation = new FrmAddStation();
            frmAddStation.ShowDialog();
            UpdateDataGridView();
        }
    }
}
