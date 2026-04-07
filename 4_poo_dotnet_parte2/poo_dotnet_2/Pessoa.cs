using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    // CLASSE BASE (PAI)
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
            Console.WriteLine("Construtor Pessoa chamado");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, sou {Nome}");
        }

    }
}