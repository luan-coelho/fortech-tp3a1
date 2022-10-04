using System.Data.SqlClient;

namespace Fortech_TP3A1.Repository
{
    public class Dao
    {
        protected readonly SqlConnection Conn = new SqlConnection();

        public Dao()
        {
            Conn.ConnectionString =
                "Data Source=ASPIRE;Initial Catalog=fortech;Persist Security Info=True;User ID=sa;Password=adsdsggfgfgds@dds";
        }

        public SqlConnection Conectar()
        {
            if (Conn.State == System.Data.ConnectionState.Closed)
            {
                Conn.Open();
            }

            return Conn;
        }
    }
}