using TarefaAdriel.Enum;
using TarefaAdriel.Models;

// Usuario usuario = new Usuario(1, PerfilAcessoEnum.Administrador, "Joao", "joao@email.com", "123456");
// Usuario usuario2 = usuario;

// usuario2.AlterarNome("Maria");

// Console.WriteLine(usuario.Nome);
// Console.WriteLine(usuario2.Nome);

// Console.WriteLine(usuario.ToString());
// Console.WriteLine(usuario2.ToString());

Usuario usuario = new Usuario(1, PerfilAcessoEnum.Administrador, "Joao", "joao@email.com");
usuario.AtualizarSenha("arigato123");
