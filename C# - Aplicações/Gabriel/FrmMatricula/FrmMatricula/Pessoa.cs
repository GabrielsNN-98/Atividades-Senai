using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMatricula
{
    abstract class Pessoa
    {
        public String Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public double Cpf { get; set; }
    }
}
