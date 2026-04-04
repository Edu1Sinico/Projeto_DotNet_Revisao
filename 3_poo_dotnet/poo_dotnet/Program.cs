
using poo_dotnet;

internal class Program {
    public static void Main(string[] args)
    {
        // Criando objetos usando NEW
        Pessoa pessoa1 = new Pessoa("João",25);
        Pessoa pessoa2 = new Pessoa("Maria",30);
        Pessoa pessoa3 = new Pessoa("Pedro",28);

        // Acessando propriedades
        Console.WriteLine(pessoa1.Nome); // João
        Console.WriteLine(pessoa2.Idade); // 30

        // Modificando propriedades
        pessoa1.Idade = 26;
        pessoa2.Nome = "Maria Silva";

        // Chamando métodos
        pessoa1.apresentar(); // Olá, sou João, tenho 26 anos.
        pessoa2.apresentar(); // Olá, sou Maria Silva, tenho 30 anos.
        pessoa3.apresentar(); // Olá, sou Pedro, tenho 28 anos.
    }
}
