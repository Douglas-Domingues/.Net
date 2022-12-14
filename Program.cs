using Propriedades___Metodos___Construtores.Models;
using System.Globalization; //System.Globalization usado para alterar a região padrão aplicada ao sistema, alterando formatações.
using Newtonsoft.Json;


public class Program
{
    private static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //Definição de qual será a região aplicada em toda a solução.

        // --------------------- Herança

        Aluno a1 = new Aluno(nome: "Fulano", sobrenome: "deTal", idade: 22, turma: "Turma 101");
        a1.Apresentar();
        a1.IncluiFinanciamento(250.00M);
        a1.GetSaldoFinanciado();

        // --------------------- Métodos de extensão (blowmind)
        /*
        bool verificaint = false;
        int divisor, multiplo;
        do
        {
            verificaint = false;
            Console.WriteLine($"Digite um inteiro para dividendo:");
            string entrada = Console.ReadLine();
            if (Int32.TryParse(entrada, out multiplo) == true)
            {
                verificaint = true;
            }
            else Console.WriteLine("Valor inválido");
        } while (verificaint == false);

        do
        {
            Console.WriteLine("Digite um inteiro divisor:");
            string entrada = Console.ReadLine();
            if (Int32.TryParse(entrada, out divisor) == true)
            {
                verificaint = true;
            }
            else Console.WriteLine("Valor inválido");
        } while (verificaint == false);

        Console.WriteLine($"O número {multiplo} {(multiplo.VerifyMultiple(divisor) ? "é multiplo de" : "não é múltiplo de")} {divisor}");

        Console.WriteLine("Digite uma tecla para continuar.");

        Console.Read();
        */

        // --------------------- Variáveis Dynamic
        /*
        dynamic dinamica = 4;/*
        Console.WriteLine($"Valor: {dinamica} - Tipo: {dinamica.GetType()}");
        dinamica = "texto";
        Console.WriteLine($"Valor: {dinamica} - Tipo: {dinamica.GetType()}");
        dinamica = true;
        Console.WriteLine($"Valor: {dinamica} - Tipo: {dinamica.GetType()}");

        dinamica = new List<Curso>(JsonConvert.DeserializeObject<List<Curso>>(File.ReadAllText("Arquivos/curso.json"))); //Os operadores <> indicam que se trata de uma classe genérica onde deve-se passar o tipo de dados dentro do <>
        Console.WriteLine($"Valor: {dinamica} - Tipo: {dinamica.GetType()}");

        foreach (var curso in dinamica)
        {
            curso.ListaAlunos();
        }
        */

        // --------------------- Propriedades Anônimas (Permitem atribuir diferentes valores somente leitura à uma variável) - Não podem ser retornados em métodos.
        /*
            // vantajoso para limitar a quantidade de propriedades que se vai trabalhar.

        var anonima = new { Nome = "Fulano", Sobrenome = "De Tal", Idade = 37 };

        Console.WriteLine($"Nome: {anonima.Nome}\n" +
            $"Sobrenome: {anonima.Sobrenome}\n" +
            $"Idade: {anonima.Idade}");

        List<Curso> listaCursos = JsonConvert.DeserializeObject<List<Curso>>(File.ReadAllText("Arquivos/curso.json"));

        var listaanonima = listaCursos.Select(x => new { x.Nome, x.Valor });

        foreach (var curso in listaanonima)
        {
            Console.WriteLine($"Nome: {curso.Nome}\nValor: {curso.Valor.ToString("C")}");
        }
        */

        // --------------------- Nullable Types
        /*
        bool? assinatura = null;

        if (assinatura.HasValue && assinatura.Value)
        {
            Console.WriteLine($"Assinatura realizada.");
        }else
        {
            Console.WriteLine($"Cliente optou por não assinar ou se absteve.");
        }
        */

        // --------------------- Serialização de Objetos

        //Venda v1 = new Venda(1, "Material Escritório", 25.00M);
        //string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

