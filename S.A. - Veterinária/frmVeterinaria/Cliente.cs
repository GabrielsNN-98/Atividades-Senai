using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVeterinaria
{
    class Cliente : SerVivo
    {
        String Endereco { get; set; }
        String Cpf { get; set; }
        String Telefone { get; set; }
        DateTime DtNasc { get; set; }

    }
}
