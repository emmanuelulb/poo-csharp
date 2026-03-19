using TarefaAdriel.Enums;

namespace TarefaAdriel.Models;

public abstract class Colaborador
{
    public Colaborador(string idUsuario, string nome, DateTime dataNascimento)
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
    public Gerente Superior { get; private set; }

    public abstract CargoEnum Cargo { get; protected set; }
    public List<Tarefa> Tarefas { get; } = [];

    public void AtulizarDadosPessoais(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }

    public void DefinirSuperiorDireto(Colaborador colaborador)
    {
        if (colaborador is not Gerente gerente)
        {
            Console.WriteLine("O colaborador deve ser um gerente para ser definido como superior direto.");
            return;
        }

        Superior = gerente;
    }

    public void AdicionarTarefa(Tarefa tarefa) => Tarefas.Add(tarefa);

    public List<Tarefa> ListarTarefas()
    {
        if (Tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa atribuida a este colaborador.");
            return [];
        }
        return Tarefas;
    }

    public List<Tarefa> ListarTarefas(TarefaStatusEnum status)
    {
        if (Tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa atribuida a este colaborador.");
            return [];
        }

        return Tarefas.Where(t => t.Status == status).ToList();
    }

    public override string ToString()
    {
        return Superior is null
            ? $"Nome: {Nome}, Cargo: {Cargo}"
            : $"Nome: {Nome}, Cargo: {Cargo}, Gestor: {Superior.Nome}";
    }
}
