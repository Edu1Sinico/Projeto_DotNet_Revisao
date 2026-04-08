using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    public abstract class Forma3
    {
        public abstract double CalcularArea();
    }

    // ---------------------------------------------------------------------------

    // Classe CONCRETA - implementa métodos abstratos
    public class Circulo2 : Forma3
    {
        public double Raio { get; set; }

        // OBRIGATÓRIO implementar métodos abstratos
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }

    // ---------------------------------------------------------------------------
    
    public class Quadrado2 : Forma3
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }

    // Uso polimórfico:
    // Forma f1 = new Circulo { Raio = 5 };
    // Forma f2 = new Quadrado { Lado = 4 };
    // Console.WriteLine(f1.CalcularArea()); // 78.54
    // Console.WriteLine(f2.CalcularArea()); // 16
}