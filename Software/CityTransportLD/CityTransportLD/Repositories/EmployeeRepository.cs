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
    public class EmployeeRepository
    {
        public static Employee GetEmployee(int id)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE Id = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Employee employee = null;
            if (reader.HasRows)
            {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return employee;
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM Zaposlenik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Employee employee = CreateObject(reader);
                employees.Add(employee);
            }
            reader.Close();
            DB.CloseConnection();
            return employees;

        }

        private static Employee CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Ime"].ToString();
            string surname = reader["Prezime"].ToString();
            string username = reader["Korisnicko_ime"].ToString();
            string password = reader["Lozinka"].ToString();

            var employee = new Employee
            {
                Id = id,
                Name = name,
                Surname = surname,
                Username = username,
                Password = password
            };
            return employee;
        }
    }
}
