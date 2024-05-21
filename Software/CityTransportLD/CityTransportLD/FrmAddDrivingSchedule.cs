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
        string SelectedStation = null;
        int SelectedStationId;
        string SelectedDrivingLine = null;
        int SelectedDrivingLineId;
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
                lbStations.Items.Add(s.Id + ". " +s.Adress + " " + s.Description);
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
            SelectedDrivingLine = lbDrivingLines.SelectedItem.ToString();
            SelectedDrivingLineId = int.Parse(SelectedDrivingLine.Split(' ')[0]);
        }

        private void lbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStation = lbStations.SelectedItem.ToString();
            SelectedStationId = int.Parse(SelectedStation.Split('.')[0]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbTimeMoney.Items.Add(dtpTime.Value.ToShortTimeString() + "|" + txtMoney.Text + "€");
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
            foreach (var item in lbTimeMoney.Items)
            {
                int maxIdTermina;
                string timeString = item.ToString().Split('|')[0];
                string moneyString = item.ToString().Split('|')[1];
                float money = float.Parse(moneyString.Substring(0, moneyString.Length - 1));
                try
                {
                    maxIdTermina = DrivingScheduleRepository.GetMaxIdTermin(SelectedStationId, SelectedDrivingLineId);
                } catch
                {
                    maxIdTermina = 0;
                }
                
                int newIdTermina = maxIdTermina + 1;

                DrivingScheduleRepository.InsertDrivingSchedule(SelectedDrivingLineId, SelectedStationId, money, timeString, newIdTermina);
            }
            Close();
        }
    }
}
