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
    public partial class FrmLogin : Form
    {
        Employee CurrentEmployee = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CurrentEmployee = EmployeeRepository.GetEmployee(txtUsername.Text);
            if (CurrentEmployee != null && CurrentEmployee.Password == txtPassword.Text)
            {
                FrmEmployeeView frmEmployeeView = new FrmEmployeeView(CurrentEmployee);
                frmEmployeeView.Show();
                Close();
            } else
            {
                MessageBox.Show("Netočni podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
