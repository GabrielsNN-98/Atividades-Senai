using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMatricula
{
    interface IAluno
    {
        float calcularMedia();
        String statusAluno(float media);
    }
}
