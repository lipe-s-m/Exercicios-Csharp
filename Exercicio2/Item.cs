namespace Exercicio2
{
    public class Item
    {
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

        //metods
        public override string ToString()
        {
            return "-------------------------------\n" +
                $"Nome: {Nome}; \nQuantidade: {Quantidade}; \nPreço Unitário: {PrecoUnitario}\n" +
                "-------------------------------\n";
        }
    }
}