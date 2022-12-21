using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades___Metodos___Construtores.Models
{
    public class Curso
    {
        public Curso() { }
        public Curso(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        internal List<Aluno> Alunos { get; set; }
        public decimal Valor { get; set; }

        internal void AdicionaAluno(Aluno aluno)
        {
            
            Alunos.Add(aluno);           
            
        }

        public int ContagemAlunos()
        {
            return Alunos.Count;
        }

        internal bool RemoveAluno(Aluno aluno)
        {
            return Alunos.Remove(aluno);
        }
        /// <summary>
        /// Retorna a listagem de alunos matriculados no curso e valor.
        /// </summary>
        public void ListaAlunos()
        {
            Console.WriteLine($"Alunos cadastrados no curso {Nome}:");

            for (int count = 0; count < Alunos.Count; count++)
            {
                Console.WriteLine($"Nº {count + 1} - {Alunos[count].NomeCompleto} - Matriculado em: {Alunos[count].DataInc}" +
                    $"\nDesconto Aplicado: {(Alunos[count].Desconto.HasValue ? Math.Round((decimal)(Valor * (Alunos[count].Desconto / 100)), 2).ToString("C") : "R$ 0,00")}\n");
            }
            //Usando o parâmetro "C" específica como "Currency" imprimindo a moeda da região, o número sequente representa o número de casas decimais.
            Console.WriteLine($"Valor total do curso: {Valor.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}\n"); //É possível especificar uma região diferente da definida no Program.cs
        }
    }
}
