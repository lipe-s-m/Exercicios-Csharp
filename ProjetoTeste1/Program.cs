using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Felipe", "Adriano", "Ioná", 16, 9, 2004, 1.60f, 47, Nacionalidade.BR, Sexo.MASCULINO, EstadoCivil.SOLTEIRO);

            pessoa1.Nome = "felipe";

            Console.WriteLine(pessoa1.Nacionalidade);

            Console.ReadLine();

        }

    }
}
