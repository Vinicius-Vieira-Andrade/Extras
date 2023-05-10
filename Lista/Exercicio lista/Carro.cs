using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_lista
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public Carro()
        {
        }

        public Carro(string modelo, string cor)
        {
            Modelo = modelo;

            Cor = cor;
        }
    }
}