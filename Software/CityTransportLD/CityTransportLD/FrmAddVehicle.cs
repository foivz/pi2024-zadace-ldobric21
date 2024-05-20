using CityTransportLD.Models;
using CityTransportLD.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityTransportLD
{
    public partial class FrmAddVehicle : Form
    {
        Employee CurrentEmployee;
        public FrmAddVehicle(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            if (VehicleRepository.GetVehicle(txtRegistration.Text) == null)
            {
                int capacity = int.Parse(txtCapacity.Text);
                if (capacity >= 30 && capacity <= 50)
                {
                    DateTime selectedDate = dtpService.Value.Date;

                    string formattedDate = dtpService.Value.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                    VehicleRepository.InsertVehicle(txtRegistration.Text, capacity,
                        formattedDate, CurrentEmployee.Id);
                    Close();
                } else
                {
                    MessageBox.Show("Kapacitet vozila smije biti od 30 do 50!", "Krivi kapacitet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Vozilo sa tom registracijom postoji!", "Duplikat vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            try
            {
                
            }catch (Exception ex)
            {
                MessageBox.Show($"Neuspješno dodavanje! Ponovo provjerite podatke. Greška: {ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
