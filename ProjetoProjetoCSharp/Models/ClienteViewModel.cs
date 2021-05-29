using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProjetoCSharp.Models
{
    public class ClienteViewModel
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string SexoCliente { get; set; }

        public EnderecoViewModel EnderecoViewModel { get; set; }

        public CursoViewModel CursoViewModel { get; set; }

        public DisciplinaViewModel DisciplinaViewModel { get; set; }

        public LoginModelView LoginModelView { get; set; }
        
    }
}