
namespace Exercicio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaPoupanca joao = new(1, 200, "hoje", "08/07");
            ContaCorrente jose = new(2, 600, "04/12");
            ContaCartaoCredito maria = new(3, 100, "01/01");

            joao.creditar(100);
            jose.debitar(20);

            Console.WriteLine($"-----------------------------\n{joao}\n{jose}\n{maria}\n-----------------------------\n");

            joao.aplicarRendimentos();
            jose.aplicarRendimentos();
            maria.cobrarJuros();

            Console.WriteLine($"-----------------------------\n{joao}\n{jose}\n{maria}\n-----------------------------\n");

            maria.pagar();

            Console.WriteLine($"-----------------------------\n{joao}\n{jose}\n{maria}\n-----------------------------\n");



            Console.ReadLine();
        }
    }
}