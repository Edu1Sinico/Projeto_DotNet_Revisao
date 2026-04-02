using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class Fibonacci
    {
        int num = 0;
        int result = 0, numAtual = 1, numAnterior = 0;
        int opcao = 0;

        public void menuFibonacci()
        {
            do
            {
                Console.WriteLine("\n===== FIBONACCI =====\n");
                Console.Write("Digite um número inteiro: ");
                num = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"\nResultado da sequência Fibonacci de {num} números: \n");
                for (int i = 0; i < num; i++)
                {
                    result = numAnterior + numAtual;
                    Console.WriteLine($"{numAnterior} + {numAtual} = {result}");
                    numAnterior = numAtual;
                    numAtual = result;
                }

                result  = 0;
                numAtual = 0;
                numAnterior = 0;

                Console.Write("\nDeseja continuar?"
                                + "\nQualquer número - Sim"
                                + "\n0 - Não"
                                + "\n\nOpção: ");
                opcao = Int32.Parse(Console.ReadLine());
            } while (opcao != 0);
        }
    }
}