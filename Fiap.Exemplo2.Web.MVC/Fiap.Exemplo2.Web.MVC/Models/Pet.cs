using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo2.Web.MVC.Models
{
    public class Pet
    {
        public int Codigo { get; set; }
        public string  Nome { get; set; }
        public bool Castrado { get; set; }
        public string Descricao { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}