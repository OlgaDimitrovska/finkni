using FINKNIAna_Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINKNI_Data
{
    public static class NalogDB
    {
        public static List<Nalog> GetNalozi()
        {
            List<Nalog> nlist = new List<Nalog>();
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand selectAllCommand = new SqlCommand();
            selectAllCommand.Connection = connection;
            selectAllCommand.CommandText = "DnevnikNaloziSelectAll";
            selectAllCommand.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                connection.Open();
                SqlDataReader reader = selectAllCommand.ExecuteReader();
                while(reader.Read())
                {
                    Nalog nalog = new Nalog();
                    nalog.BrojNaNalog = reader["BrojNaNalog"].ToString();
                    nalog.DatumNaNaNalog = Convert.ToDateTime(reader["DatumNaNalog"]);
                    nalog.SaldoDolzi = Convert.ToDecimal(reader["SaldoDolzi"]);
                    nalog.SaldoPobaruva = Convert.ToDecimal(reader["SaldoPobaruva"]);
                    nlist.Add(nalog);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return nlist;
        }


        public static Nalog GetNalog()
        {
            Nalog nalog = new Nalog();
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "";
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            selectCommand.Parameters.AddWithValue()
        }


    }
}
