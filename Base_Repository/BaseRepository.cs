using HRSystem.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Base_Repository
{
    public class BaseRepository
    {
        private readonly string connectionString;

        protected BaseRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HRSystem"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            var result = new SqlConnection(connectionString);
            return result;
        }

        public int InsertEmployee(SqlCommand command, SqlConnection connection)
        {
            try
            {
                connection.Open();
                var result = (int)command.ExecuteNonQuery();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Employee> GetDepartmentEmployees(SqlCommand command, SqlConnection connection)
        {
            var list = new List<Employee>();
            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(reader[0]);
                    employee.EmployeeName = reader[1].ToString();
                    employee.Department_id = Convert.ToInt32(reader[2]);
                    employee.Role_id = Convert.ToInt32(reader[3]);

                    list.Add(employee);
                }

                return list;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
