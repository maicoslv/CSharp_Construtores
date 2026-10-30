using System;
using Fsg.ProgramacaoOrientadaObjetos;

namespace Fsg.ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1: Sem frete (assume R$ 0,00 via encadeamento)
        Pedido pedido1 = new Pedido(101, "Maicon", 150.00m);

        // Pedido 2: Com frete informado
        Pedido pedido2 = new Pedido(102, "Ana", 200.00m, 15.50m);

        // Exibindo no console
        Console.WriteLine("=== PEDIDOS REALIZADOS ===");
        Console.WriteLine($"Pedido #{pedido1.Numero} | Cliente: {pedido1.Cliente}");
        Console.WriteLine($"Produtos: R$ {pedido1.ValorProdutos:F2} | Frete: R$ {pedido1.ValorFrete:F2} | Total: R$ {pedido1.ValorTotal:F2}\n");

        Console.WriteLine($"Pedido #{pedido2.Numero} | Cliente: {pedido2.Cliente}");
        Console.WriteLine($"Produtos: R$ {pedido2.ValorProdutos:F2} | Frete: R$ {pedido2.ValorFrete:F2} | Total: R$ {pedido2.ValorTotal:F2}");
    }
}