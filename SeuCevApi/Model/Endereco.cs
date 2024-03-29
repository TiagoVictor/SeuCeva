﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SeuCevApi.Model
{
    public class Endereco : Base
    {
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }

        [ForeignKey(nameof(Cliente))]
        public long IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
