using Q1.Models;

// Aluno aluno1 = new Aluno();
// aluno1.Nome = "Ana Clara";
// aluno1.Idade = 16;
// aluno1.Turma = "3A";
// aluno1.ApresentarSe();



// Produto produto = new Produto();
// produto.Nome = "Caneta";
// produto.Preco = 2.50m;
// produto.Quantidade = 100;
// produto.ExibirInfo();
// produto.RemoverEstoque(-5);
// produto.AdicionarEstoque(10);
// produto.ExibirInfo();




Veiculo veiculo = new Veiculo();

veiculo.Marca = "Toyota";
veiculo.Modelo = "Corolla";
veiculo.Ano = 2023;

veiculo.Acelerar(80);
Console.WriteLine(veiculo.EstaEmMovimento());
veiculo.ObterFichaTecnica();

veiculo.Frear(80);
Console.WriteLine(veiculo.EstaEmMovimento());