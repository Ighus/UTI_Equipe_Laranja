using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.Entities;
using System.Data.SqlClient;

namespace UTI_GrupoLaranja.DAL
{
    public class EnderecoDao
    {
        public int inserirEndereco(Paciente pac)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = @"INSERT INTO[dbo].[ende]
                                         ([cep]
                                         ,[rua]
                                         ,[cidade]
                                         ,[uf]
                                         ,[casa]
                                         ,[idPaciente]
                                         ,[bairro])
                                        VALUES
                                          (@CEP,
                                           @RUA,
                                           @CIDADE,                                           
                                           @UF,
                                           @CASA,
                                           @IDPACIENTE,
                                           @BAIRRO)";

                command.Parameters.AddWithValue("@CEP", pac.endereco.cep);
                command.Parameters.AddWithValue("@RUA", pac.endereco.rua);
                command.Parameters.AddWithValue("@BAIRRO", pac.endereco.bairro);
                command.Parameters.AddWithValue("@CIDADE", pac.endereco.cidade);
                command.Parameters.AddWithValue("@UF", pac.endereco.uf);
                command.Parameters.AddWithValue("@CASA", pac.endereco.casa);
                command.Parameters.AddWithValue("@IDPACIENTE", pac.endereco.idPaciente);



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


        


    }
}
