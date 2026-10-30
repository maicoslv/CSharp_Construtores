namespace Fsg.ProgramacaoOrientadaObjetos;

public class Professor
{
    public string Nome { get; set; }
    public string Registro { get; set; }

    public Professor(string nome, string registro)
    {
        Nome = nome;
        Registro = registro;
    }
}