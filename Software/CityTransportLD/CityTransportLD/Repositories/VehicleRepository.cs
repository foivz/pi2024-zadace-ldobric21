using CityTransportLD.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityTransportLD.Repositories
{
    public class VehicleRepository
    {
        public static Vehicle GetVehicle(string registration)
        {
            string sql = $"SELECT * FROM Vozilo WHERE Registracija = '{registration}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Vehicle vehicle = null;
            if (reader.HasRows)
            {
                reader.Read();
                vehicle = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vehicle;
        }

        public static List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "SELECT * FROM Vozilo";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Vehicle vehicle = CreateObject(reader);
                vehicles.Add(vehicle);
            }
            reader.Close();
            DB.CloseConnection();
            return vehicles;

        }

        public static void InsertVehicle(string registration, int capacity, string serviceDate, int id)
        {
            string sql = $"INSERT INTO Vozilo (Registracija, Kapacitet, Datum_servisa, IdZaposlenika) VALUES ('{registration}', '{capacity}', '{serviceDate}', '{id}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteVehicle(int id)
        {
            if (id == -1)
            {
                MessageBox.Show("Treba označiti vozilo!");
                return;
            }
            string sql = $"DELETE FROM Vozilo WHERE Id = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void EditVehicle(int id, string registration, string capacity, string serviceDate, int employeeId)
        {
            string sql = $"UPDATE Vozilo SET Registracija = '{registration}', Kapacitet = '{capacity}', Datum_servisa = '{serviceDate}', IdZaposlenika = '{employeeId}' WHERE Id = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Vehicle CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string registration = reader["Registracija"].ToString();
            int capacity = int.Parse(reader["Kapacitet"].ToString());
            DateTime dateOfService = DateTime.Parse(reader["Datum_servisa"].ToString());             
            int idEmployee = int.Parse(reader["IdZaposlenika"].ToString());

            var vehicle = new Vehicle
            {
                Id = id,
                Registration = registration,
                Capacity = capacity,
                DateOfService = dateOfService,
                IdEmployee = idEmployee
            };
            return vehicle;
        }
    }
}
