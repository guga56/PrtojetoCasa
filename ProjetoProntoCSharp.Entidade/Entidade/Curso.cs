using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.Entidade.Entidade
{
    public class Curso
    {
        public int IdCurso { get; set; }

        public string NomeCurso { get; set; }

        public string Instituicao { get; set; }

        public Login Login { get; set; }

        public Cliente Cliente { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
