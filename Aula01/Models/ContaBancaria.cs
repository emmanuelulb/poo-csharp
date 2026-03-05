using Aula01.Enum;

namespace Aula01.Models;

public class ContaBancaria
{
    public ContaBancaria (int codigo, Usuario usuario)
    {
        Codigo = codigo;
        Saldo = 0;
        Usuario = usuario;
    }

    public int Codigo {get; private set;}
    public decimal Saldo {get; private set;} = 0;
    public Usuario Usuario {get;}
    private readonly List<Transacao> _transacoes = new List<Transacao>();

    public void Sacar(decimal valor)
    {
        if(valor > Saldo)
        {
            Console.WriteLine("Saque inválido");
            return;
        }

        Saldo -= valor;
        _transacoes.Add(new Transacao(valor, TipoTransacao.Saque));
    }

    public void Deposito (decimal valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("Depósito inválido");
            return;
        }

        Saldo += valor;
        _transacoes.Add(new Transacao(valor, TipoTransacao.Deposito));
    }

    public string ExibirConta() => $"Usuário: {Usuario.Nome} | Conta: {Codigo} | Saldo: {Saldo:C}";

    public void ImprimirExtrato(TipoTransacao? filtro = null)
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine($"EXTRATO: {Usuario.Nome.ToUpper()} | CONTA: {Codigo}");
        Console.WriteLine("========================================");

        var lista = filtro == null
            ? _transacoes
            : _transacoes.Where(t => t.Tipo == filtro).ToList();

        if(lista.Count == 0)
        {
            Console.WriteLine("Nenhuma movimentação no periodo");
            return;
        }

        foreach (var t in lista)
        {
            string dataFormatada = t.Data.ToString("dd/MM/yyyy  HH:mm");
            Console.WriteLine($"{dataFormatada} | {t.Tipo,-8} | {t.Valor,10:C}");
        }
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"SALDO ATUAL: {Saldo,24:C}");
        Console.WriteLine("========================================\n");
    }
}
