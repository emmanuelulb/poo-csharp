namespace TarefaAdriel.Models;
using TarefaAdriel.Enums;
using TarefaAdriel.Helpers;

public class Tarefa
{
    public Tarefa(string titulo, string descricao, TipoTarefaEnum tipo)
    {
        Id = Guid.NewGuid().ToString();
        Titulo = titulo;
        Descricao = descricao;
        Tipo = tipo;
        DataCriacao = DateTime.Today;
        Status = TarefaStatusEnum.Cadastrada;
    }
    public string Id { get;  }
    public string Titulo { get;  }
    public TarefaStatusEnum Status { get; private set; }
    public string Descricao { get;  }
    public TipoTarefaEnum Tipo { get;  }
    public DateTime DataCriacao { get;  }
    public DateTime DataFinalizacao { get; private set;}

    public void Concluir()
    {
        Status = TarefaStatusEnum.Concluida;
        DataFinalizacao = DateTime.Now;
    }
    public override string ToString() => $"Título: {Titulo} | Descrição: {Descricao} | Tipo: {Tipo} | Data de criação: {DataCriacao} | Concluída: {Status.GetEnumDescription()}";
    
}

