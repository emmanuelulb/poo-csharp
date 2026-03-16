using TarefaAdriel.Enum;

namespace TarefaAdriel.Models;

public class Usuario
{
    public Usuario(PerfilAcessoEnum perfilAcesso,string nome, string email, DateTime dataNascimento)
    {
        Id = Guid.NewGuid().ToString();
        PerfilAcesso = perfilAcesso;
        Email = email;
        Senha = GerarSenhaAleatoria();
        Colaborador = new Colaborador(idUsuario: Id, nome, dataNascimento);
    }

    public string Id { get; } 
    public PerfilAcessoEnum PerfilAcesso {get;}
   
    public string Email { get; private set; }
    public string Senha { get; private set; }

    public Colaborador Colaborador { get; private set; }

    public void AlterarDadosCadastrais(string nome, DateTime dataNascimento, string email)
    {
        Email = email;
        Colaborador.AtulizarDadosPessoais(nome, dataNascimento);
    }
    
    public void AtualizarSenha(string novaSenha)
    {
        if (string.IsNullOrEmpty(novaSenha) || novaSenha.Length < 6)
        {
            Console.Error.WriteLine("A senha deve conter pelo menos 6 caracteres");
            return;
        }
        
        Senha = novaSenha;
    }

    public void DefinirSuperiorDiretoDoColaborador(Colaborador colaborador) => Colaborador.DefinirSuperiorDireto(colaborador.Id);

    public override string ToString()
    {
        string textoApresentacao = string.IsNullOrEmpty(Colaborador.IdSuperior) 
            ? $"Nome: {Colaborador.Nome} | Email: {Email}"
            : $"Nome: {Colaborador.Nome} | Email: {Email} | Código do Gestor: {Colaborador.ObterCodigoGestorResponsavelFormatado()}";
        
        return textoApresentacao;
    }   

    private string GerarSenhaAleatoria() => Guid.NewGuid().ToString().Substring(1,7);

}
