using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class DAL
    {
        protected SqlConnection Conn;

        protected SqlCommand Cmd;

        protected SqlDataReader Dr;

        public void AbrirConexao()
        {
            Conn = new SqlConnection("Data Source=DESKTOP-GOE86IA\\SQLEXPRESS;Integrated Security=True");
            Conn.Open();
        }

        public void FecharConexao()
        {
            Conn.Close();
        }
    }
}
