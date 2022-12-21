using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades___Metodos___Construtores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, int idade, string turma)
        {
            Turma = turma;
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public Aluno(string nome, string sobrenome, DateTime datainc, decimal? desconto)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataInc = datainc.ToString("dd/MM/yyyy HH:mm");
            Desconto = desconto;
        }
        public Aluno() { }

        public string Turma;
        public decimal? Desconto { get; set; }

        //sobrescrita de método (polimorfismo em tempo de execução)
        public override void Apresentar()
        {
            Console.WriteLine($"Olá! meu nome é {NomeCompleto}, eu tenho {Idade} anos e pertenço à turma {Turma}");
        }
        // método abstrato obrigatório herdado de Pessoa (classe abstrata)
        public override void IncluiFinanciamento(decimal mensalidade)
        {
            ValorFinanciado += mensalidade;
        }

        public void GetSaldoFinanciado()
        {
            Console.WriteLine($"Atualmente possuo {ValorFinanciado} em financiamento.");
        }
    }
}
