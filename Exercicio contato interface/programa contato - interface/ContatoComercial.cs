using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_contato___interface
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj { get; set; }

        public bool ValidarCnpj(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}