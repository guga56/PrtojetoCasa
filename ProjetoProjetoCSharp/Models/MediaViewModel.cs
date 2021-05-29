using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProjetoCSharp.Models
{
    public class MediaViewModel
    {
        public int IdMedia { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public ClienteViewModel ClienteViewModel { get; set; }
    }
}