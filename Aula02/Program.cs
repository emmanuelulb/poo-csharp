using Aula02.Enum;
using Aula02.Models;
using Aula02.Repository;

ProdutoRepository produtoRepository = new ProdutoRepository();

Produto produto = new Produto("Banana", 20m, new DateTime(2020,12,20),CategoriaProduto.Fruta);
Produto produto2 = new Produto("Pepino", 20m, new DateTime(2020,12,20),CategoriaProduto.Fruta);
CarrinhoCompra carrinho= new CarrinhoCompra();
Usuario usuario = new Usuario("Vinicius", "2469",new DateTime(2009,12,24), "ViniciusUchiha@gmail.com", carrinho);

produtoRepository.Adicionar(produto);
produtoRepository.Adicionar(produto2);

var produtoBanana = produtoRepository.RetornarProdutoPorNome("Banana");
var produtoPepino = produtoRepository.RetornarProdutoPorNome("Pepino");

usuario.CarrinhoCompra.adicionarProduto(produtoBanana);
usuario.CarrinhoCompra.adicionarProduto(produtoPepino);

usuario.CarrinhoCompra.ExibirCarrinho();

