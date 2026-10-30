namespace Fsg.ProgramacaoOrientadaObjetos;

public class Aluno
{
    public string Nome { get; set; }
    public string Matricula { get; set; }

    public Aluno(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }
}