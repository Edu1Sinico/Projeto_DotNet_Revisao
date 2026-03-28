using projeto_dotnet_console_exercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        // Instância de objetos
        Calculadora calc = new Calculadora();
        CalculadoraIMC calcIMC = new CalculadoraIMC();
        Tabuada tabuada = new Tabuada();
        Fatorial fatorial = new Fatorial();

        // Exercício Calculadora Básica
        calc.menuCalculadora();

        // Exercício Calculadora IMC
        calcIMC.menuCalculadoraIMC();

        // Exercício da Tabuada
        tabuada.menuTabuada();

        // Exercício de Fatorial
        fatorial.menuFatorial();
    }
}