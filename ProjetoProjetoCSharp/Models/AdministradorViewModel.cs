using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProjetoCSharp.Models
{
    public class AdministradorViewModel
    {
        public int IdAdm { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }

        public LoginModelView LoginModelView { get; set; }
    }
}