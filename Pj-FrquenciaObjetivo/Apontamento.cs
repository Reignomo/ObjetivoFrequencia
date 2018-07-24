using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj_FrquenciaObjetivo
{
    class Apontamento
    {
        private string status;
        private string dia;
        private string mes;
        private string ano;
        private string hora;
        private string minuto;
        private string segundo;
        private string matricula_aluno;
        private string tipo;

        public Apontamento(string matri, string s, string d, string m,string a,string h,string min,string seg, string tipo)
        {
            this.matricula_aluno = matri;
            this.status = s;
            this.dia = d;
            this.mes = m;
            this.ano = a;
            this.hora = h;
            this.minuto = min;
            this.Segundo = seg;           
            this.tipo = tipo;

        }

        public string Status { get => status; set => status = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Mes { get => mes; set => mes = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Minuto { get => minuto; set => minuto = value; }
        public string Segundo { get => segundo; set => segundo = value; }
        public string Matricula_aluno { get => matricula_aluno; set => matricula_aluno = value; }
        public string Tipo { get => tipo; set => tipo = value; }


       
    }
}
