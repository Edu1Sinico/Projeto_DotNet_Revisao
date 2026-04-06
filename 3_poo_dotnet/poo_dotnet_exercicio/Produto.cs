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
        private double preco;
        private int estoque;

        public double Preco
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

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void DiminuirEstoque(int qtde)
        {
            estoque -= qtde;
        }

        public static void Apresentar(Produto p)
        {
            Console.WriteLine($"Nome: {p.Nome} | Preço: {p.preco} | Estoque: {p.estoque}");
        }
    }
}