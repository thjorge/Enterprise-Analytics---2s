using Fiap.Banco.Model;
using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 546,
                Numero = 456,
                DateAbertura = DateTime.Now,
                Tipo = TipoConta.Comum,
                Saldo = 100000
            };
            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 987,
                Numero = 657,
                DateAbertura = DateTime.Now,
                Saldo = 5000,
                Taxa = 10
            };
            //Chamar o métodos...          
            cc.Depositar(500);            
            cc.Retirar(100000);
            Console.WriteLine("Retorno Investimento: " + cp.CalculaRetornoInvestimento());
            Console.WriteLine("Saldo: " + cc.Saldo);
            Console.ReadLine();//Parar a aplicação...
        }
    }
}
