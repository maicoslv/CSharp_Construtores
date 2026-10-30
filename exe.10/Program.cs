using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criando dois Alunos
        Aluno aluno1 = new Aluno("Maicon", "A101");
        Aluno aluno2 = new Aluno("Ana", "A102");

        // 2. Criando dois Professores
        Professor prof1 = new Professor("Carlos", "P501");
        Professor prof2 = new Professor("Mariana", "P502");

        // 3. Criando duas Disciplinas
        Disciplina disc1 = new Disciplina("Programação C#", 80);
        Disciplina disc2 = new Disciplina("Banco de Dados", 60);

        // Exibindo todos os dados no console
        Console.WriteLine("=== ALUNOS ===");
        Console.WriteLine($"[#{aluno1.Matricula}] {aluno1.Nome}");
        Console.WriteLine($"[#{aluno2.Matricula}] {aluno2.Nome}");

        Console.WriteLine("=== PROFESSORES ===");
        Console.WriteLine($"[#{prof1.Registro}] Prof. {prof1.Nome}");
        Console.WriteLine($"[#{prof2.Registro}] Prof. {prof2.Nome}");

        Console.WriteLine("=== DISCIPLINAS ===");
        Console.WriteLine($"{disc1.Nome} - Carga Horária: {disc1.CargaHoraria}h");
        Console.WriteLine($"{disc2.Nome} - Carga Horária: {disc2.CargaHoraria}h");

        /*
         * CONSOLIDAÇÃO DOS CONCEITOS DA AULA 4:
         * 
         * 1. Construtor:
         *    É um método especial da classe executado no momento da instanciação (new).
         *    Garante que o objeto nasça com suas informações obrigatórias preenchidas.
         * 
         * 2. Sobrecarga (Overloading):
         *    Capacidade de ter mais de um construtor na mesma classe,
         *    recebendo parâmetros com tipos ou quantidades diferentes.
         * 
         * 3. 'this':
         *    Refere-se à própria instância atual do objeto.
         *    Também usado como this(...) para chamar outro construtor da mesma classe (encadeamento).
         * 
         * 4. Object Initializer:
         *    Sintaxe com chaves { Propriedade = valor } que permite atribuir valores 
         *    às propriedades logo após a execução do construtor.
         * 
         * 5. Estado Inicial:
         *    É o conjunto de valores das propriedades do objeto logo após sua criação.
         *    O uso de construtores garante que esse estado inicial seja válido.
         */
    }
}