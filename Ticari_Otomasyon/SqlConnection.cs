using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Ticari_Otomasyon
{
    class SqlConnectionClass
    {
        public SqlConnection baglanti()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(connectionString);
            baglan.Open();
            return baglan;
        }
    }
}
