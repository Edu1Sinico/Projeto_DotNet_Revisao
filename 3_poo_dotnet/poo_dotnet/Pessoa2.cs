using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet
{
    public class Pessoa2
    {
        // Somente leitura - set apenas no construtor
        public string CPF { get; init; }

        // Read-Only tradicional (sem init)
        public DateTime DataCriacao { get; }

        // Propriedade normal
        public string Nome { get; set; }

        public Pessoa2(string cpf, string nome)
        {
            CPF = cpf; // Só pode setar aqui
            Nome = nome;
            DataCriacao = DateTime.Now;
        }
    }

    // Uso:
    // Pessoa p = new Pessoa("123.456.789-00", "João");
    // Console.WriteLine(p.CPF); // OK: ler
    // p.Nome = "João Silva"; // OK: modificar
    // p.CPF = "000.000.000-00"; // ERRO! CPF é init-only
    // p.DataCriacao = DateTime.Now; // ERRO! Sem setter
}