using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_exercicio
{
    public class Pedido
    {
        public int ID { get; }
        private Cliente cliente;
        private List<Produto> produtos;
        public DateTime Data { get; }
        public double Total { get; }
        public List<int> Quantidade { get; set; }

        public Pedido(Cliente cliente, List<Produto> produtos, List<int> qtde)
        {
            ID = ID + 1;
            this.cliente = cliente;
            this.produtos = produtos;
            Data = DateTime.Now;
            Quantidade = qtde;
            Total = CalcularTotal(qtde);
        }

        private double CalcularTotal(List<int> qtde)
        {
            double total = 0;
            for (int i = 0; i < produtos.Count; i++)
            {
                total += produtos[i].Preco * qtde[i];
            }
            return total;
        }

        public static void Apresentar(Pedido p)
        {
            Console.WriteLine("\n{"
                + $"\nID: {p.ID}"
                + $"\nCliente: {p.cliente.Nome}"
                + $"\nData do Pedido: {p.Data}"
                + $"\nTotal: {p.Total}"
                + "\nProdutos:");

            for (int i = 0; i < p.produtos.Count; i++)
            {
                Console.WriteLine($"- {p.produtos[i].Nome} | Quantidade: {p.Quantidade[i]} | Preço: {p.produtos[i].Preco}");
            }

            Console.WriteLine("}");
        }

    }
}