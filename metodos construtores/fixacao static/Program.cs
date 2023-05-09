// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)
using System.Globalization;
using fixacao_static;
voltaMenu:
check:
Console.WriteLine(@$"

            Menu opções conversor

[1] Dolar para Real

[2] Real para Dolar

[0] Sair

");
string resposta = Console.ReadLine()!;

switch (resposta)
{
    case "1":
        float resultado = ConvertorMoedas.DolarParaReal(ConvertorMoedas.Valor);
        Console.WriteLine($"O valor equivalente em real é de {resultado.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        goto check;
    case "2":
        float resultado2 = ConvertorMoedas.RealparaDolar(ConvertorMoedas.Valor);
        Console.WriteLine($"O valor equivalente em real é de {resultado2.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
        goto check;
    case "0":
        Console.WriteLine($"Saindo do programa!");
        break;
    default:
        Console.WriteLine($"Opção inválida, tente novamente! risos risos");
        goto voltaMenu;
}
