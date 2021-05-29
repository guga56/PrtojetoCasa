using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class CursoDal : DAL
    {
        public void Create(Curso curso)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("insert into projetopronto_db.dbo.tb_Curso values(@c1, @c2)", Conn);
                Cmd.Parameters.AddWithValue("@c1", curso.NomeCurso);
                Cmd.Parameters.AddWithValue("@c2", curso.Instituicao);
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
