using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFaculdade
{
    class Aluno : Pessoa, ICadastro
    {
        public int Ra { get; set; }
        public DateTime DtMatr { get; set; }

        public void cadastrar()
        {
            throw new NotImplementedException();
        }

        public void excluir()
        {
            throw new NotImplementedException();
        }

        public void lerDados()
        {
            throw new NotImplementedException();
        }

        public bool validarDados()
        {
            throw new NotImplementedException();
        }
    }
}
