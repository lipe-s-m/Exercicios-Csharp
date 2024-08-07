using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class ContaPoupanca : ContaBancaria
    {
        //atributes
        private string DataAniversario { get; set; }
        private float TaxaRendimento { get; set; }

        //constructor
        public ContaPoupanca(int numero, double saldo, string dataAbertura, string dataAniversario) : base(numero, saldo, dataAbertura)
        {
            DataAniversario = dataAniversario;
            TaxaRendimento = 0.1f;
        }

        //methods


        public override void aplicarRendimentos()
        {
            Saldo = Saldo + (Saldo * TaxaRendimento);
            Console.WriteLine($"Saldo após aplicar rendimento: {Saldo}");
        }


    }
}
