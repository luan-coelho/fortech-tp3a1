using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Repository
{
    public class EnderecoDao : Dao
    {
        private readonly SqlCommand _cmd = new SqlCommand();

        public Endereco BuscarPeloId(int id)
        {
            _cmd.Connection = Conectar();
            _cmd.CommandText = "SELECT * FROM Endereco WHERE id = @id";
            _cmd.Parameters.AddWithValue("@id", id);

            Endereco endereco = null;

            using (var reader = _cmd.ExecuteReader())
            {
                if (reader.Read() && reader.HasRows)
                {
                    endereco = new Endereco();
                    if (!(reader[0] is DBNull))
                    {
                        endereco.id = (int)reader[0];
                    }

                    if (!(reader[1] is DBNull))
                    {
                        endereco.cep = reader[1] as string;
                    }

                    if (!(reader[2] is DBNull))
                    {
                        endereco.rua = (string)reader[2];
                    }

                    if (!(reader[3] is DBNull))
                    {
                        endereco.numero = (string)reader[3];
                    }

                    if (!(reader[4] is DBNull))
                    {
                        endereco.bairro = (string)reader[4];
                    }

                    if (!(reader[5] is DBNull))
                    {
                        endereco.complemento = (string)reader[5];
                    }

                    if (!(reader[6] is DBNull))
                    {
                        endereco.cidade = (string)reader[6];
                    }

                    if (!(reader[7] is DBNull))
                    {
                        endereco.estado = (string)reader[7];
                    }
                }
            }

            Conn.Close();
            return endereco;
        }

        public List<Endereco> BuscarPeloIdUsuario(int id)
        {
            _cmd.Connection = Conectar();
            _cmd.CommandText = "SELECT * FROM Endereco WHERE Usuario_Id = @id";
            _cmd.Parameters.AddWithValue("@id", id);

            var enderecos = new List<Endereco>();

            using (var reader = _cmd.ExecuteReader())
            {
                while (reader.HasRows && reader.Read())
                {
                    var endereco = new Endereco();
                    if (!(reader[0] is DBNull))
                    {
                        endereco.id = (int)reader[0];
                    }

                    if (!(reader[1] is DBNull))
                    {
                        endereco.cep = reader[1] as string;
                    }

                    if (!(reader[2] is DBNull))
                    {
                        endereco.rua = (string)reader[2];
                    }

                    if (!(reader[3] is DBNull))
                    {
                        endereco.numero = (string)reader[3];
                    }

                    if (!(reader[4] is DBNull))
                    {
                        endereco.bairro = (string)reader[4];
                    }

                    if (!(reader[5] is DBNull))
                    {
                        endereco.complemento = (string)reader[5];
                    }

                    if (!(reader[6] is DBNull))
                    {
                        endereco.cidade = (string)reader[6];
                    }

                    if (!(reader[7] is DBNull))
                    {
                        endereco.estado = (string)reader[7];
                    }

                    enderecos.Add(endereco);
                }
            }

            Conn.Close();
            return enderecos;
        }
    }
}