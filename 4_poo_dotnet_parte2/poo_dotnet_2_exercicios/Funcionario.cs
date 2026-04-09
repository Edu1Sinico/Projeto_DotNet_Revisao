using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2_exercicios
{
    public class Funcionario : Pessoa
    {
        public decimal Salario{get;set;}
        public string Cargo{get;set;}
        public DateTime DataAdmissao{get;set;}

        public Funcionario(string nome, string cpf, DateTime dataNascimento, decimal salario, string cargo, DateTime dataAdmissao) : base(nome, cpf, dataNascimento)
        {
            Salario = salario;
            Cargo = cargo;
            DataAdmissao = dataAdmissao;
        }

        public override void Apresentar()
        {
            throw new NotImplementedException();
        }

        public int CalcularTempoEmpresa()
        {
            int dataDiferenca = DateTime.Today.Year - DataAdmissao.Year;
            return dataDiferenca;
        }
    }
}