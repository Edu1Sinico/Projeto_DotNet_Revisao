using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_exercicio
{
    public class Cliente
    {
        public string Nome {get;set;}
        private string cpf;
        private string email;

        public string CPF
        {
            get{return cpf;}
            set
            {
                if(value == null || value.Length != 11)
                    throw new ArgumentException("Número de CPF inválido!");
                cpf = value;
            }
        }

        public string Email
        {
            get {return email;}
            set
            {
                if (value == null || !value.Contains("@"))
                    throw new ArgumentException("E-mail inválido!");
                email = value;
            }
        }

        public Cliente(){}

        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
        }

        public static void Apresentar(Cliente c)
        {
            Console.WriteLine($"\nNome: {c.Nome} | CPF: {c.cpf} | E-mail: {c.email}");
        }

    }
}