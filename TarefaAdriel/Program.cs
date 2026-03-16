using TarefaAdriel.Enum;
using TarefaAdriel.Models;

// Usuario usuario = new Usuario(1, PerfilAcessoEnum.Administrador, "Joao", "joao@email.com", "123456");
// Usuario usuario2 = usuario;

// usuario2.AlterarNome("Maria");

// Console.WriteLine(usuario.Nome);
// Console.WriteLine(usuario2.Nome);

// Console.WriteLine(usuario.ToString());
// Console.WriteLine(usuario2.ToString());

//Usuario usuario = new Usuario( PerfilAcessoEnum.Funcionario, "Joao", "joao@email.com");
//Usuario usuario2 = new Usuario(PerfilAcessoEnum.Funcionario, "Maria", "maria@email.com");
//usuario.AtualizarSenha("arigato123");

//usuario.AlterarDadosCadastrais("Maria", new DateTime(1990, 5, 20), "maria@email.com");
//usuario2.AlterarDadosCadastrais(new DateTime(1995, 5, 20), "maria@email.com.br");

//Segunda aula 31min
Usuario usuarioGestor = new Usuario(PerfilAcessoEnum.Funcionario, "Arthur lanches", "arthur@lanches.com");
Usuario usuarioSubordinado = new Usuario(PerfilAcessoEnum.Funcionario, "Joao", "joao@email.com");

usuarioSubordinado.DefinirSuperiorDiretoDoColaborador(usuarioGestor.Id);
Console.WriteLine(usuarioGestor);
Console.WriteLine(usuarioSubordinado);



