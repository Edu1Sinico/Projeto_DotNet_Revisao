using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace projeto_dotnet_console_exercicios
{
    public class CalculadoraIMC
    {
        public void menuCalculadoraIMC()
        {
            double peso = 0, altura = 0;

            Console.WriteLine("\n===== CALCULADORA IMC =====\n");


            Console.Write("Informe seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSua situação: " + calcIMC(peso,altura));
        }

        public string calcIMC(double peso, double altura)
        {
            double resultado = peso / (altura * altura);

            if (resultado < 18.5)
                return "abaixo do peso.";
            else if (resultado >= 18.5 && resultado < 25)
                return "peso normal.";
            else if (resultado >= 25 && resultado <= 29.9)
                return "sobrepeso.";
            else
                return "acima do peso";
        }
    }
}