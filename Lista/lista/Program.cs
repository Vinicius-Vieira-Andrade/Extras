using lista;
// criar a lista de objeto(produtos)
List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(123, "vini", 30.90f)
);

produtos.Add(
    new Produto(456, "cius", 44.90f)
);

Console.WriteLine($"");
Console.WriteLine($"Lista antiga");
Console.WriteLine($"*************");


foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:c2}      Indice: {produtos.IndexOf(item)}");
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 123);

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 100.02f;

produtos.RemoveAt(index);

produtos.Insert(index,produtoBuscado);

Console.WriteLine($"");

Console.WriteLine($"Lista atualizada");
Console.WriteLine($"*************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, nome: {item.Nome}, preço: {item.Preco:c2}, {produtos.IndexOf(item)}");
}