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
    public class DrivingLineRepository
    {
        public static DrivingLine GetDrivingLine(string id)
        {
            string sql = $"SELECT * FROM Linija WHERE Id = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            DrivingLine drivingLine = null;
            if (reader.HasRows)
            {
                reader.Read();
                drivingLine = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return drivingLine;
        }

        public static List<DrivingLine> GetDrivingLines()
        {
            List<DrivingLine> drivingLines = new List<DrivingLine>();
            string sql = "SELECT * FROM Linija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                DrivingLine drivingLine = CreateObject(reader);
                drivingLines.Add(drivingLine);
            }
            reader.Close();
            DB.CloseConnection();
            return drivingLines;

        }

        public static void InsertDrivingLine(int idVehicle, string name)
        {
            string sql = $"INSERT INTO Linija (IdVozila, Naziv) VALUES ('{idVehicle}', '{name}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static DrivingLine CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            int idVehicle = int.Parse(reader["IdVozila"].ToString());
            string name = reader["Naziv"].ToString();


            var drivingLine = new DrivingLine
            {
                Id = id,
                IdVehicle = idVehicle,
                Name = name
            };
            return drivingLine;
        }
    }
}
