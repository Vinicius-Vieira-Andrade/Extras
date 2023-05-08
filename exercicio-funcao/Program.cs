// criar funcao
// ela devera multiplicar 2 numeros, a outra dividir e a outra subtrair
// dps devo chama-la e imprimir

static float Dividir(float n1, float n2)
{
    return n1 / n2;
}

//Chamada dos numeros
Console.WriteLine($"Esta conta será de divisão!");

Console.WriteLine($"Insira o primeiro");
float n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo");
float n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"A divisão dará: {Dividir(n1, n2)}");


static float Multiplicar(float n1, float n2)
{
    return n1 * n2;
}

//Chamada dos numeros
Console.WriteLine($"Esta conta será de multiplicação!");


Console.WriteLine($"Insira o primeiro");
float numero1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo");
float numero2 = int.Parse(Console.ReadLine());


Console.WriteLine($"A multiplicação dará: {Multiplicar(numero1, numero2)}");



static float Subtrair(float n1, float n2)
{
    return n1 - n2;
}

//Chamada dos numeros
Console.WriteLine($"Esta conta será de subtração!");


Console.WriteLine($"Insira o primeiro");
float nuumero1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo");
float nuumero2 = int.Parse(Console.ReadLine());


Console.WriteLine($"A subtração dará: {Subtrair(nuumero1, nuumero2)}");