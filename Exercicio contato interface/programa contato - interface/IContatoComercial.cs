using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_contato___interface
{
    public interface IContatoComercial
    {
        bool ValidarCnpj(string _cnpj);
    }
}