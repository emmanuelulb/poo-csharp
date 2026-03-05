using System.Drawing;

namespace Aula02.Models;

public class CarrinhoCompra
{
    public CarrinhoCompra()
    {
        ValorTotal = 0;
        QuantidadeTotal = 0;
    }
    public static decimal ValorTotal { get; private set; }
    public static int QuantidadeTotal {get ; private set; }
    private readonly List<Produto> produtosCarrinho =  [];

    public void adicionarProduto(Produto produto)
    {
        produtosCarrinho.Add(produto);
        ValorTotal += produto.Preco;
    }

    public void ExibirCarrinho()
    {
        Console.WriteLine($"Valor total do carrinho: {ValorTotal:C} ");
        foreach (Produto produto in produtosCarrinho)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preco: {produto.Preco:C}");
            Console.WriteLine($"Validade: {produto.DataValidade}");
        }
    }
}
