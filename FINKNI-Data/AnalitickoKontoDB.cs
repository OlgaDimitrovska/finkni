using FINKNIAna_Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FINKNI_Data
{
    public static class AnalitickoKontoDB
    {

        public static List<AnalitickoKonto> GetAKonta()
        {
            List<AnalitickoKonto> aklist = new List<AnalitickoKonto>();
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand selectAllCommand = new SqlCommand();
            selectAllCommand.Connection = connection;
            selectAllCommand.CommandText = "AKontoSelectAll";
            selectAllCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                connection.Open();
                SqlDataReader reader = selectAllCommand.ExecuteReader();
                while(reader.Read())
                {
                    AnalitickoKonto akonto = new AnalitickoKonto();
                    akonto.SifraNaAKonto = reader["SifraNaKonto"].ToString();
                    akonto.NazivNaAKonto = reader["NazivNaKonto"].ToString();
                    aklist.Add(akonto);
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
            return aklist;
        }


        public static AnalitickoKonto GetAnalitickoKonto(long sifraNaAKonto)
        {
            AnalitickoKonto akonto = new AnalitickoKonto();
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "AKontoSelect";
            selectCommand.CommandType = CommandType.StoredProcedure;
            selectCommand.Parameters.AddWithValue("@SAK", sifraNaAKonto);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if(reader.Read())
                {
                    akonto.SifraNaAKonto = reader["SifraNaKonto"].ToString();
                    akonto.NazivNaAKonto = reader["NazivNaKonto"].ToString();
                }
                else
                {
                    akonto = null;
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
            return akonto;
        }

        public static int AddAnalitickoKonto(AnalitickoKonto akonto)
        {
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.CommandText = "AKontoInsert"; 
            insertCommand.Parameters.AddWithValue("@SAK", akonto.SifraNaAKonto);
            insertCommand.Parameters.AddWithValue("@NAK", akonto.NazivNaAKonto);
            try
            {
                connection.Open();
                int b=insertCommand.ExecuteNonQuery();
                if (b >= 0)
                    return 0;
                else
                    return 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateAnalitickoKonto(AnalitickoKonto akonto)
        {
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = connection;
            updateCommand.CommandType = CommandType.StoredProcedure;
            updateCommand.CommandText = "AKontoUpdate";
            updateCommand.Parameters.AddWithValue("@SAK",akonto.SifraNaAKonto);
            updateCommand.Parameters.AddWithValue("@NAK", akonto.NazivNaAKonto);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static bool DeleteAnalitickoKonto(AnalitickoKonto akonto)
        {
            SqlConnection connection = AppDB.GetConnection();
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = connection;
            deleteCommand.CommandType = CommandType.StoredProcedure;
            deleteCommand.CommandText = "AKontoDelete";
            deleteCommand.Parameters.AddWithValue("@SAK", akonto.SifraNaAKonto);
            //updateCommand.Parameters.AddWithValue("@NAK", akonto.NazivNaAKonto);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

    }
}
