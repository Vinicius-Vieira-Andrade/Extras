using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public interface ICarrinho
    {
        //Regras do "CONTRATO"
        //Métodos que deverão aqui ser apenas declarados

        //GRUD : Create, Read, Update, Delete

        //Padrão de chamada de método
        //Tipo Nome(parâmetros)

        //Create
        void Adicionar(Produto _produto);

        //Read
        void Listar();

        //Update
        void Atualizar(int _codigo, Produto _produto);

        //Delete
        void Remover(Produto _produto);

    }
}