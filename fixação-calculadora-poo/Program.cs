// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.
// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.


using fixação_calculadora_poo;

bool validar = true;

Calculadora calc = new Calculadora(); //instanciar o objeto

Console.WriteLine($"Insira o primeiro numero");
calc.n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o segundo numero");
calc.n2 = float.Parse(Console.ReadLine()!);

do
{

    Console.WriteLine(@$"

    Menu de opções!

    (1) Soma
    (2) Subtração
    (3) Multiplicação
    (4) Divisão
    (0) Sair

");

    string opcao = Console.ReadLine()!;


    switch (opcao)
    {
        case "1":
            validar = false;
            float resultadoSoma = calc.Somar();
            Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
            break;
        case "2":
            validar = false;
            float resultadoSub = calc.Subtrair();
            Console.WriteLine($"O resultado da subtração é {resultadoSub}");
            break;
        case "3":
            validar = false;
            float resultadoMul = calc.Multiplicar();
            Console.WriteLine($"O resultado da multiplicacao é {resultadoMul}");
            break;
        case "4":
            validar = false;
            float resultadoDiv = calc.Dividir();
            Console.WriteLine($"O resultado da subtração é {resultadoDiv}");
            break;
        case "0":
            validar = false;
            Console.WriteLine($"Programa finalizado!");
            break;
        default:
            validar = true;
            break;
    }

} while (validar == true);


