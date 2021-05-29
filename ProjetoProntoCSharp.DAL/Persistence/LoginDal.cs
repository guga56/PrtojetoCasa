using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class LoginDal : DAL
    {
        public void Create(Login login)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("insert into projetopronto_db.dbo.tb_Login values(@v1, @v2, @v3)", Conn);
                Cmd.Parameters.AddWithValue("@v1", login.Usuario);
                Cmd.Parameters.AddWithValue("@v2", login.Senha);
                Cmd.Parameters.AddWithValue("@v3", login.Perfil);
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
