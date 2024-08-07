using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal abstract class Conta
    {
        //atributes
        int Numero { get; set; }
        protected double Saldo;
        protected double SaldoDevedor;
        string DataAbertura { get; set; }

        //constructor
        public Conta(int numero, double saldo, string dataAbertura)
        {
            Numero = numero;
            Saldo = saldo;
            DataAbertura = dataAbertura;
        }


        //methods
        public double obterSaldo()
        {
            return this.Saldo;
        }



        public override string ToString()
        {
            return $"Id: {Numero}  -  Saldo: R$ {Saldo}  -  Abertura: {DataAbertura}";
        }

    }
}
