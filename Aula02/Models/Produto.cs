using Aula02.Enum;

namespace Aula02.Models;

public class Produto
{
    public Produto(string nome, decimal preco, DateTime dataValidade, CategoriaProduto tipo)
    {
        Nome = nome;
        Preco = preco;
        DataValidade = dataValidade;
        Tipo = tipo;

    }
    public string Nome {get; private set; }
    public decimal Preco {get; private set; }
    public DateTime DataValidade {get; private set; }
    public CategoriaProduto Tipo {get; private set; }

    public void AlterarPreco(decimal preco)
    {
        if(preco <= 0)
        {
            Console.WriteLine("Preço inválido. Digite um preço real.");
            return;
        }
        Preco = preco;
    }
}
