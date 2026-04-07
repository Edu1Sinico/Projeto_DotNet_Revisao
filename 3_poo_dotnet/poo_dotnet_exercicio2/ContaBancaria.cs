using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_exercicio2
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Saldo negativo!");
                saldo = value;
            }
        }

        public void depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
            else
                Console.WriteLine("Não é permitido inserir saldo negativo.");
        }

        public void sacar(decimal valor)
        {
            if (valor < 5000)
                Saldo -= valor;
            else
                Console.WriteLine("Valor ultrapassa o limite resgatável.");
        }

    }
}