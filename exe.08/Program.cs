using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Criando o objeto combinando o construtor com o object initializer
        Carro carro = new Carro("Volkswagen", "Polo", 2023)
        {
            Cor = "Azul"
        };

        // Exibindo no console
        Console.WriteLine("=== DADOS DO CARRO ===");
        Console.WriteLine($"Marca: {carro.Marca}");
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Ano: {carro.Ano}");
        Console.WriteLine($"Cor: {carro.Cor}");
    }
}