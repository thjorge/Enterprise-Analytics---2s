using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
    }
}