// // Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// // Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los

int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Insira o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}


foreach (int item in numeros)
{
    Console.WriteLine($" o dobro do {item} é: {item * 2} ");
}