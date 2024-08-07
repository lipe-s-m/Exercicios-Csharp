using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class ContaCartaoCredito : Conta
    {
        //constructor
        public ContaCartaoCredito(int numero, double saldo, string dataAbertura) : base(numero, saldo, dataAbertura)
        {
        }

        //methods

        public void pagar()
        {
            Saldo = 0;
            Console.WriteLine("Saldo zerado!");
        }

        public void cobrarJuros()
        {
            Saldo = Saldo * 1.05;
            Console.WriteLine($"Saldo após cobrar juros: {Saldo}");
        }

    }
}
