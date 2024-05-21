using CityTransportLD.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityTransportLD.Repositories
{
    public class StationRepository
    {
        public static Station GetStation(int id)
        {
            string sql = $"SELECT * FROM Stanica WHERE Id = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Station station = null;
            if (reader.HasRows)
            {
                reader.Read();
                station = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return station;
        }

        public static List<Station> GetStations()
        {
            List<Station> stations = new List<Station>();
            string sql = "SELECT * FROM Stanica";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Station station = CreateObject(reader);
                stations.Add(station);
            }
            reader.Close();
            DB.CloseConnection();
            return stations;

        }

        public static void InsertStation(string adress, string description)
        {
            string sql = $"INSERT INTO Stanica (Adresa, Dodatni_opis) VALUES ('{adress}', '{description}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Station CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string address = reader["Adresa"].ToString();
            string description = reader["Dodatni_opis"].ToString();


            var station = new Station
            {
                Id = id,
                Adress = address,
                Description = description
            };
            return station;
        }
    }
}
