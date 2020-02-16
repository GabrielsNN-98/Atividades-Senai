using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slaBicho
{
    class Aluno : Pessoa
    {
        public int Ra { get; private set; }
        public DateTime DataMatricula { get; set; }
        public Boolean Status { get; set; }
        public static int BolsaIC { get; set; }

        public Aluno(int Ra)
        {
            this.Ra = Ra;
        }

        public Aluno(int Ra, String Nome)
        {
            this.Ra = Ra;
            this.Nome = Nome;
        }

        public void estudar()
        {
            Console.WriteLine(Nome+" estudando...");
        }

        public void cancelarMatricula()
        {
                if (estaMatriculado())
            {
                Console.WriteLine(Nome + " cancelado!...");
            }
                else
            {
                Console.WriteLine("Já está cancelado!");
            }
        }

        public void verificarPendencias()
        {
            Console.WriteLine(Nome + " verificado!...");
        }

        private Boolean estaMatriculado()
        {
            return this.Status;
        }

        public static void aumentarBolsa(int valor)
        {
            BolsaIC = valor;
        }
    }
}
