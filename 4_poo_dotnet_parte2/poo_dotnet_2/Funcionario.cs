using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    // CLASSE DERIVADA (FILHA) - usa : (dois pontos)
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        // base() chama construtor da classe pai
        public Funcionario(string nome, decimal salario) : base(nome)
        {
            Salario = salario;
            Console.WriteLine("Construtor Funcionario chamado");
        }


        public void Trabalhar()
        {
            Console.WriteLine($"{Nome} está trabalhando como {Cargo}");
        }
    }

    // --------------------------------------------------------------------
    // Herança

    // Funcionario TEM: Nome, Idade (herdados) + Salario, Cargo
    // Funcionario TEM: Apresentar() (herdado) + Trabalhar()

    // --------------------------------------------------------------------
    // Palavra-chave base - Acessar Classe Pai (CONSTRUTOR)

    // Uso:
    // var f = new Funcionario("João", 5000);
    // Output:
    // Construtor Pessoa chamado
    // Construtor Funcionario chamado
}