        //Console.WriteLine(serializado);

        List<Curso> cursos = JsonConvert.DeserializeObject<List<Curso>>(File.ReadAllText("Arquivos/curso.json"));

        foreach (Curso curso in cursos)
        {
            curso.ListaAlunos();
        }

        // --------------------- Desconstrutores e IF Ternário
        /*
        Pessoa p1 = new Pessoa("Douglas", "Domingues", DateTime.Now);

        (string nome, string sobrenome) = p1;

        Console.WriteLine($"{nome} {sobrenome}");

        int numero = 20;

        Console.WriteLine($"O número {numero} é {(numero % 2 == 0 ? "par." : "ímpar.")}");
        */

        // --------------------- Tuplas permitem criar uma variável com vários dados de tipos diferentes, semelhante a um objeto, mas sua declaração é mais simples.
        /*
        (int Id, string Nome, string Sobrenome) exemplotupla = (1, "Douglas", "Domingues");
        var outroexemplotupla = Tuple.Create(1, "Douglas", "Domingues");
        ValueTuple<int, string, string> maisoutratupla = (1, "Douglas", "Domingues");

        //Console.WriteLine($"{exemplotupla}\n");
        Console.WriteLine($"ID: {exemplotupla.Id}");
        Console.WriteLine($"Nome: {exemplotupla.Nome}");
        Console.WriteLine($"Sobrenome: {exemplotupla.Sobrenome}\n");

        Console.WriteLine($"ID: {outroexemplotupla.Item1}");
        Console.WriteLine($"Nome: {outroexemplotupla.Item2}");
        Console.WriteLine($"Sobrenome: {outroexemplotupla.Item3}\n");

        Console.WriteLine($"ID: {maisoutratupla.Item1}");
        Console.WriteLine($"Nome: {maisoutratupla.Item2}");
        Console.WriteLine($"Sobrenome: {maisoutratupla.Item3}\n");


        LeitorArquivo texto1 = new LeitorArquivo();

        var (sucesso, linhas, qtdelinhas) = texto1.LeArquivo("Arquivos/Texto.txt"); //Obs.: Pra descartar determinado retorno, substitua nome da propriedade por um underline(_).

        if(sucesso)
        {
            Console.WriteLine($"Texto lido com sucesso\nNúmero de linhas do texto:{qtdelinhas}\n");
            foreach(var linha in linhas)
            {
                Console.WriteLine(linha);
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("Ocorreu um erro para ler o arquivo");
        }
        */

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

        // --------------------- Usando as propriedades, métodos e construtores / Json
        /*
        //Pessoa p1 = new Pessoa(nome: "Douglas", sobrenome: "Domingues", datainc: DateTime.Now);
        //Pessoa p2 = new Pessoa(nome: "Isabela", sobrenome: "Domingues", datainc: DateTime.Now);
        //Pessoa p3 = new Pessoa(nome: "Isadora", sobrenome: "Braga", datainc: DateTime.Now);

        Pessoa p1 = new Pessoa();

        //Curso c1 = new Curso(nome: "Curso de Canto", valor: 1299.99M);
        //Curso c2 = new Curso(nome: "Fundamentos .NET", valor: 1199.00M);

        //c1.Alunos = new List<Pessoa>();
        //c2.Alunos = new List<Pessoa>();
        //List<Curso> listaCursos = new List<Curso>();

        //c1.AdicionaAluno(p2);
        //c1.AdicionaAluno(p3);
        //c2.AdicionaAluno(p1);

        //listaCursos.Add(c1);
        //listaCursos.Add(c2);

        //Console.WriteLine($"O Curso {c1.Nome} possui {c1.ContagemAlunos()} Alunos");
        //c1.ListaAlunos();

        //string serialize = JsonConvert.SerializeObject(listaCursos, Formatting.Indented);
        //File.WriteAllText("Arquivos/curso.json", serialize);
        //Console.WriteLine($"\n{serialize}");
        */
    }
}