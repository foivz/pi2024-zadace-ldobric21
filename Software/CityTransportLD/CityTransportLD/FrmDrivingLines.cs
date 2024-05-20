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
    public partial class FrmDrivingLines : Form
    {
        Employee CurrentEmployee;
        public FrmDrivingLines(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
        }
    }
}
