namespace Fsg.ProgramacaoOrientadaObjetos;

public class Aluno
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Curso { get; set; }

    // Versão 1: Usando 'this' explicitamente para indicar a propriedade da própria classe
    /*
    public Aluno(string nome, string matricula, string curso)
    {
        this.Nome = nome;
        this.Matricula = matricula;
        this.Curso = curso;
    }
    */

    // Versão 2: Versão mais enxuta (sem 'this')
    public Aluno(string nome, string matricula, string curso)
    {
        Nome = nome;
        Matricula = matricula;
        Curso = curso;
    }
}