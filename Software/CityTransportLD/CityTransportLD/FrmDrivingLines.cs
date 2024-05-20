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
    public partial class FrmDrivingLines : Form
    {
        public FrmDrivingLines()
        {
            InitializeComponent();
        }

        private void FrmDrivingLines_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvDrivingLines.Columns[0].HeaderText = "Id";
            dgvDrivingLines.Columns[1].HeaderText = "Id Vozila";
            dgvDrivingLines.Columns[2].HeaderText = "Naziv";
        }

        private void UpdateDataGridView()
        {
            dgvDrivingLines.DataSource = DrivingLineRepository.GetDrivingLines();
        }

        
    }
}
