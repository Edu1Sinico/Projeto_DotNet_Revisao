using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    public abstract class Forma2
    {
        public string Cor { get; set; } // Propriedade concreta

        // Construtor (chamado pelas filhas)
        public Forma2(string cor)
        {
            Cor = cor;
        }

        // Método abstrato - SEM implementação
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        // Método concreto - COM implementação
        public void Desenhar()
        {
            Console.WriteLine($"Desenhando forma {Cor}");
        }
    }
    // ERRO: não pode instanciar!
    // Forma f = new Forma("Azul"); // ERRO DE COMPILAÇÃO!
}