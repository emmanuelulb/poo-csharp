namespace Aula02.Models;

public class Usuario
{
    public Usuario(string nome, string cpf, DateTime dataNascimento, string email, CarrinhoCompra carrinho)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Email = email;
        CarrinhoCompra = carrinho;
        
    }
    public string Nome { get; private set; }
    public string Cpf { get; }
    public DateTime DataNascimento { get; }
    public string Email { get; private set; }
    public CarrinhoCompra CarrinhoCompra { get; private set; }


    public void AlterarNome(string nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome digitado inválido");
            return;
        }

        Nome = nome;
        Console.WriteLine("Nome alterado com sucesso");
    }
}
