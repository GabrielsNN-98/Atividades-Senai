using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFaculdade
{
    class Professor : Pessoa, ICadastro
    {
        public int Registro { get; set; }
        public String GrauFoma { get; set; }
        public int Id { get; set; }

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
