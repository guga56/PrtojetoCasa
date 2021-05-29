using ProjetoProntoCSharp.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.DAL.Persistence
{
    public class DisciplinaDal : DAL
    {
        public List<Disciplina> ListarDisciplina()
        {
            AbrirConexao();

            List<Disciplina> listaDisciplina = new List<Disciplina>();

            Cmd = new SqlCommand("select * from projetopronto_db.dbo.tb_Disciplina", Conn);

            Dr = Cmd.ExecuteReader();

            while(Dr.Read())
            {
                Disciplina disciplina = new Disciplina();

                disciplina.IdDisciplina = Convert.ToInt16(Dr["IdDisciplina"]);
                disciplina.NomeDisc = Convert.ToString(Dr["NomeDisc"]);

                listaDisciplina.Add(disciplina);
            }

            FecharConexao();

            return listaDisciplina;
        }
    }
}
