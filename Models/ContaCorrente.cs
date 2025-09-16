using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque no valor de R${valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Valor desejado para saque é maior que o disponivel em sua conta.");
                ExibirSaldo();
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é R${Saldo}");
        }
    }
}