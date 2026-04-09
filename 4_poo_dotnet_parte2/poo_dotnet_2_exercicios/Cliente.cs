using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2_exercicios
{
    public class Cliente : Pessoa
    {
        public int ID { get; init; }
        public decimal CreditoDisponivel{get;set;}
        private static int contadorId = 0;

        public Cliente(string nome, string cpf, DateTime dataNascimento, decimal creditoDisponivel) : base(nome, cpf, dataNascimento)
        {
            ID = ++contadorId;
            CreditoDisponivel = creditoDisponivel;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {CalcularIdade}");
        }

        public void RealizarCompra(decimal valor){
            
        }
    }
}