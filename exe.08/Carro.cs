namespace Fsg.ProgramacaoOrientadaObjetos;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; } = string.Empty; // Define valor padrão inicial para evitar o aviso CS8618

    // Construtor que recebe marca, modelo e ano
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}