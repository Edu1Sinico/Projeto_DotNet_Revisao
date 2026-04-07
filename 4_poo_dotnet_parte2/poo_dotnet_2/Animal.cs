using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    public class Animal
    {
        // virtual = pode ser sobrescrito
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico de animal");
        }

    }

    public class Cachorro : Animal
    {
        // override = sobrescreve método da classe pai
        public override void EmitirSom()
        {
            Console.WriteLine("Au au!");
        }
    }

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }

    // Uso polimórfico:
    // Animal a1 = new Cachorro();
    // Animal a2 = new Gato();
    // a1.EmitirSom(); // Au au!
    // a2.EmitirSom(); // Miau!
    // Mesmo método, comportamentos diferentes!
}