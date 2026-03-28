using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class Calculadora
    {

        public void menuCalculadora()
        {
            int opcao = 0;
            double num1 = 0, num2 = 0;
            double result = 0;

            do
            {
                Console.WriteLine("\n===== CALCULADORA =====\n");

                Console.Write("Informe um número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nInforme uma opção: "
                                + "\n1 - Soma"
                                + "\n2 - Subtração"
                                + "\n3 - Multiplicação"
                                + "\n4 - Divisão"
                                + "\n5 - Sair"
                                + "\n\nOpção: ");
                opcao = Int32.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nResultado da soma: " + soma(num1, num2) + ".");
                        break;
                    case 2:
                        Console.WriteLine("\nResultado da subtração: " + sub(num1, num2) + ".");
                        break;
                    case 3:
                        Console.WriteLine("\nResultado da multiplicação: " + mult(num1, num2) + ".");
                        break;
                    case 4:
                        result = div(num1, num2);
                        if (result == 0)
                        {
                            Console.WriteLine("\nImpossível divisão por zero!");
                        }
                        else
                        {
                            Console.WriteLine("Resultado da divisão: " + result + ".");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nEncerrando...\n");
                        break;
                    default:
                        Console.WriteLine("\nEscolha uma das opções acima!");
                        break;
                }
            } while (opcao != 5);
        }
        public double soma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double mult(double num1, double num2)
        {
            return num1 * num2;
        }

        public double div(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                return 0;
        }
    }
}