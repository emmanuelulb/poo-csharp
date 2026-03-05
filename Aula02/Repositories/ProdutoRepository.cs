using Aula02.Models;

namespace Aula02.Repository;

public class ProdutoRepository
{
    private readonly List<Produto> produtos = [];

    public void Adicionar(Produto produto)
    {
        produtos.Add(produto);
    }

    public void Remover(string nome)
    {
        var produto = produtos.FirstOrDefault(x => x.Nome == nome);
        
        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado");
            return;
        }

        produtos.Remove(produto);
    }

    public Produto RetornarProdutoPorNome(string nome)
    {
        var produto = produtos.FirstOrDefault(x => x.Nome == nome);
        return produto;
    }

    public List<Produto> RetornarProdutos()
    {
        return produtos;
    }
}
