using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;

namespace Propriedades___Metodos___Construtores.Models
{
    public abstract class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome, DateTime datainc, decimal Desconto)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataInc = datainc.ToString("dd/MM/yyyy HH:mm");
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;
        protected decimal ValorFinanciado;

        public string DataInc { get; set; }

        [JsonProperty("Nome_aluno")]
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
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

            set
            {
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

        public decimal? Desconto { get; set; }

        public string NomeCompleto => (Nome + " " + Sobrenome).ToUpper();

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá! meu nome é {NomeCompleto} e eu tenho {Idade} anos.");
        }

        public abstract void IncluiFinanciamento(decimal mensalidade);
    }
}
