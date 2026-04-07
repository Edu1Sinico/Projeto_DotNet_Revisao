using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    // sealed = IMPEDIR que outras classes herdem
    public sealed class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

    }

    // ERRO: Não pode herdar de classe sealed!
    /* public class ContaPoupanca : ContaBancaria // ERRO DE COMPILAÇÃO!
    {
        // Não permitido!
    } */
    
    // Quando usar sealed:
    // • Segurança (impedir alteração de comportamento)
    // • Performance (compilador otimiza)
    // • Quando classe não foi projetada para herança
    // Exemplo real: string é sealed em C#!
}