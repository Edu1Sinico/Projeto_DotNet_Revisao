using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class NumerosPrimos
    {

        int num = 0;
        int result = 0;
        int opcao = 0;
        int contDivisores = 0;

        public void menuNumeroPrimo()
        {

            do
            {
                Console.WriteLine("\n===== NÚMEROS PRIMOS =====\n");

                Console.Write("Digite um número inteiro: ");
                num = Int32.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    // Tentar dividir por 2 e por 3.
                    
                }

                if (contDivisores == 1 || contDivisores == 2)
                {
                    Console.WriteLine($"\nO número {num} é um número primo.");
                } else
                {
                    Console.WriteLine($"\nO número {num} não é um número primo.");
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