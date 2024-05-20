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
    public partial class FrmAddStation : Form
    {
        public FrmAddStation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StationRepository.InsertStation(txtAdress.Text, txtDescription.Text);
                Close();
            } catch
            {
                MessageBox.Show("Neuspješno dodavanje!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
