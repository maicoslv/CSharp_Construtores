namespace Fsg.ProgramacaoOrientadaObjetos;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    // Construtor 1: Recebe apenas titulo e autor
    // Usa o : this(...) para repassar o trabalho ao Construtor 2 com um ano padrão (0)
    public Livro(string titulo, string autor) : this(titulo, autor, 0)
    {
    }

    // Construtor 2: Recebe todos os dados e faz a atribuição de fato
    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}