using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando o aluno usando o construtor completo
        Aluno aluno1 = new Aluno("Maico", "20261234", "Análise e Desenvolvimento de Sistemas");

        // Exibindo no console
        Console.WriteLine("=== DADOS DO ALUNO ===");
        Console.WriteLine($"Nome: {aluno1.Nome}");
        Console.WriteLine($"Matrícula: {aluno1.Matricula}");
        Console.WriteLine($"Curso: {aluno1.Curso}");

        /*
         * RESPOSTA DA COMPARAÇÃO DIDÁTICA:
         * 
         * 1. Por que ambas funcionam?
         * Porque as propriedades usam PascalCase (ex: Nome) e os parâmetros usam camelCase (ex: nome).
         * Como os nomes possuem diferenças entre maiúsculas e minúsculas, o C# identifica 
         * perfeitamente que 'Nome' refere-se à propriedade da classe e 'nome' ao parâmetro do método.
         * 
         * 2. Qual é a mais enxuta?
         * A segunda versão (Nome = nome;) é mais enxuta e limpa, pois elimina o uso desnecessário 
         * do 'this.' quando não há ambiguidade de nomes no código.
         */
    }
}