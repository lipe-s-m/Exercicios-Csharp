using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Nota
    {
        public float Valor {  get; private set; }
        public string Data {  get; private set; }

        public Nota(float valor,string data)
        {
            this.Valor = valor;
            this.Data = data;
        }

        public override string ToString()
        {
            return $"Nota: {Valor}  -  {Data}";
        }
    }
}
