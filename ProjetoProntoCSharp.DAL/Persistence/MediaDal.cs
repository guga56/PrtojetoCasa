using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class MediaDal : DAL
    {
        public void Create(Media media)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("insert into projetopronto_db.dbo.tb_Media values(@v1, @v2)", Conn);
                Cmd.Parameters.AddWithValue("@v1", media.Nota1);
                Cmd.Parameters.AddWithValue("@v1", media.Nota2);
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
