﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.Entities;

namespace UTI_GrupoLaranja.DAL
{
    public class HistoricoDao
    {
        public int countRegistro(int id)
        {

            try
            {
                Conexao.conectar();

                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "SELECT count(*) FROM dbo.historico WHERE idPaciente = @ID";

                command.Parameters.AddWithValue("@ID", id);

                int contador = 0;
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    contador = reader.GetInt32(0);
                }



                return contador;

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


        public int inserirHistorico(Historico his)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = @"INSERT INTO[dbo].[historico]
                                         ([temperatura]
                                         ,[sistolica]
                                         ,[diastolica]
                                         ,[idPaciente]
                                         ,[data])
                                        VALUES
                                          (@TEMPERATURA,                                           
                                           @SISTOLICA,
                                           @DIASTOLICA,
                                           @IDPACIENTE,
                                           @DATA)";

                command.Parameters.AddWithValue("@TEMPERATURA", his.temperatura);
                command.Parameters.AddWithValue("@SISTOLICA", his.sistolica);
                command.Parameters.AddWithValue("@DIASTOLICA", his.diastolica);
                command.Parameters.AddWithValue("@IDPACIENTE", his.idPaciente);
                command.Parameters.AddWithValue("@DATA", DateTime.Now);



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
