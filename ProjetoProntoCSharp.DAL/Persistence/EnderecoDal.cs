using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class EnderecoDal : DAL
    {
        public void Create(Endereco endereco)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("insert into projetopronto_db.dbo.tb_Endereco values(@a1, @a2, @a3, @a4, @a5)", Conn);
                Cmd.Parameters.AddWithValue("@a1", endereco.Logradouro);
                Cmd.Parameters.AddWithValue("@a2", endereco.Complemento);
                Cmd.Parameters.AddWithValue("@a3", endereco.Bairro);
                Cmd.Parameters.AddWithValue("@a4", endereco.Cidade);
                Cmd.Parameters.AddWithValue("@a5", endereco.Uf);
                Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
