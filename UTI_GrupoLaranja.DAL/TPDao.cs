using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.Entities;


namespace UTI_GrupoLaranja.DAL
{
    public class TPDao
    {
        public List<Temp_press> getRandonTP()
        {
            try
            {
                

                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM dbo.temp_press";
                Conexao.conectar();

                var reader = command.ExecuteReader();

                var tp = new List<Temp_press>();

                while (reader.Read())
                {
                    var pac = new Temp_press();

                    pac.id = Convert.ToInt32(reader["id"]);
                    pac.temperatura = Convert.ToDouble(reader["temperatura"]);
                    pac.pressao1 = Convert.ToInt32(reader["pressao1"]);
                    pac.pressao2 = Convert.ToInt32(reader["pressao2"]);
                    tp.Add(pac);
                }
                return tp;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.desconectar();
            }
        }

    }
}
