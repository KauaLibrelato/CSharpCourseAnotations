using System;

namespace ContaBancariaBasica {
    internal class Program {
        static void Main(string[] args) {
            ContaBancaria conta;

            Console.WriteLine("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(nome, numeroConta, depositoInicial);
            }
            else {
                conta = new ContaBancaria(nome, numeroConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}