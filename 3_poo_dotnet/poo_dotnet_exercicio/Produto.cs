using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_exercicio
{
    public class Produto
    {
        // Atributos
        public string Nome { get; set; }
        private decimal preco;
        private int estoque;

        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço não pode ser negativo!");
                preco = value;
            }
        }

        public int Estoque
        {
            get { return estoque; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O estoque não pode ser negativo!");
                estoque = value;
            }
        }

        public int DiminuirEstoque(int qtde)
        {
            return estoque - qtde;
        }
    }
}