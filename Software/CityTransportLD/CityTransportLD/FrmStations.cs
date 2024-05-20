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
    public partial class FrmStations : Form
    {
        Employee CurrentEmployee;
        public FrmStations(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
        }
    }
}
