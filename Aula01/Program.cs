using Aula01.Models;
using Aula01.Enum;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== INICIANDO TESTES DO SISTEMA BANCÁRIO ===\n");


        Usuario user1 = new Usuario("Gabriel", "123.456.789-00", 998887766, "gabriel@email.com");
        
        ContaBancaria conta1 = new ContaBancaria(1001, user1);

        Console.WriteLine("Teste 1: Criação de conta");
        Console.WriteLine(conta1.ExibirConta());


        Console.WriteLine("\nTeste 2: Depósito de R$ 200 e Saque de R$ 100");
        conta1.Deposito(200);
        conta1.Sacar(100);
        conta1.ImprimirExtrato();

        Console.WriteLine("\nTeste 3: Tentando saque maior que o saldo (R$ 1000)");
        conta1.Sacar(1000);

        Console.WriteLine("\nTeste 4: Tentando depósito negativo");
        conta1.Deposito(-50);

        Console.WriteLine("\nTeste 5: Ver apenas Depósitos");
        conta1.ImprimirExtrato(TipoTransacao.Deposito);

    }
}
