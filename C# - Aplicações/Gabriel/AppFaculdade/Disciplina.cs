using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFaculdade
{
    class Disciplina : ICadastro
    {
        public String Nome { get; set; }
        public int CargaHoraria { get; set; }
        public static List<Professor> ListProfessor { get; set; } = new List<Professor>();

        public String NomeProfessor { get; set; }

        public int IdProfessor { get; set; }

        public void cadastrar()
        {
            throw new NotImplementedException();
        }

        public bool validarDados()
        {
            throw new NotImplementedException();
        }

        public void lerDados()
        {
            throw new NotImplementedException();
        }

        public void excluir()
        {
            throw new NotImplementedException();
        }
    }
}
