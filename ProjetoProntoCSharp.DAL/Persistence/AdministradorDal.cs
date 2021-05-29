using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class AdministradorDal : DAL
    {
        public void Create(Administrador administrador)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("insert into projetopronto_db.dbo.tb_Administrador values(@b1, @b2)", Conn);
                Cmd.Parameters.AddWithValue("@b1", administrador.NomeAdm);
                Cmd.Parameters.AddWithValue("@b1", administrador.EmailAdm);
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
