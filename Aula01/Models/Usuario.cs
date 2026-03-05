namespace Aula01.Models;

public class Usuario
{
    public Usuario (string nome, string cpf, int telefone, string email)
    {
        ValidarNome(nome);
        ValidarTelefone(telefone);
        ValidarEmail(email);
        Cpf = cpf;
    }

    public string Nome {get; private set;}
    public string Cpf {get; private set;}
    public int Telefone {get; private set;}
    public string Email {get; private set;}

    public void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido");
            return;
        }
        Nome = nome;
    }

    public void ValidarTelefone(int telefone)
    {
        if (telefone <= 00000000000)
        {
            Console.WriteLine("Telefone inválido");
            return;
        }
        Telefone = telefone;
    } 
    
    public void ValidarEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
        {
            Console.WriteLine("Email inválido");
            return;
        }
        Email = email;
    }    
}
