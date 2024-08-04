namespace Exercicio2
{
    public class Item
    {
        //atributos
        private string nome;
        private int quantidade;
        private double precoUnitario;

        //props
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }


        //constructor
        public Item(string nome, int quantidade, double precoUnitario)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}