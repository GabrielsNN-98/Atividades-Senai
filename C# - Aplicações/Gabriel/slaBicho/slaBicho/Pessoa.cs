using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slaBicho
{
    class Pessoa
    {
        public String Nome { get; set; }
        public DateTime DataNasc { get; set; }

        public void andar()
        {
            Console.WriteLine(Nome + " andando...");
        }

        public void falar()
        {
            Console.WriteLine(Nome + " falar...");
        }
    }
}
