//Instância do objet carrinho
using Projeto_Produto_Interface;

Carrinho carrinho = new Carrinho();

//instanciar objeto(os) da classe Produto
Produto p1 = new Produto(1, "GTA 5", 52.15f);
Produto p2 = new Produto(2, "Fifa 23", 90.15f);
Produto p3 = new Produto(3, "Call Of Duty MWII", 299.15f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Após a remoção de um item ficará assim: ");

carrinho.Remover(p2);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

//criar um objeto com os dados atualizados

Produto _novoProduto = new Produto();
_novoProduto.Nome = "GTA VI";
_novoProduto.Preco = 600f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();