using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj_FrquenciaObjetivo
{
   public  class Aluno
    {
        private string Matricula;
        private string Nome;
        private string Status;

        public string Matricula1 { get => Matricula; set => Matricula = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Status1 { get => Status; set => Status = value; }

        public Aluno(string matricula,string nome)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Status = "ATIVO";
        }
    }
}
