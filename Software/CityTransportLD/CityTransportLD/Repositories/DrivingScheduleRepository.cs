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
    public class DrivingScheduleRepository
    {
        public static DrivingSchedule GetDrivingSchedule(string id)
        {
            string sql = $"SELECT * FROM VozniRed WHERE Id = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            DrivingSchedule drivingSchedule = null;
            if (reader.HasRows)
            {
                reader.Read();
                drivingSchedule = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return drivingSchedule;
        }

        public static int GetMaxIdTermin(int idStation, int idDrivingLine)
        {
            int maxIdTermin = 0;
            string sql = $"SELECT COALESCE(MAX(IdTermina), 0) AS MaxIdTermina FROM VozniRed WHERE IdLinije = {idDrivingLine} AND IdStanice = {idStation}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows)
            {
                reader.Read();
                maxIdTermin = reader.GetInt32(reader.GetOrdinal("MaxIdTermina"));
                reader.Close();
            }

            DB.CloseConnection();
            return maxIdTermin;
        }


        public static List<DrivingSchedule> GetDrivingSchedules()
        {
            List<DrivingSchedule> drivingSchedules = new List<DrivingSchedule>();
            string sql = "SELECT * FROM VozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                DrivingSchedule drivingSchedule = CreateObject(reader);
                drivingSchedules.Add(drivingSchedule);
            }
            reader.Close();
            DB.CloseConnection();
            return drivingSchedules;

        }

        public static List<DrivingSchedule> GetDrivingSchedulesByDrivingLine(int id)
        {
            List<DrivingSchedule> drivingSchedules = new List<DrivingSchedule>();
            string sql = $"SELECT * FROM VozniRed WHERE IdLinije = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                DrivingSchedule drivingSchedule = CreateObject(reader);
                drivingSchedules.Add(drivingSchedule);
            }
            reader.Close();
            DB.CloseConnection();
            return drivingSchedules;

        }

        public static List<DrivingSchedule> GetDrivingSchedulesByDrivingLineByStation(int idDrivingLine, int idStation)
        {
            List<DrivingSchedule> drivingSchedules = new List<DrivingSchedule>();
            string sql = $"SELECT * FROM VozniRed WHERE IdLinije = '{idDrivingLine}' AND IdStanice = '{idStation}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                DrivingSchedule drivingSchedule = CreateObject(reader);
                drivingSchedules.Add(drivingSchedule);
            }
            reader.Close();
            DB.CloseConnection();
            return drivingSchedules;

        }

        public static void InsertDrivingSchedule(int idDrivingLine, int idStation, float price, string timeOfDeparture, int idTermin)
        {
            string sql = $"INSERT INTO VozniRed (IdLinije, IdStanice, Cijena_karte, Vrijeme_polaska, IdTermina) VALUES ('{idDrivingLine}', '{idStation}', '{price}', '{timeOfDeparture}','{idTermin}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteDrivingSchedule(int idDrivingLine, int idStation)
        {
            if (idDrivingLine == -1 || idStation == -1)
            {
                MessageBox.Show("Treba označiti vozni red!");
                return;
            }
            string sql = $"DELETE FROM VozniRed WHERE IdLinije = {idDrivingLine} AND IdStanice = {idStation}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static DrivingSchedule CreateObject(SqlDataReader reader)
        {
            int idDrivingLine = int.Parse(reader["IdLinije"].ToString());
            int idStation = int.Parse(reader["IdStanice"].ToString());
            float price = float.Parse(reader["Cijena_karte"].ToString());
            DateTime timeOfDeparture = DateTime.Parse(reader["Vrijeme_polaska"].ToString());

            var drivingSchedule = new DrivingSchedule
            {
                IdDrivingLine = idDrivingLine,
                IdStation = idStation,
                Price = price,
                TimeOfDeparture = timeOfDeparture
            };
            return drivingSchedule;
        }
    }
}
