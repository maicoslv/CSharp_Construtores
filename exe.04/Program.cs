using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Conta 1: Criada sem saldo inicial (o construtor vai definir como 0)
        ContaBancaria conta1 = new ContaBancaria("1001-X", "Maico");

        // Conta 2: Criada com saldo inicial de R$ 500.00
        ContaBancaria conta2 = new ContaBancaria("2002-Y", "Ana", 500.00m);

        // Exibindo os dados das contas
        Console.WriteLine("=== CONTAS BANCÁRIAS ===");
        Console.WriteLine($"Conta: {conta1.Numero} | Titular: {conta1.Titular} | Saldo: R$ {conta1.Saldo:F2}");
        Console.WriteLine($"Conta: {conta2.Numero} | Titular: {conta2.Titular} | Saldo: R$ {conta2.Saldo:F2}");
    }
}