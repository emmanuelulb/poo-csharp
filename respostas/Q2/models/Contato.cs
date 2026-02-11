namespace Q2.Models;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato()
    {
        Nome = "Sem nome";
        Telefone = "000000000";
        Email = "sem@email.com";
    }

    public  Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public void ExibirContato()
    {
        Console.WriteLine($"Nome: {Nome} | Telefone: {Telefone} | Email: {Email}");
    }
}