namespace Fsg.ProgramacaoOrientadaObjetos;

public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    // Construtor obrigatório recebendo largura e altura
    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    // Método para calcular a área (Largura * Altura)
    public double CalcularArea()
    {
        return Largura * Altura;
    }
}