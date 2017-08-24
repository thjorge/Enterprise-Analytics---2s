using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Pet
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public bool Castrado { get; set; }
        [Display (Name = "Descrição")]
        public string Descricao { get; set; }
        [Display (Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display (Name = "Espécie")]
        public string Especie { get; set; }
    }
}