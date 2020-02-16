using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slaBicho
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(1535, "Daniel");
            Professor p1 = new Professor();
            p1.Nome = "Ana";

            verNome(a1);
            verNome(p1);

            Console.ReadLine();

        }

        private  static void verNome(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.Nome);
        }
    }
}
