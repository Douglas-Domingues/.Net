using Models;
using System.Globalization; //System.Globalization usado para alterar a região padrão aplicada ao sistema, alterando formatações.

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //Definição de qual será a região aplicada em toda a solução.

Pessoa p1 = new Pessoa(nome: "Douglas", sobrenome: "Domingues", datainc: DateTime.Now);
Pessoa p2 = new Pessoa(nome: "Isabela", sobrenome: "Domingues", datainc: DateTime.Now);
Pessoa p3 = new Pessoa(nome: "Isadora", sobrenome: "Braga", datainc: DateTime.Now);

Curso c1 = new Curso(nome: "Curso de Canto", valor: 1299.99M);
c1.Alunos = new List<Pessoa>();

c1.AdicionaAluno(p1);
c1.AdicionaAluno(p2);
c1.AdicionaAluno(p3);

Console.WriteLine($"O Curso {c1.Nome} possui {c1.ContagemAlunos()} Alunos");
c1.ListaAlunos();