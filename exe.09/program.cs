using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // 1 Cliente criado apenas com nome
        Cliente cliente1 = new Cliente("Maico");

        // 2 Cliente criado com nome e e-mail
        Cliente cliente2 = new Cliente("Ana", "ana@email.com");

        // 3 Cliente criado com nome, e-mail e telefone
        Cliente cliente3 = new Cliente("Lucas", "lucas@email.com", "(54) 99999-8888");

        // Exibindo no console
        Console.WriteLine("=== CLIENTES CADASTRADOS ===");
        Console.WriteLine($"Cliente 1: {cliente1.Nome} | E-mail: {cliente1.Email} | Tel: {cliente1.Telefone}");
        Console.WriteLine($"Cliente 2: {cliente2.Nome} | E-mail: {cliente2.Email} | Tel: {cliente2.Telefone}");
        Console.WriteLine($"Cliente 3: {cliente3.Nome} | E-mail: {cliente3.Email} | Tel: {cliente3.Telefone}");
    }
}