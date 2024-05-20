using CityTransportLD.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransportLD.Repositories
{
    public class VehicleRepository
    {
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

        private static Vehicle CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string registration = reader["Registracija"].ToString();
            int capacity = int.Parse(reader["Kapacitet"].ToString());
            string dateOfService = reader["Datum_servisa"].ToString();
            int idEmployee = int.Parse(reader["IdZaposlenik"].ToString());

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
