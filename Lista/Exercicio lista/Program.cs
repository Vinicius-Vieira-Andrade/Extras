using Exercicio_lista;

List<Carro> carros = new List<Carro>();

for (var i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Insira a marca do {i + 1}º carro");
    carro.Modelo = Console.ReadLine()!;

    Console.WriteLine($"Insira a cor do {i + 1}º carro");
    carro.Cor = Console.ReadLine()!;

    carros.Add(carro);
}

foreach (var item in carros)
{
    Console.WriteLine($"O modelo do {carros.IndexOf(item) + 1}º carro é {item.Modelo}");
    Console.WriteLine($"O cor do {carros.IndexOf(item) + 1}º carro é {item.Cor}");
}





