using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio4
{
    internal class Aluno : Pessoa
    {
        //atributes
        List<Nota> Notas { get; set; } = new();

        //constructor
        public Aluno(string nome, string cpf, List<Nota> notas) : base(nome, cpf)
        {
            this.Notas = notas;
        }


        //methods
        public void AdicionarNota(Nota nota)
        {
            Notas.Add(nota);
        }

        public void MostrarNotas()
        {
            Console.Write($"Notas de {Nome}: ");
            foreach (Nota nota in Notas)
            {
                Console.Write($"{nota}  /  ");
            }
            Console.WriteLine();
        }

        public float obterMedia()
        {
            float Media = 0f;
            int QntNotas = 0;
            foreach (Nota nota in Notas)
            {
                Media += (float)nota.Valor;
                QntNotas++;
            }
            Media = Media / (float)QntNotas;

            Console.WriteLine($"Média de {Nome}: {Media}");
            return Media;
        }
    }
}
