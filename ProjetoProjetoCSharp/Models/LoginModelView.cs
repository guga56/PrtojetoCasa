using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProjetoCSharp.Models
{
    public class LoginModelView
    {
        public int IdLogin { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }
    }
}