using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // 2. Criando duas pessoas usando o construtor obrigatório
        Pessoa pessoa1 = new Pessoa("Maico", 32);
        Pessoa pessoa2 = new Pessoa("Ana", 27);

        // Tentativa inválida (daria erro de compilação!):
        // Pessoa pessoa3 = new Pessoa(); //  O C# não deixa criar sem nome e idade!

        // 3. Exibindo os dados no console
        Console.WriteLine("=== PESSOAS CADASTRADAS ===");
        Console.WriteLine($"Nome: {pessoa1.Nome} | Idade: {pessoa1.Idade} anos");
        Console.WriteLine($"Nome: {pessoa2.Nome} | Idade: {pessoa2.Idade} anos");

        /*
         * 4. EXPLICAÇÃO DE POR QUE 'new Pessoa()' SEM ARGUMENTOS NÃO FUNCIONA:
         * 
         * Quando não escrevemos nenhum construtor na classe, o C# cria automaticamente 
         * um construtor padrão sem parâmetros (vazio).
         * 
         * Porém, a partir do momento em que criamos QUALQUER construtor personalizado 
         * (como o Pessoa(string nome, int idade)), o C# REMOVE o construtor padrão vazio.
         * 
         * Por isso, tentar fazer 'new Pessoa()' sem passar argumentos causa um erro de compilação, 
         * pois agora a classe exige obrigatoriamente um nome e uma idade para nascer!
         */
    }
}