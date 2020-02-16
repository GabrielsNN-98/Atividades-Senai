using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVeterinaria
{
    class Veterinario : SerVivo
    {
        public int Registro { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        public DateTime DtNasc { get; set; }

    }
}
