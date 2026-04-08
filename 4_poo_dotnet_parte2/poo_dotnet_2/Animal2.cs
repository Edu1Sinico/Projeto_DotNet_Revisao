using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    public abstract class Animal2
    {
        // Método ABSTRATO - sem corpo, termina com ;
        // Classe filha OBRIGATORIAMENTE implementa
        public abstract void EmitirSom();
        public abstract void Mover();

        // Método CONCRETO - com corpo (implementação)
        // Classe filha pode usar ou sobrescrever
        public virtual void Dormir()
        {
            Console.WriteLine("Zzzzz...");
        }

        public void Respirar() // Concreto sem virtual
        {
            Console.WriteLine("Respirando...");
        }
    }

    // Regra:
    // • Método abstract OBRIGA override na filha
    // • Método virtual PERMITE override (opcional)
    // • Método comum não pode ser sobrescrito
}