using System.ComponentModel;

namespace TarefaAdriel.Enums;

public enum TarefaStatusEnum
{
    [Description("Cadastrada")]
    Cadastrada = 1,
    [Description("Em Andamento")]
    EmAndamento = 2,
    [Description("Concluída")]
    Concluida = 3,
}

