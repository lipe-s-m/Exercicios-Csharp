namespace Exercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Nota> NotasJoao = new()
            {
                new Nota(2f, "12/11"), new Nota(5.5f, "19/11")
            };

            List<Nota> NotasJose = new()
            {
                new Nota(7f, "15/11"), new Nota(8.9f, "24/11")
            };

            Aluno Joao = new("Joao", "121.242.545.77", NotasJoao);
            Aluno Jose = new("Jose", "000.111.222.33", NotasJose);

            Console.WriteLine($"{Jose} \n {Joao}");

            Jose.MostrarNotas();
            Jose.obterMedia();

            Joao.AdicionarNota(new Nota(9.9f, "25/11"));
            Joao.MostrarNotas();

            Joao.obterMedia();

            Console.ReadLine();
        }

    }


}