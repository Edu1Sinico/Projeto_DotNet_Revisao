using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet
{
    public class Produto
    {
        // Fields (campos) = geralmente PRIVATE
        private string nome;
        private decimal preco;
        private int estoque;

        // Características:
        // • Armazem dados da classe
        // • Geralmente private (encapsulados)
        // • Nomenclatura: camelCase
        // • Acesso direto (Sem get/set)
        // • Mais rápidos (menos overhead)
        // • Sem validação automática


        // Property com Validação - Exemplo prático
        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Preço não pode ser negativo!");
                if (value > 1000000)
                    throw new ArgumentException("Preço muito alto!");
                preco = value;
            }
        }

        public int Estoque
        {
            get { return estoque; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Estoque não pode ser negativo!");
                estoque = value;
            }
        }
    }

    // NÃO RECOMENDADO: campos públicos
    public class ProdutoRuim
    {
        public string nome; // Sem proteção!
        public decimal preco; // Qualquer um pode alterar
        // Viola o encapsulamento
    }
}