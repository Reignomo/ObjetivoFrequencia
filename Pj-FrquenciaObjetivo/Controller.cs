using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj_FrquenciaObjetivo
{
    class Controller
    {
        private static List<Apontamento> L_apontamento = new List<Apontamento>();
        private static List<Apontamento> L_execoes = new List<Apontamento>();


        internal static List<Apontamento> L_apontamento1 { get => L_apontamento; set => L_apontamento = value; }
        internal static List<Apontamento> L_execoes1 { get => L_execoes; set => L_execoes = value; }

        public static void CarregaApontamentos(Apontamento Aponta)
        {

            L_apontamento1.Add(Aponta);


        }

        public static int TrataEx()
        {
          
            bool achou =false;
            int contador=0;
            int total = Controller.L_apontamento1.Count()-1;

            foreach (Apontamento ap in L_apontamento1)
            {


                foreach (Apontamento ap2 in L_apontamento1)
                {
                    achou = false;



                    if (ap.Mes.Equals(ap2.Mes) && ap.Dia.Equals(ap2.Dia) && ap.Matricula_aluno.Equals(ap2.Matricula_aluno) && ap.Status == "Entrada" && ap2.Status == "Saida")
                    {


                       
                        achou=true;
                        contador = 0;
                        break;



                    }

                    if (ap.Mes.Equals(ap2.Mes) && ap.Dia.Equals(ap2.Dia) && ap.Matricula_aluno.Equals(ap2.Matricula_aluno) && ap.Status == "Saida" && ap2.Status == "Entrada")
                    {



                        achou = true;
                        contador = 0;
                        break;



                    }
                    else if (achou==false && total==contador)
                    {
                       
                        L_execoes.Add(ap);
                        L_execoes.Count();
                        achou = false;
                        contador = 0;
                        break;
                    }
                    contador++;




                }


            }
            return L_execoes.Count();
        }





        public static int GetQtEntrada()
        {
            int entrada = 0;
            foreach (Apontamento ap in L_apontamento1)
            {


                foreach (Apontamento ap2 in L_apontamento1)
                {
                    if (ap.Status == "Entrada")
                    {

                        entrada++;
                        break;

                    }
                }


            }
            return entrada;
        }



        public static int GetqtSaida()
        {
            int saida = 0;
            foreach (Apontamento ap in L_apontamento1)
            {

                foreach (Apontamento ap2 in L_apontamento1)
                {
                    if (ap.Status == "Saida")
                    {

                        saida++;
                        break;

                    }
                }

            }
            return saida;

        }

       





    }


}
