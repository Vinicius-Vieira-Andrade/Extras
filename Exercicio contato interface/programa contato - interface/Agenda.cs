using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_contato___interface
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            contatos.Add(_contato);
        }

        public void Listar()
        {
            foreach (var item in contatos)
            {
                Console.WriteLine(@$"
                Nome: {item.Nome}
                Telefone: {item.Telefone}
                Email: {item.Email}
                ");
            }
        }
    }
}