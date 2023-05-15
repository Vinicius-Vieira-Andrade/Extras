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
            Cnpj = _cnpj;
            if (Cnpj.Length == 14)
            {
                return true;
            }
        }
    }
}