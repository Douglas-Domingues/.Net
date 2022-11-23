using Models;
using System.Collections;
using System.Globalization; //System.Globalization usado para alterar a região padrão aplicada ao sistema, alterando formatações.
using System.Xml.Linq;
// --------------------- Tuplas permitem criar uma variável com vários dados de tipos diferentes, semelhante a um objeto, mas sua declaração é mais simples.

  (int, string, string) exemplotupla = (1, "Douglas", "Domingues");

  Console.WriteLine(exemplotupla);
 


// --------------------- Dictionary permite definir uma chave e valor vinculado à chave
/*
Dictionary<int, string> lojas = new Dictionary<int, string>();

lojas.Add(20736132, "Neacir Assunção");
lojas.Add(20736151, "Bruno dos Santos rosa");

foreach (var item in lojas)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}
lojas[20736151] = "Douglas Domingues"; //Para manipular ou usar os valores, a lógica é igual a um array
Console.WriteLine("--------");
Console.WriteLine(lojas[20736151]);

lojas.Remove(20736132);

foreach (var item in lojas)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}
*/

// --------------------- Pilhas trabalham sequencialmente, mas o último elemento declarado é o primeiro a sair. 'LIFO' (last in first out)
/*
Stack<int> pilha = new Stack<int>();
pilha.Push(8);
pilha.Push(23);
pilha.Push(14);
pilha.Push(7);
foreach (int elemento in pilha)
{
    Console.WriteLine(elemento);
}

pilha.Pop();
pilha.Push(pilha.Pop());
Console.WriteLine("\n");
foreach (int elemento in pilha)
{
    Console.WriteLine(elemento);
}

Console.WriteLine($"\nRemovendo o elemento nº {pilha.Pop()}");
foreach (int elemento in pilha)
{
    Console.WriteLine(elemento);
}
*/

// --------------------- Filas possuem uma lógica sequencial, sempre trabalhando com os elementos na ordem que foram declarados. famoso 'FIFO' (first in first out)
/*
Queue<int> fila = new Queue<int>(); // declaração

fila.Enqueue(1); //insere valor na fila
fila.Enqueue(8);
fila.Enqueue(6);
fila.Enqueue(4);

foreach (int valor in fila)
{
    Console.WriteLine(valor);
}

fila.Dequeue(); //Remove o primeiro valor da fila.
fila.Enqueue(fila.Dequeue()); //joga o primeiro valor da fila para última posição.

foreach (int valor2 in fila)
{
    Console.WriteLine(valor2);
}
*/

// --------------------- Usando as propriedades, métodos e construtores
/*
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
*/