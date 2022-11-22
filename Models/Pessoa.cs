namespace Models
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome, DateTime datainc) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataInc = datainc;
        }

        private string _nome;
        private int _idade;

        public DateTime DataInc { get; set; }

        public string Nome
        {
            get => _nome.ToUpper();

            set {
                if (value == "")
                {
                    Console.WriteLine("Nome não pode ser vazio!"); 
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public int Idade
        {
            get => _idade;

            set { 
                if (value < 0)
                {
                    throw new ArgumentException("Idade Inválida"); ;
                }
                else
                {
                    _idade = value; 
                }
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => (Nome + " " + Sobrenome).ToUpper();


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} - Idade: {Idade}");
        }
    }
}