// Introdução .NET 8




using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {

        // ====== VARIÁVEIS & CONSTANTES ======

        // Tipos normais NÃO podem ser null 
        // int numero = null; // Erro

        // Tipos nullable PODEM ser null
        // int? numero = null; // Ok
        // string? nome = null; // Ok

        // Verificação
        /* if (numero.HasValue)
        {
            Console.WriteLine(numero.Value);
        } */

        // ---------------------------------------------------------

        // Declaração Explícita
        int idade = 25;
        string nome1 = "João";
        double preco = 99.90;

        // Tipo inferido (var)
        var idade1 = 25;
        var nome2 = "João";
        var preco1 = 99.90;

        // Constantes
        const double PI = 3.14159;
        const int MAX_USUARIOS = 100;

        // =====================================================================================

        // ===== ESTRUTURA DE CONTROLE (IF & SWITCH) =====

        if (idade >= 18)
        {
            Console.WriteLine("Maior de Idade");
        }
        else if (idade >= 12)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Criança");
        }

        int diaSemana = 6;

        switch (diaSemana)
        {
            case 1:
                Console.WriteLine("Segunda");
                break;
            case 2:
                Console.WriteLine("Terça");
                break;
            case 3:
                Console.WriteLine("Quarta");
                break;
            case 4:
                Console.WriteLine("Quinta");
                break;
            case 5:
                Console.WriteLine("Sexta");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Outro");
                break;
        }

        // =====================================================================================

        // ===== ESTRUTURA DE REPETIÇÃO (FOR, WHILE & DO... WHILE) =====
        Console.WriteLine("\nFor: ");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nDo... While: ");

        int j = 0;
        do
        {
            Console.WriteLine(j++);
        } while (j < 10);

        Console.WriteLine("\nWhile: ");

        int z = 0;
        while (z < 10)
        {
            Console.WriteLine(z++);
        }

        Console.WriteLine("\nForeach: ");

        string[] nomes = { "Ana", "João" };
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // Bonus: Controle de Loops (break, continue e return)

        Console.WriteLine("\nControle de Loops: ");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5) break; // Para quando i for 5
            if (i % 2 == 0) continue; // Pula números pares
            Console.WriteLine(i); // Imprime apenas ímpares até 5
        }

        // =====================================================================================

        // ===== ENTRADA DE USUÁRIO (READLINE) =====

        // Lendo Entrada
        Console.Write("\nDigite sua idade: ");
        string? entrada = Console.ReadLine();

        // Validando e convertendo (tenta converter para inteiro e depois passa a saída para uma variável int idade)
        if (int.TryParse(entrada, out int idadeConvertido))
        {
            if (idadeConvertido >= 18)
            {
                Console.WriteLine("\nMaior de Idade");
            }
            else
            {
                Console.WriteLine("\nMenor de Idade");
            }
        }
        else
        {
            Console.WriteLine("\nIdade inválida!");
        }
    }
}