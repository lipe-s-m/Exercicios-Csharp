using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class ContaCorrente : ContaBancaria
    {
        //atributes
        private float TaxaJuros { get; set; }
        private double LimiteSaque {  get; set; }
        private double TaxaServico { get; set; }

        //constructor
        public ContaCorrente(int numero, double saldo, string dataAbertura) : base(numero, saldo, dataAbertura) 
        {
            TaxaJuros = 0.07f;
            LimiteSaque = 200;
            TaxaServico = 50;
        }


        //methods

        public void sacar(double valor)
        {
            if(valor <= Saldo + LimiteSaque)
            {
                Saldo -= valor;
                Console.WriteLine($"Saldo após saque: {Saldo}");
                if(Saldo < 0)
                {
                    SaldoDevedor = Saldo;
                    Credito -= SaldoDevedor;
                }
            }
        }

        public override void aplicarRendimentos()
        {
            Saldo = Saldo + ((TaxaJuros * SaldoDevedor) + TaxaServico);
            Console.WriteLine($"Saldo após aplicar rendimento: {Saldo}");
        }
    }
}
