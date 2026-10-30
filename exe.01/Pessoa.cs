namespace Fsg.ProgramacaoOrientadaObjetos;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor que exige nome e idade na hora de criar o objeto
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}