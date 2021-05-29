using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProjetoCSharp.Models
{
    public class CursoViewModel
    {
        public int IdCurso { get; set; }

        public string NomeCurso { get; set; }

        public string Instituicao { get; set; }

        public LoginModelView LoginModelView { get; set; }

        public ClienteViewModel ClienteViewModel { get; set; }

        public DisciplinaViewModel DisciplinaViewModel { get; set; }
    }
}