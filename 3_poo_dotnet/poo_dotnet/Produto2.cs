using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet
{
    public class Produto2
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        // 1. Construtor PADRÃO (sem parâmetros)
        public Produto2()
        {
            Nome = "Sem nome";
            Preco = 0;
        }

        // 2. Construtor PARAMETRIZADO
        public Produto2(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // 3. Construtor com VALIDAÇÃO
        public Produto2(string nome, decimal preco, bool validar)
        {
            if (validar && preco < 0)
                throw new ArgumentException("Preço inválido!");
            Nome = nome;
            Preco = preco;
        }

    }
}