

namespace Exercicio1
{
    class Pessoa
    {
        private string nome;
        private string nomePai;
        private string nomeMae;
        private int diaNasc;
        private int mesNasc;
        private int anoNasc;
        private float altura;
        private float peso;
        private Nacionalidade nacionalidade;
        private Sexo sexo;
        private EstadoCivil estadoCivil;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value == "felipe")
                {

                    Console.WriteLine("Q nome obnito");
                    this.nome = value;
                }
            }
        }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int DiaNasc { get; set; }
        public int MesNasc { get; set; }
        public int AnoNasc { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public Nacionalidade Nacionalidade { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }



        public Pessoa(string nome, string nomePai, string nomeMae, int diaNasc, int mesNasc, int anoNasc, float altura, float peso, Nacionalidade nacionalidade, Sexo sexo, EstadoCivil estadoCivil)
        {
            Nome = nome;
            NomePai = nomePai;
            NomeMae = nomeMae;
            DiaNasc = diaNasc;
            MesNasc = mesNasc;
            AnoNasc = anoNasc;
            Altura = altura;
            Peso = peso;
            Nacionalidade = nacionalidade;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

    }

}
