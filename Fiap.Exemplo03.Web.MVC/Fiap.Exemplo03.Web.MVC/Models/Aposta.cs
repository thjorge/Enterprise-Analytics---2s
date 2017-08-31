using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.Web.MVC.Models
{
    public class Aposta
    {
        public int Id { get; set; }        
        public decimal Valor { get; set; }
        public bool Dobadinha { get; set; }
        [Display(Name ="Data Aposta")]
        public DateTime DataAposta { get; set; }
    }
}