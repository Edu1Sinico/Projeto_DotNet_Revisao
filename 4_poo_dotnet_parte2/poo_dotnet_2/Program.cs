
using poo_dotnet_2;

internal class Program
{
    //  Dominar Herança(Inheritance)
    //  Implementar Polimorfismo
    //  Criar Classes Abstratas
    //  Trabalhar com Interfaces
    //  Entender virtual, override, abstract
    //  Praticar com hierarquias de classes
    //  Preview dos princípios SOLID

    public static void Main(string[] args)
    {
        // Criando objetos
        Funcionario func = new Funcionario("João",5000);
        func.Nome = "João"; // Herdado de Pessoa
        func.Idade = 30; // Herdado de Pessoa
        func.Salario = 5000; // Próprio de Funcionario
        func.Cargo = "Desenvolvedor"; // Próprio de Funcionario

        // Métodos herdados funcionam!
        func.Apresentar(); // Herdado de Pessoa
        func.Trabalhar(); // Próprio de Funcionario

        // Output:
        // Olá, sou João
        // João está trabalhando como Desenvolvedor
        // Reutilização: Funcionario não precisa redefinir
        // Nome, Idade, Apresentar() - já vêm da classe Pessoa!
    }
}