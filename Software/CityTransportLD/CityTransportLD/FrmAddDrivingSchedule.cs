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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CityTransportLD
{
    public partial class FrmAddDrivingSchedule : Form
    {
        Station SelectedStation = null;
        DrivingLine SelectedDrivingLine = null;
        public FrmAddDrivingSchedule()
        {
            InitializeComponent();
        }

        private void FrmAddDrivingSchedule_Load(object sender, EventArgs e)
        {
            FillListBoxDrivingLines();
            FillListBoxStations();
        }

        private void FillListBoxDrivingLines()
        {
            lbDrivingLines.Items.Clear();
            foreach (var dl in DrivingLineRepository.GetDrivingLines())
            {
                lbDrivingLines.Items.Add(dl.Id + " " + dl.Name);
            }
        }

        private void FillListBoxStations()
        {
            lbStations.Items.Clear();
            foreach (var s in StationRepository.GetStations())
            {
                lbStations.Items.Add(s.Adress + " " + s.Description);
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

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            lbStations.Items.Clear();
            foreach (var s in StationRepository.GetStations())
            {
                if (s.ToString().Contains(txtSearch2.Text))
                {
                    lbStations.Items.Add(s.Adress + " " + s.Description);
                }
            }
        }

        private void lbDrivingLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDrivingLine = lbDrivingLines.SelectedItem as DrivingLine;
        }

        private void lbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStation = lbStations.SelectedItem as Station;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbTimeMoney.Items.Add(dtpTime.Value.ToShortTimeString() + " | " + txtMoney.Text + "€");
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                lbTimeMoney.Items.Remove(lbTimeMoney.SelectedItem);
            } catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
