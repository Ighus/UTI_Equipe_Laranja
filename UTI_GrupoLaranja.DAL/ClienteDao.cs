using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.Entities;
using System.Data.SqlClient;

namespace UTI_GrupoLaranja.DAL
{
    public class ClienteDao
    {
        public int inserirUsuario(Paciente pac)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = @"INSERT INTO[dbo].[paciente]
                                         ([nome]
                                         ,[idade]
                                         ,[sexo]
                                         ,[temperatura]
                                         ,[sistolica]
                                         ,[diastolica])
                                        VALUES
                                          (@NOME,
                                           @IDADE,
                                           @SEXO,
                                           @TEMPERATURA,                                           
                                           @SISTOLICA,
                                           @DIASTOLICA)";

                command.Parameters.AddWithValue("@NOME", pac.nome);
                command.Parameters.AddWithValue("@IDADE", pac.idade);
                command.Parameters.AddWithValue("@SEXO", pac.sexo);
                command.Parameters.AddWithValue("@SISTOLICA", pac.sistolica);
                command.Parameters.AddWithValue("@DIASTOLICA", pac.diastolica);
                command.Parameters.AddWithValue("@TEMPERATURA", pac.temperatura);



                Conexao.conectar();

                return command.ExecuteNonQuery();

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

        public object inserirEndereco(Paciente pac)
        {
            throw new NotImplementedException();
        }


        public int getLastId()
        {

            try
            {
                Conexao.conectar();

                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT max(id) FROM dbo.paciente";

                int id = 0;
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }

                
                
                return id;

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

        public Paciente getHistoricoPaciente(int id)
        {
            try
            {
                Conexao.conectar();

                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT * FROM dbo.paciente WHERE id = @ID";

                command.Parameters.AddWithValue("@ID", id);
             

                var reader = command.ExecuteReader();

                Paciente pac = null;

                while (reader.Read())
                {
                    pac = new Paciente();

                    pac.id = Convert.ToInt32(reader["id"]);
                    pac.nome = reader["nome"].ToString();
                    pac.temperatura = Convert.ToDouble(reader["temperatura"]);
                    pac.sistolica = Convert.ToInt32(reader["sistolica"]);
                    pac.diastolica = Convert.ToInt32(reader["diastolica"]);
                    
                }
                return pac;

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
