﻿using System;
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
        public FrmVehicles()
        {
            InitializeComponent();
            dgvVehicles.DataSource = ""
        }

        private void FrmVehicles_Load(object sender, EventArgs e)
        {
            
        }
    }
}
