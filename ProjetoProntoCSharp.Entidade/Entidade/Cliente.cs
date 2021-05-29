using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.Entidade.Entidade
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string SexoCliente { get; set; }

        public Endereco Endereco { get; set; }

        public Curso Curso { get; set; }

        public Disciplina Disciplina { get; set; }

        public Login Login { get; set; }

        public Media Media { get; set; }
    }
}
