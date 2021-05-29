using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProntoCSharp.Entidade.Entidade
{
    public class Media
    {
        public int IdMedia { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public Cliente Cliente { get; set; }
    }
}
