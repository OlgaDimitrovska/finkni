using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINKNIAna_Data
{
    public static class AppDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-OVICMOB; Initial Catalog=FINKNI; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
