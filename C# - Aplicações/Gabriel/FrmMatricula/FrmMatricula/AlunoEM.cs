using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMatricula
{
    class AlunoEM : Aluno, IAluno
    {
        String tipo { get; set; }

        public AlunoEM(int Matricula)
        {
            this.Matricula = Matricula;
        }

        public AlunoEM(int Matricula, String Nome)
        {
            this.Matricula = Matricula;
            this.Nome = Nome;
        }
        
        public float calcularMedia()
        {
            return (this.Nota1 + this.Nota2 + this.Nota3 + this.Nota4);
        }

        public String statusAluno(float media)
        {
            if (media >= 6)
            {
                return "Aprovado";
            }
            else if (media >= 4)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
