namespace Q1.Models;

class Produto
{
    private string _nome;
    private decimal _preco;
    private int _quantidade;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public decimal Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }

    public int AdicionarEstoque(int quantidade)
    {
        Quantidade += quantidade;
        Console.WriteLine($"{quantidade} unidades adicionadas ao estoque.");
        return quantidade;
    }

    public int RemoverEstoque(int quantidade)
    {
        Quantidade -= quantidade;
        if (Quantidade < 0)
        {

            ArgumentException aviso = new ArgumentException("A quantidade em estoque não pode ser negativa.");
            Console.WriteLine(aviso.Message);
            Quantidade += quantidade;
            return 0;
        }
        if (quantidade <= 0)
        {
            ArgumentException aviso = new ArgumentException("A quantidade a ser removida deve ser maior que zero.");
            Console.WriteLine(aviso.Message);
            Quantidade += quantidade;
            return 0;
        }
        Console.WriteLine($"{quantidade} unidades removidas do estoque.");
        return quantidade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: R${Preco} | Quantidade em estoque: {Quantidade}");
    }
}