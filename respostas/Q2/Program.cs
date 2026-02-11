using Q2.Models;

// Contato contato1 = new Contato();
// Contato contato2 = new Contato("Maria", "11999998888", "maria@email.com");

// contato1.ExibirContato();
// contato2.ExibirContato();


Pedido pedido1 = new Pedido("João", 150.00m);
Pedido pedido2 = new Pedido("Maria", 250.00m);
Pedido pedido3 = new Pedido("Ana", 99.90m);

pedido1.ExibirPedido();
pedido2.ExibirPedido();
pedido3.ExibirPedido();
Pedido.ExibirResumo();