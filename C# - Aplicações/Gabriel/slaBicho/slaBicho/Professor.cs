using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slaBicho
{
    class Professor:Pessoa
    {
        public float Salario { get; set; }
        public String Formacao { get; set; }

        public void confundirAlunos()
        {
            Console.WriteLine("DONE!");
        }

    }
}
