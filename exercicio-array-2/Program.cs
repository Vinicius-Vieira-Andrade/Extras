// array com 6 numeros
// imprimir e exibir quantos numeros sao impares e quantos pares

int[] numeros = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Insira um numero: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int numeroPar = 0;
int numeroImpar = 0;

for (int i = 0; i < 6; i++)
{
    if (numeros[i] % 2 == 0)
    {
        numeroPar++;  
    }

    else{
        numeroImpar++;
    }
}

Console.WriteLine($"Existem {numeroPar} numeros pares e {numeroImpar} impares.");
