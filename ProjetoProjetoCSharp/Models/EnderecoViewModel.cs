﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProjetoCSharp.Models
{
    public class EnderecoViewModel
    {
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public ClienteViewModel ClienteViewModel { get; set; }
    }
}