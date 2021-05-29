using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class ClienteDal : DAL
    {
        public void Create(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("insert into projetopronto_db.dbo.tb_Cliente values(@c1, @c2, c3, c4)", Conn);
                Cmd.Parameters.AddWithValue("c1", cliente.NomeCliente);
                Cmd.Parameters.AddWithValue("c2", cliente.EmailCliente);
                Cmd.Parameters.AddWithValue("c3", cliente.SexoCliente);
                Cmd.Parameters.AddWithValue("c4", cliente.Disciplina.NomeDisc);
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
