
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {

        /* 
        • Trabalhar com Arrays e Arrays Multidimensionais
        • Dominar Coleções Genéricas(List, Dictionary, HashSet)
        • Manipular Strings eficientemente
        • Criar e usar Métodos e Funções
        • Entender Tratamento de Exceções
        • Introdução ao LINQ(consultas em coleções) */

        // ====== ARRAYS ======

        // Declaração Inicial
        int[] numeros = new int[5];

        // Com valores iniciais
        int[] nums = { 1, 2, 3, 4, 5 };

        // Acessando elementos
        int primeiro = nums[0]; // 1
        int ultimo = nums[4]; // 5

        // Tamanho do array
        int tamanho = nums.Length; // 5

        // ====== ARRAYS MULTIDIMENSIONAIS ======

        // Array 2D (Matriz)
        int[,] matriz = new int[3, 3];

        // Com valores
        int[,] mat =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        // Acessar elementos
        int valor = mat[1, 2]; // 6

        // ====== LISTAS, DICIONÁRIO & HASH SET ======

        // Criar uma lista
        List<string> nomes = new List<string>();

        // Adicionar elementos
        nomes.Add("João");
        nomes.Add("Maria");

        // Acessar
        string primeiroNome = nomes[0]; // João

        // Remover
        nomes.Remove("João");
        nomes.RemoveAt(0); // João

        // ----------------------------------

        // Criar um dicionário
        Dictionary<string, int> idades = new Dictionary<string, int>();

        // Adicionar
        idades["João"] = 25;
        idades.Add("Maria", 30);

        // Acessar
        int idadeDic = idades["João"];

        // Verificar se existe 
        if (idades.ContainsKey("Ana")) { }

        // ----------------------------------

        // HashSet, Queue e Stack

        // HashSet<T> - Sem Duplicatas
        HashSet<int> numsHash = new HashSet<int>();
        numsHash.Add(1); numsHash.Add(1); // Só uma Vez


        // ----------------------------------

        // Queue<t> - Fila (FIFO)
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("A"); // Adiciona
        var filaPrimeiro = fila.Dequeue(); // Remove


        // ----------------------------------

        // Stack<T> - Pilha (LIFO)
        Stack<int> pilha = new Stack<int>();

        pilha.Push(1); // Empilha
        var topo = pilha.Pop(); // Desempilha

        // ====== MANIPULAÇÃO DE STRING ======

        // String Interpolation

        string nome = "João";
        int idade = 25;

        // Forma antiga (concatenação)
        string msg1 = "Olá " + nome + "!";

        // Forma moderna (interpolacação)
        string msg2 = $"Olá {nome}";
        string msg3 = $"{nome} tem {idade} anos";

        // StringBuilder - Para concatenação múltiplas

        StringBuilder sb = new StringBuilder();
        sb.Append("Olá");
        sb.Append(" ");
        sb.Append("Mundo");
        string resultado = sb.ToString();

        // ====== MÉTODOS E FUNÇÕES ======

        // Métodos sem retorno (void)
        void ImprimirMensagem(string msg)
        {
            Console.WriteLine(msg);
        }

        // Método com retorno
        int Somar(int a, int b)
        {
            return a + b;
        }

        // Chamado métodos
        ImprimirMensagem("Olá!");
        int resultadoSoma = Somar(5, 3); // 8

        // •-< Parâmetros Especiais >-•

        // Parâmetros Opcionais
        void Saudar(string nome, string saudacao = "Olá")
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudar("João");         // Olá, João!
        Saudar("Maria", "Oi");   // Oi, Maria!

        // Parâmetros Nomeados
        Saudar(nome: "Pedro", saudacao: "E ai");

        // ref - Passagem de referência
        void Dobrar(ref int numero)
        {
            numero *= 2;
        }

        int x = 5;
        Dobrar(ref x);
        Console.WriteLine(x);

        // out - Saída obrigatória
        // bool TryParse(string s, out int result){}

        // ---------------------------------

        // Sobrecarga de Métodos (Overload)

        // Mesmo nome, assinaturas diferentes
        int SomarAB(int a, int b)
        {
            return a + b;
        }

        /* double SomarAB(double a, double b)
        {
            return a + b;
        }

        int SomarAB(int a, int b, int c)
        {
            return a+b+c;
        } */

        // C# escolhe o método correto automaticamente!

        // ====== TRATAMENTOS DE EXCEÇÃO ======

        try
        {
            // Código que pode gerar erro
            // int resultadoDiv = 10/0;
        }
        catch (DivideByZeroException ex)
        {
            // Trata erro específico 
            Console.WriteLine("Não pode dividir por zero!");
        }
        finally
        {
            // SEMPRE executa (com ou sem erro)
            Console.WriteLine("Finalizando...");
        }


        // Usar exceções customizadas
        void ValidarIdade(int idade)
        {
            if (idade < 0 || idade > 120)
            {
                throw new IdadeInvalidaException("Idade deve estar entre 0 e 120.");
            }
        }

        // ====== LINQS ======

        // Sem LINQ (Forma tradicional)
        List<int> numerosLIQN = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> paresSemLINQ = new List<int>();
        foreach (int n in numerosLIQN)
        {
            if (n % 2 == 0) paresSemLINQ.Add(n);
        }

        // Com LINQ (moderno)

        var paresComLINQ = numerosLIQN.Where(n => n % 2 == 0).ToList();
        // Resultado: {2,4,6,8,10}

        // --- LiNQ: Select (Transformar) ---

        List<string> nomesComLINQ = new List<string> { "João", "Maria", "Pedro" };

        // Transformar em maiúsculas
        var nomesUpper = nomesComLINQ.Select(n => n.ToUpper()).ToList();
        // Resultado: {"JOÃO","MARIA","PEDRO"}

        // Transformar em tamanhos
        var tamanhos = nomesComLINQ.Select(n => n.Length).ToList();
        // Resultado: {4,5,5}

        // Combinar Where + Select
        var resultadoWhereSelect = numerosLIQN.Where(n => n > 5).Select(n => n * 2).ToList();

    }

    // Criando Exceções Customizadas

    // Criar exceção customizada
    public class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException(string mensagem) : base(mensagem) { }
    }
}
