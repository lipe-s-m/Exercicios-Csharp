using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Fatura
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public List<Item> Itens { get; set; }

        //constructor
        public Fatura(string nome, string cpf, List<Item> itens)
        {
            Nome = nome;
            CPF = cpf;
            Itens = itens;
        }

        //metods
        public void AddItem(Item item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(int index)
        {
            Itens.Remove(Itens[index]);
        }

        public double obterPreco()
        {
            double preco = 0;
            foreach(Item item in Itens)
            {
                preco += item.PrecoUnitario * item.Quantidade;
            }
            return preco;
        }

    }


}
