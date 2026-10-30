namespace Fsg.ProgramacaoOrientadaObjetos;

public class ContaBancaria
{
    public string Numero { get; set; }
    public string Titular { get; set; }
    public decimal Saldo { get; set; }

    // Construtor 1: Recebe apenas numero e titular
    // Encadeia com o Construtor 2 repassando o saldoInicial como 0.00m
    public ContaBancaria(string numero, string titular) 
        : this(numero, titular, 0.00m)
    {
    }

    // Construtor 2: Recebe numero, titular e saldoInicial e faz a atribuição
    public ContaBancaria(string numero, string titular, decimal saldoInicial)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldoInicial;
    }
}