using Aula01.Enum;

namespace Aula01.Models;

public class Transacao
{
    public DateTime Data {get; private set;}
    public decimal Valor {get; private set;}
    public TipoTransacao Tipo {get; private set;}

    public Transacao(decimal valor, TipoTransacao tipo)
    {
        Data = DateTime.Now;
        Valor = valor;
        Tipo = tipo;
    }
}