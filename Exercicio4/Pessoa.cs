using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Pessoa
    {
        //atributes
        protected string Nome { get; set; }
        protected string CPF { get; set; }

        public Pessoa(string nome, string cpf)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return $"---------------------\nNome: {Nome}  -  CPF: {CPF}\n---------------------\n";
        }

    }
}
