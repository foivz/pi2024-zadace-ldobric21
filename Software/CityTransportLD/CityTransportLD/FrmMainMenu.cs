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
    public partial class FrmMainMenu : Form
    {

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            var result = frmLogin.ShowDialog();
           
        }

        private void btnDrivingSchedule_Click(object sender, EventArgs e)
        {
            FrmDrivingSchedule frmDrivingSchedule = new FrmDrivingSchedule(null);
            frmDrivingSchedule.ShowDialog();
        }
    }
}
