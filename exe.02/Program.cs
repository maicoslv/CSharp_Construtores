using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Forma 1: Usando o construtor sem parâmetros e preenchendo depois
        Produto produto1 = new Produto();
        produto1.Nome = "Mouse Gamer";
        produto1.Preco = 120.50m;

        // Forma 2: Usando o construtor que já exige Nome e Preço na criação
        Produto produto2 = new Produto("Teclado Mecânico", 250.00m);

        // Exibindo os dados dos dois produtos
        Console.WriteLine("=== PRODUTOS CRIADOS DE FORMAS DIFERENTES ===");
        Console.WriteLine($"Produto 1 (Sem parâmetros): {produto1.Nome} - R$ {produto1.Preco:F2}");
        Console.WriteLine($"Produto 2 (Com parâmetros): {produto2.Nome} - R$ {produto2.Preco:F2}");
    }
}