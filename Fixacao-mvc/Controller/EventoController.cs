using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fixacao_mvc.Model;
using Fixacao_mvc.View;

namespace Fixacao_mvc.Controller
{
    public class EventoController
    {
        //instancia classes da view e model
        Evento evento = new Evento();
        EventoView eventView = new EventoView();

        //metodo no controller para acessar funcoes
        public void ListarEventos()
        {
            List<Evento> eventos = evento.Ler();
            eventView.Listar(eventos);
        }

        public void CadastrarEventos()
        {
            Evento novoEvento = eventView.Cadastrar(); 
            evento.Inserir(novoEvento);
        }

    }
}