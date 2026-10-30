namespace Fsg.ProgramacaoOrientadaObjetos;

public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    // Construtor 1: Recebe apenas o nome
    // Encadeia com o Construtor 2 passando "Não informado" no e-mail
    public Cliente(string nome) 
        : this(nome, "Não informado")
    {
    }

    // Construtor 2: Recebe nome e e-mail
    // Encadeia com o Construtor 3 passando "Não informado" no telefone
    public Cliente(string nome, string email) 
        : this(nome, email, "Não informado")
    {
    }

    // Construtor 3: Construtor completo que efetivamente guarda todos os valores
    public Cliente(string nome, string email, string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
}