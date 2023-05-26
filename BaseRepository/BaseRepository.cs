using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.BaseRepository
{
    class BaseRepository
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


    }
}
