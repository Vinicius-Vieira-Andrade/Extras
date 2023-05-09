using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fixacao_static
{
    public static class ConvertorMoedas
    {
        public static float Valor { get; set; }
        public static float DolarParaReal(float Valor)
        {
            Console.WriteLine($"Qual valor em dólar voce deseja converter para real?");
            Valor = float.Parse(Console.ReadLine()!);

            return Valor / 0.20f;
        }

        //saber tantos reais em dolar resultado final dolar
        public static float RealparaDolar(float Valor)
        {
            Console.WriteLine($"Qual valor em real você deseja converter para dólar?");
            Valor = float.Parse(Console.ReadLine()!);
            return  Valor / 4.99f;
        }
    }
}