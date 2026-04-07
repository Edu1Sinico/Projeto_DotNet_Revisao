using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    public class Forma
    {
        public virtual double CalcularArea()
        {
            return 0;
        }
    }

    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
    
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea()
        {
            return Largura * Altura;
        }
    }
    // Polimorfismo:
    // List<Forma> formas = new List<Forma>
    // {
    //      new Circulo { Raio = 5 },
    //      new Retangulo { Largura = 4, Altura = 3 }
    // };
    // foreach (var forma in formas)
    // {
    //      Console.WriteLine(forma.CalcularArea()); // Chama versão correta!
    // }
}