using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO; //declarando a biblioteca de entrada e saída de arquivos
                 //a biblioteca IO

namespace Pj_FrquenciaObjetivo
{
    public partial class TratarDados : MetroFramework.Forms.MetroForm
    {
        public TratarDados()
        {
            InitializeComponent();
        }

        private void TratarDados_Load(object sender, EventArgs e)
        {
            try
            {
                int qtMaxima = 0;
                int Coutap = 0;


                //declarando a variavel do tipo StreamWriter 
                StreamReader x;

                //Colocando o caminho fisico 
                string Caminho = tb_caminho.Text;

                //abrindo um arquivo texto
                x = File.OpenText(Caminho);
                while (x.EndOfStream != true)//quer dizer que não chegou no fim do  
                                             //arquivo
                {
                    string linha2 = x.ReadLine();

                    if (linha2 == "")
                    {
                        x.Close();
                        break;

                    }
                    qtMaxima++;

                }
                string[,,] TodosApontamento = new string[12, 31, qtMaxima];

                x = File.OpenText(Caminho);
                string recuperaDia = "", recuperaMes = "";

                if (Controller.L_execoes1.Count() == 0 && Controller.L_apontamento1.Count() == 0)
                {

                    //enquanto nao retornar valor booleano true 
                    while (x.EndOfStream != true)//quer dizer que não chegou no fim do  
                                             //arquivo
                {

                    //le conteúdo da linha
                    string linha = x.ReadLine();


                    //escreve na tela o conteúdo da linha
                    // Aqui eu devo salvar o texto em pedaços para
                    // que eu possa criar o obj apontamento
                    string status = linha.Substring(0, 2);
                    string dia = linha.Substring(2, 2);
                    string mes = linha.Substring(4, 2);
                    string ano = linha.Substring(6, 4);
                    string hora = linha.Substring(10, 2);
                    string minuto = linha.Substring(12, 2);
                    string segundo = linha.Substring(14, 2);
                    string matricula = linha.Substring(16, 5);

                    if (recuperaMes == mes && recuperaDia == dia)
                    {
                        Coutap = 0;
                    }
                    while (TodosApontamento[int.Parse(mes), int.Parse(dia), Coutap] != null)
                    {
                        Coutap++;
                    }
                    TodosApontamento[int.Parse(mes), int.Parse(dia), Coutap] = linha;
                    Apontamento apm = new Apontamento(status, dia, mes, ano, hora, minuto, segundo, matricula);
                   
                        Controller.CarregaApontamentos(apm);
                       


                        //  MessageBox.Show("Mes: "+int.Parse(mes)+" - Dia: "+ int.Parse(dia) + " - Arrey : "+Coutap +" - Conteudo: "+ TodosApontamento[int.Parse(mes), int.Parse(dia), Coutap]) ;
                        Coutap++;
                        recuperaDia = dia;
                        recuperaMes = mes;
                    }

                    //após sair do while, é porque leu todo o conteúdo, então
                    //temos que fechar o arquivo texto que está aberto
                    Controller.TrataEx();
                    x.Close();
                }
            }

            catch (Exception)
            {


                MetroMessageBox.Show(this, "Erro ao tentar adicionar na lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

     

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

           
            
            
            grid.DataSource = Controller.L_execoes1;
            tb_qtex.Text =Convert.ToString(Controller.L_execoes1.Count());
            tb_qtEntrada.Text = Convert.ToString(Controller.GetQtEntrada());
            tb_saida.Text = Convert.ToString(Controller.GetqtSaida());
            MessageBox.Show("Apontamento criado com seucesso");
            MessageBox.Show("A quantidade de apontamentos é :" + Controller.L_apontamento1.Count()+"Qt exeções:"+Controller.L_execoes1.Count());
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].DataGridView.Columns.Clear();
            }
            grid.DataSource = null;
            grid.Refresh();
            grid.Columns.Add("Status", "Status");
            grid.Columns.Add("Dia", "Dia");
            grid.Columns.Add("Mês", "Mês");
            grid.Columns.Add("Ano", "Ano");
            grid.Columns.Add("Hora", "Hora");
            grid.Columns.Add("Minuto", "Minuto");
            grid.Columns.Add("Segundo", "Segundo");
            grid.Columns.Add("Matricula", "Matricula");
            foreach (Apontamento Fap in Controller.L_execoes1)
            {
                try
                {

                    if (Fap.Dia == tb_dia.Text)
                    {

                        grid.Rows.Add(Fap.Status, Fap.Dia, Fap.Mes, Fap.Ano, Fap.Hora, Fap.Minuto, Fap.Matricula_aluno);

                    }
                }

                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void tb_Fdia_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
