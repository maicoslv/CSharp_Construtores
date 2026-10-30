using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Livro 1: Criado usando o construtor com 2 parâmetros (sem ano)
        Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");

        // Livro 2: Criado usando o construtor com 3 parâmetros (com ano)
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899);

        // Exibindo os dados dos dois livros
        Console.WriteLine("=== LIVROS CADASTRADOS ===");
        Console.WriteLine($"Livro 1: '{livro1.Titulo}' por {livro1.Autor} | Ano: {(livro1.AnoPublicacao == 0 ? "Não informado" : livro1.AnoPublicacao.ToString())}");
        Console.WriteLine($"Livro 2: '{livro2.Titulo}' por {livro2.Autor} | Ano: {livro2.AnoPublicacao}");
    }
}