using System;
using System.Globalization;

namespace ContaBancariaBasica {
    internal class ContaBancaria {
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public int NumeroConta { get; private set; }


        public ContaBancaria(string nome, int numeroConta) {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta) {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5.0;
        }

        public override string ToString() {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
