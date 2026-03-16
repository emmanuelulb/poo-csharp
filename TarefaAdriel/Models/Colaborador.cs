using System.Threading.Channels;
using TarefaAdriel.Enum;

namespace TarefaAdriel.Models;

public abstract class Colaborador
{
    public Colaborador (string idUsuario, string nome, DateTime dataNascimento)
    {
        Id = Guid.NewGuid().ToString();
        IdUsuario = idUsuario;
        Nome = nome;
        DataNascimento = dataNascimento;
    }

    public string Id { get; }
    public string IdUsuario { get; }
    public string Nome { get; private set; } 
    public DateTime DataNascimento { get; private set; }
    public string IdSuperior { get; private set; }
    
    public abstract CargoEnum Cargo { get; }

    public void DefinirSuperiorDireto (string idSuperior) => IdSuperior = idSuperior;

    public string ObterCodigoGestorResponsavelFormatado() => IdSuperior.Substring(1, 7);

    public void AtulizarDadosPessoais(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }
}
