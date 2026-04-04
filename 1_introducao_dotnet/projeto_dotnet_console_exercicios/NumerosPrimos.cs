using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class NumerosPrimos
    {

        int num = 0;
        int opcao = 0;


        public void menuNumeroPrimo()
        {
            do
            {
                Console.WriteLine("\n===== NÚMEROS PRIMOS =====\n");

                Console.Write("Digite um número inteiro: ");
                num = Int32.Parse(Console.ReadLine());

                if (numeroPrimo(num))
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

        public bool numeroPrimo(int num)
        {
            // 0, 1 e números negativos não são primos
            if (num <= 1) return false;

            // 2 é o único primo par
            if (num == 2) return true;

            // Se o número for par e maior que 2, não é primo
            if (num % 2 == 0) return false;

            // Testar divisores ímpares de 3 até a raiz quadrada do número
            int limite = (int)Math.Sqrt(num);
            for (int i = 3; i < limite; i+=2)
            {
                if(num % i == 0)
                {
                    return false; // Encontrou um divisor, não é primo
                }
            }
            return true;
        }
    }
}