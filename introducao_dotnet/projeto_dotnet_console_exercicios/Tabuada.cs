using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class Tabuada
    {

        int num = 0;
        double result = 0;
        int opcao = 1;

        public void menuTabuada()
        {
            do
            {
                Console.WriteLine("\n===== TABUADA =====\n");

                Console.Write("Digite um número inteiro: ");
                num = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"\nResultado da tabuado do {num}: \n");
                for (int i = 1; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine($"{num} x {i} = {result}.");
                }

                Console.Write("\nDeseja continuar?"
                                + "\nQualquer número - Sim"
                                + "\n0 - Não"
                                + "\n\nOpção: ");
                opcao = Int32.Parse(Console.ReadLine());
            } while (opcao != 0);

        }
    }
}