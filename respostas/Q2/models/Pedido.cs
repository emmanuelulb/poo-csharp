namespace Q2.Models;

class Pedido
{
    private static int _contadorPedidos = 0;  
    public int NumeroPedido {get;}
    public string NomeCliente {get; set;}
    public decimal ValorTotal {get; set;}

    public static int TotalPedidos
    {
        get { return _contadorPedidos; }
    }

    public Pedido(string nomeCliente, decimal valorTotal)
    {
        _contadorPedidos++;
        NumeroPedido = _contadorPedidos;
        NomeCliente = nomeCliente;
        ValorTotal = valorTotal;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido Nº: {NumeroPedido} | Cliente: {NomeCliente} | Valor Total: R$ {ValorTotal}");
    }

    public static void ExibirResumo()
    {
        Console.WriteLine($"Total de Pedidos Criados: {TotalPedidos}");
    }
}
