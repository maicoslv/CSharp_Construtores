namespace Fsg.ProgramacaoOrientadaObjetos;

public class Pedido
{
    public int Numero { get; set; }
    public string Cliente { get; set; }
    public decimal ValorProdutos { get; set; }
    public decimal ValorFrete { get; set; }

    // Construtor 1: Quando o frete é gratuito (assume frete zero)
    // Encadeia com o Construtor 2 passando 0.00m no frete
    public Pedido(int numero, string cliente, decimal valorProdutos)
        : this(numero, cliente, valorProdutos, 0.00m)
    {
    }

    // Construtor 2: Construtor completo que inicializa todos os campos
    public Pedido(int numero, string cliente, decimal valorProdutos, decimal valorFrete)
    {
        Numero = numero;
        Cliente = cliente;
        ValorProdutos = valorProdutos;
        ValorFrete = valorFrete;
    }

    // Propriedade calculada para facilitar a visualização do valor total
    public decimal ValorTotal => ValorProdutos + ValorFrete;
}