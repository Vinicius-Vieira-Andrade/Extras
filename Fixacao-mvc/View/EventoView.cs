using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fixacao_mvc.Model;

namespace Fixacao_mvc.View
{
    public class EventoView
    {
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();
            Console.WriteLine($"\nInforme o nome do evento: ");
            novoEvento.Nome = Console.ReadLine()!;
            Console.WriteLine($"Descreva o evento: ");
            novoEvento.Descrição = Console.ReadLine()!;
            Console.WriteLine($"Informe a data do evento *EXEMPLO: 00/00/0000: ");
            novoEvento.DataEvento = Console.ReadLine()!;

            return novoEvento;
        }

        public void Listar(List<Evento> _evento)
        {
            foreach (var item in _evento)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Descrição: {item.Descrição}");
                Console.WriteLine($"Data do evento: {item.DataEvento}");


            }
        }
    }
}