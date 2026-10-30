using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Criando o retângulo obrigatoriamente com Largura e Altura
        Retangulo meuRetangulo = new Retangulo(5.0, 3.0);

        // Testando se o estado inicial foi configurado corretamente através do cálculo da área
        double area = meuRetangulo.CalcularArea();

        Console.WriteLine("=== RETÂNGULO ===");
        Console.WriteLine($"Largura: {meuRetangulo.Largura}");
        Console.WriteLine($"Altura: {meuRetangulo.Altura}");
        Console.WriteLine($"Área calculada: {area}");
    }
}