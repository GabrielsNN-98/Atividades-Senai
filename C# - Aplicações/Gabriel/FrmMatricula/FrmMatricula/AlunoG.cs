using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMatricula
{
    class AlunoG : Aluno, IAluno
    {
        String Curso { get; set; }
        float Mensalidade { get; set; }

        public AlunoG(int Matricula)
        {
            this.Matricula = Matricula;
        }

        public AlunoG(int Matricula, String Nome)
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
