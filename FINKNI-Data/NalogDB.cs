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
        }

    }
}
