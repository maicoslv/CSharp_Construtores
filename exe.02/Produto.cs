namespace Fsg.ProgramacaoOrientadaObjetos;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    // 1. Construtor sem parâmetros (Porta Simples)
    public Produto()
    {
    }

    // 2. Construtor com nome e preco (Porta Completa)
    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}