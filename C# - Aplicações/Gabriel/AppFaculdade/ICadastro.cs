using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFaculdade
{
    interface ICadastro
    {
        void cadastrar();
        Boolean validarDados();
        void lerDados();
        void excluir();

    }
}
