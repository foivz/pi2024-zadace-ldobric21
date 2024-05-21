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
using System.Xml.Linq;

namespace CityTransportLD
{
    public partial class FrmDrivingSchedule : Form
    {
        DrivingLine SelectedDrivingLine = null;
        Employee CurrentEmployee;
        public FrmDrivingSchedule(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
            if (CurrentEmployee == null)
            {
                btnAddDrivingSchedule.Enabled = false;
            }
        }

        private void FrmDrivingSchedule_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void btnAddDrivingSchedule_Click(object sender, EventArgs e)
        {
            FrmAddDrivingSchedule frmAddDrivingSchedule = new FrmAddDrivingSchedule();
            frmAddDrivingSchedule.ShowDialog();
        }

        private void FillListBox()
        {
            lbDrivingLines.Items.Clear();
            foreach (var dl in DrivingLineRepository.GetDrivingLines())
            {
                lbDrivingLines.Items.Add(dl.Id + " " + dl.Name);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lbDrivingLines.Items.Clear();
            foreach (var dl in DrivingLineRepository.GetDrivingLines())
            {
                if (dl.ToString().Contains(txtSearch.Text))
                {
                    lbDrivingLines.Items.Add(dl.Id + " " + dl.Name);
                }
            }
        }

        private void lbDrivingLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedDrivingLineId = lbDrivingLines.SelectedItem.ToString().Split(' ')[0];
                SelectedDrivingLine = DrivingLineRepository.GetDrivingLine(int.Parse(selectedDrivingLineId));
                txtVehicle.Text = VehicleRepository.GetVehicle(SelectedDrivingLine.IdVehicle).ToString();
                InitializeDataGridView();
            } catch {}
        }

        private void InitializeDataGridView()
        {
            try
            {
                dgvDrivingSchedule.Columns.Clear();
                DataGridViewTextBoxColumn stationColumn = new DataGridViewTextBoxColumn();
                stationColumn.HeaderText = "Stanica";
                dgvDrivingSchedule.Columns.Add(stationColumn);

                DataGridViewTextBoxColumn adressColumn = new DataGridViewTextBoxColumn();
                adressColumn.HeaderText = "Adresa";
                dgvDrivingSchedule.Columns.Add(adressColumn);

                DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
                descriptionColumn.HeaderText = "Dodatni opis";
                dgvDrivingSchedule.Columns.Add(descriptionColumn);

                Dictionary<int, int> countMap = new Dictionary<int, int>();

                var drivingSchedulesByDrivingLine = DrivingScheduleRepository.GetDrivingSchedulesByDrivingLine(SelectedDrivingLine.Id);

                List<int> allStationIds = new List<int>();

                foreach (DrivingSchedule ds in drivingSchedulesByDrivingLine)
                {
                    if (countMap.ContainsKey(ds.IdStation))
                    {
                        countMap[ds.IdStation]++;
                    } else
                    {
                        countMap[ds.IdStation] = 1;
                    }

                    allStationIds.Add(ds.IdStation);
                }

                int maxTimesOfDeparture = countMap.Values.Max();

                for (int i = 0; i < maxTimesOfDeparture; i++)
                {

                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                    newColumn.HeaderText = $"{i + 1}.";
                    newColumn.Name = $"Column{i + 1}";

                    dgvDrivingSchedule.Columns.Add(newColumn);
                }

                IEnumerable<int> uniqueStationIds = allStationIds.Distinct();

                int rowCounter = 0;

                foreach (int stationId in uniqueStationIds)
                {
                    dgvDrivingSchedule.Rows.Add();


                    dgvDrivingSchedule.Rows[rowCounter].Cells[0].Value = stationId;
                    dgvDrivingSchedule.Rows[rowCounter].Cells[1].Value = StationRepository.GetStation(stationId).Adress;
                    dgvDrivingSchedule.Rows[rowCounter].Cells[2].Value = StationRepository.GetStation(stationId).Description;

                    var stationLines = DrivingScheduleRepository.GetDrivingSchedulesByDrivingLineByStation(SelectedDrivingLine.Id, stationId);

                    int cellCounter = 3;
                    foreach (DrivingSchedule ds in stationLines)
                    {
                        dgvDrivingSchedule.Rows[rowCounter].Cells[cellCounter].Value = ds.TimeOfDeparture.ToString().Split(' ')[1] + " | " + ds.Price + "€";
                        cellCounter++;
                    }

                    rowCounter++;
                }
            } catch {}

        }
    }
}
