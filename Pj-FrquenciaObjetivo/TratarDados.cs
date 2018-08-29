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
using DGVPrinterHelper;
using System.Data.SqlClient;
using System.Threading;
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
            Controller.Thread1.Abort();
            // Limpando a listas de alunos 
            if (Controller.L_alunos1.Count() != 0)
            {
                for (int i = Controller.L_alunos1.Count; i >= 0; i--)
                {

                    Controller.L_alunos1.RemoveAt(i);

                }
            }
            // limpando a lista de apontamentos


            if (Controller.L_apontamento1.Count() != 0)
            {
                for (int i = Controller.L_apontamento1.Count -1; i >= -1; i--)
                {

                    Controller.L_apontamento1.RemoveAt(i);

                }

            }
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
                     if(status=="01")
                            {
                                status = "Entrada";
                            Controller.QtEntrada++;
                            }
                            else
                            {
                                status = "Saida";
                            Controller.QtSaida++;
                            }
                    TodosApontamento[int.Parse(mes), int.Parse(dia), Coutap] = linha;
                    Apontamento apm = new Apontamento(matricula, status, dia, mes, ano, hora, minuto, segundo, "Apontamento");
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

            catch (Exception er)
            {

                MessageBox.Show("erro :"+ er);
                MetroMessageBox.Show(this, "Erro ao tentar adicionar na lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Controller.Thread1.Abort();
            

        }

     

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }

        private Task ProcessData(List<string> list, IProgress<progressReport> progress)
        {
            int index = 1;
            int totalProgress = list.Count;
            var progressReport = new progressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProgress; i++)
                {
                    progressReport.Percentual1 = index++ * 100 / totalProgress;
                    progress.Report(progressReport);
                    Thread.Sleep(2);
                    
                   

                }
               
                

            });

        }

        private async void metroButton2_Click(object sender, EventArgs e)
        {
            pgb_coleta.Visible = true;
            lb_carregando.Visible = true;
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }

            var progress = new Progress<progressReport>();
            progress.ProgressChanged += (o, report) =>
                {
                    lb_carregando.Text = string.Format("Carregando...{0}%", report.Percentual1);
                    pgb_coleta.Value = report.Percentual1;
                    pgb_coleta.Update();

                    

                };
           
            grid.DataSource = Controller.L_execoes1;
        
            await ProcessData(list, progress);
            

            pgb_coleta.Visible = false;
            lb_carregando.Visible = false;
            tb_qtex.Text = Convert.ToString(Controller.L_execoes1.Count());
            
                tb_qtEntrada.Text = Convert.ToString(Controller.QtEntrada);
                tb_saida.Text = Convert.ToString(Controller.QtSaida);
            




        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            lb_aguarde.Visible = true;
            int qt = 0;
            try
            {
                qt = Controller.SetDadosBanco();
                MessageBox.Show("Tratamento de exceções efetuado com sucesso ! \n Quantidade de alunos novos adicionados: "+Convert.ToString(qt));
                //Tratando exeções
                //abrindo txt
                StreamReader x;
                string Caminho = tb_caminho.Text;
                

                int qtex = Controller.L_execoes1.Count();
                foreach (Apontamento ex in Controller.L_execoes1)
                {                                                           
                          if (ex.Status == "Entrada")
                            {
                                Apontamento apm = new Apontamento(ex.Matricula_aluno, "Saida", ex.Dia,ex.Mes,ex.Ano, "18", "00", "00", "Exceção (A)");
                                Controller.CarregaApontamentos(apm);
                            }
                            else
                            {
                                Apontamento apm = new Apontamento(ex.Matricula_aluno, "Entrada", ex.Dia, ex.Mes, ex.Ano, "07", "00", "00", "Exceção (A)");
                                Controller.CarregaApontamentos(apm);
                            }
                        
                        //verificando qual a exceãodo aluno para poder criar a correção                                  
                }
                Controller.SetDadosBanco();
                MessageBox.Show("Exceções tratadas com sucesso !");

            }
            catch
            {
             MetroMessageBox.Show(this, "Falha ao tentar efetuar a conexão com o banco de dados, por favor entre em contato com o administrador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                lb_aguarde.Visible = false;
            }

           
            //Criando o txt com as exceções
            try
            {
                
                ////declarando a variavel do tipo StreamWriter para 
                //abrir ou criar um arquivo para escrita 
                StreamWriter arq;

                ////Colocando o caminho fisico e o nome do arquivo a ser criado
                //finalizando com .txt
               
                string CaminhoNome = tb_caminho.Text+"Excecao.txt";

                //utilizando o metodo para criar um arquivo texto
                //e associando o caminho e nome ao metodo
                arq = File.CreateText(CaminhoNome);

                //aqui, exemplo de escrever no arquivo texto
                //como se fossemos criar um recibo de pagamento
                foreach (Apontamento apm in Controller.L_apontamento1)
                {
                    if (apm.Status == "Entrada")
                    {

                        arq.WriteLine("01" + apm.Dia + apm.Mes + apm.Ano + apm.Hora + apm.Minuto + apm.Segundo + apm.Matricula_aluno);
                    }
                    else
                    {
                        arq.WriteLine("02" + apm.Dia + apm.Mes + apm.Ano + apm.Hora + apm.Minuto + apm.Segundo + apm.Matricula_aluno);
                    }
                }
                //fechando o arquivo texto com o método .Close()
                arq.Close();
            }
            catch(Exception excp)
            {
                MessageBox.Show("Erro ao tentar criar arquivo de exceção, por favor verifique as permissões de pasta"+excp);
            }




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
            if(tb_dia.Text !="" && cmb_ano.Text !="" && cmb_ano.Text != "")
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

                string mes="";

                switch (cmb_mes.Text)

                {

                    case "Janeiro":  // Caso o que for digitado seja 1

                        mes = "01";

                        break; //E dps de escrever na tela o program irá parar e assim acontece nos outros

                    case "Fevereiro":

                        mes = "02";

                        break;

                    case "Março":

                        mes = "03";

                        break;

                    case "Abril":

                        mes = "04";

                        break;

                    case "Maio":

                        mes = "05";

                        break;

                    case "Junho":

                        mes = "06";

                        break;

                    case "Julho":

                        mes = "07";

                        break;

                    case "Agosto":

                        mes = "08";

                        break;

                    case "Setembro":

                        mes = "09";

                        break;

                    case "Outubro":

                        mes = "10";

                        break;

                    case "Novembro":

                        mes = "11";

                        break;

                    case "Dezembro":

                        mes = "12";

                        break;

               

                

                

                }

                foreach (Apontamento Fap in Controller.L_execoes1)
                {
                    try
                    {

                        if (Fap.Dia == tb_dia.Text && Fap.Mes == mes && Fap.Ano == cmb_ano.Text)
                        {

                            grid.Rows.Add(Fap.Status, Fap.Dia, Fap.Mes, Fap.Ano, Fap.Hora, Fap.Minuto, Fap.Segundo, Fap.Matricula_aluno);

                        }
                    }

                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            else
            {
               

                MetroMessageBox.Show(this, "Por favor, complete a data para realizar o filtro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void metroButton5_Click(object sender, EventArgs e)
        {
            tb_dia.Text = "";
            
            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].DataGridView.Columns.Clear();
            }
            grid.DataSource = null;
            grid.Refresh();
            grid.DataSource = Controller.L_execoes1;
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Apontamentos Objetivo Cubatão";
            printer.SubTitle = string.Format("Data{0}", DateTime.Now);
            printer.SubTitle = "- Exceções -";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Objetivo Cubatão";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(grid);
        }

        private void metroCheckBox1_Click(object sender, EventArgs e)
        {
            if(chekd_diretorio.Checked== true)
            {
                tb_caminho.Enabled = true;
            }
            else
            {
                tb_caminho.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chekd_diretorio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
