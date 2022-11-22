using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Curso
    {
        public Curso(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public decimal Valor { get; set; }

        public void AdicionaAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);  
        }

        public int ContagemAlunos()
        {
            return Alunos.Count;
        }

        public bool RemoveAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListaAlunos()
        {
            Console.WriteLine($"Alunos cadastrados no curso {Nome}:");

            for (int count = 0; count < Alunos.Count; count++)
            {
                Console.WriteLine($"Nº {count + 1} - {Alunos[count].NomeCompleto} - Matriculado em: {Alunos[count].DataInc.ToString("dd-MM-yy")}");
            }
            //Usando o parâmetro "C" específica como "Currency" imprimindo a moeda da região, o número sequente representa o número de casas decimais.
            Console.WriteLine($"Valor total do curso:{Valor.ToString("C3", CultureInfo.CreateSpecificCulture("en-US"))}"); //É possível especificar uma região diferente da definida no Program.cs

        }
    }
}
