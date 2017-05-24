using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UTI_GrupoLaranja.DAL
{
    public class Conexao
    {
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(connectionString);

        public static void conectar()
        {

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public static void desconectar()
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
