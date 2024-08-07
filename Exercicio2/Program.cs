using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Item> itens = new List<Item>();

            itens.Add(new Item("Fone", 3, 15));
            itens.Add(new Item("Motorola", 1, 899.99));

            Fatura fatura = new Fatura("Felipe", "184.607.982.23", itens);

            Console.WriteLine($"Fatura do {fatura.Nome} possui os itens: ");

            foreach (Item item in fatura.Itens)
            {
                Console.WriteLine(item);
            };


            fatura.AddItem(new Item("Violão", 7, 244.50));

            Console.WriteLine($"Adicionado o item {itens[2].Nome}");
            Console.WriteLine("Fatura atualizada: ");

            foreach (Item item in fatura.Itens)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine($"Removendo o item {itens[0].Nome}");
            fatura.RemoveItem(0);

            Console.WriteLine("Fatura atualizada: ");

            foreach (Item item in fatura.Itens)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine($"Preço total da fatura: {fatura.obterPreco()}");


            Console.ReadLine();

        }
    }
}
