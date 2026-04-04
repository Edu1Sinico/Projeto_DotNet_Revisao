using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet
{
    public class Pessoa
    {
        // 1. CAMPOS (Fields) - dados privados internos
        private string nome;
        private int idade;

        // 2. PROPRIEDADES (Properties) - interface pública
        public string Nome {get;set;}
        public int Idade {get;set;}

        // 3. CONTRUTORES - inicialização de objetos
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // 4. MÉTODOS - Comportamentos/ações
        public void apresentar()
        {
            Console.WriteLine($"Olá, sou {Nome}, tenho {Idade} anos.");
        }
    }
}