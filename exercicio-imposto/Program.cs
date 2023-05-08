// entrar com o salario

// criar uma funcao q fará os calculos

//ate 1500 - isento

// de 1501 ate 3500 terá 20% de imposto de renda

// de 3501 até 6000 terá 25% de imposto de renda

// acima de 6000 terá 35% de imposto

//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda



using System.Globalization;

static float Imposto(float salario)
{

    if (salario < 1501 && salario > 0)
    {
        return 0;
    }

    else if (salario > 1500 && salario < 3501)
    {
        return (salario * 20) / 100;
    }

    else if (salario > 3500 && salario < 6001)
    {
        return (salario * 25) / 100;
    }

    else
    {
        return (salario * 35) / 100;
    }
}
Console.WriteLine($"Insira seu salário");
float salario = float.Parse(Console.ReadLine());

float resultado = Imposto(salario);



Console.WriteLine($"O imposto a ser pago é {resultado.ToString("C", new CultureInfo("pt-BR"))}");







