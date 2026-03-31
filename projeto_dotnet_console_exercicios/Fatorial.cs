using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class Fatorial
    {

        int num = 0;
        int result = 1;
        int opcao = 1;

        public void menuFatorial()
        {
            do
            {
                Console.WriteLine("\n===== FATORIAL =====\n");

                Console.Write("Digite um número inteiro: ");
                num = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"\nResultado do fatorial do número: {num}: {fatorial(num)}.\n");

                Console.Write("\nDeseja continuar?"
                                + "\nQualquer número - Sim"
                                + "\n0 - Não"
                                + "\n\nOpção: ");
                opcao = Int32.Parse(Console.ReadLine());
            } while (opcao != 0);

        }

        public int fatorial(int num1)
        {
            for (int i = 0; i < num; i++)
            {
                result *= num - i;
            }
            return result;
        }
    }
}