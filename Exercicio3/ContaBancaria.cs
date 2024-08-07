using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal abstract class ContaBancaria : Conta
    {
        //atributes
        protected double Credito { get; set; }
        //constructor
        public ContaBancaria(int numero, double saldo, string dataAbertura) : base(numero, saldo, dataAbertura)
        {

        }

        //methods
        public void creditar(double valor)
        {
            Credito += valor;
        }
        public void debitar(double valor)
        {
            Saldo += valor;
        }

        public abstract void aplicarRendimentos();

    }
}
