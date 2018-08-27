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
using DGVPrinterHelper;
using System.IO; //declarando a biblioteca de entrada e saída de arquivos
                 //a biblioteca IO



namespace Pj_FrquenciaObjetivo
{
    public partial class registros : MetroFramework.Forms.MetroForm
    {
        public registros()
        {
            InitializeComponent();
        }

        private void registros_Load(object sender, EventArgs e)
        {
            string data = Convert.ToString(dtm_data.Text);
            string dia="", mes="", ano = "";
            int posicao = 6, posicao2 = 1;
            while(data.Substring(posicao, posicao2)!=",")
            {
                posicao++;
            }
            posicao=posicao+2;
            posicao2++;
            dia = data.Substring(posicao, posicao2);
            posicao = posicao + 4;

            

            while(data.Substring(posicao,posicao2)!="de")
            {
                posicao++;
            }
            posicao = posicao + 3;
            posicao2 = posicao2 + 2;
            ano = data.Substring(posicao,posicao2);
            if(data.Contains("janeiro"))
            {
                mes = "01";
            }
           else if (data.Contains("fevereiro"))
            {
                mes = "02";
            }
         else   if (data.Contains("março"))
            {
                mes = "03";
            }
        else  if (data.Contains("abril"))
            {
                mes = "04";
            }
        else if (data.Contains("maio"))
            {
                mes = "05";
            }
        else if (data.Contains("junho"))
            {
                mes = "06";
            }
        else if (data.Contains("julho"))
            {
                mes = "07";
            }
        else if (data.Contains("agosto"))
            {
                mes = "08";
            }

        else if (data.Contains("setembro"))
            {
                mes = "09";
            }
        else if (data.Contains("outubro"))
            {
                mes = "10";
            }

        else if (data.Contains("novembro"))
            {
                mes = "11";
            }
        else if (data.Contains("dezembro"))
            {
                mes = "12";
            }
           
            if (Controller.L_alunos1.Count() != 0)
            {
                for (int i = Controller.L_alunos1.Count - 1; i >= 0; i--)
                {

                    Controller.L_alunos1.RemoveAt(i);

                }
            }
            for (int i = 0; i < gridAlunosNovos.RowCount; i++)
            {
                gridAlunosNovos.Rows[i].DataGridView.Columns.Clear();
            }
            gridAlunosNovos.DataSource = null;
            gridAlunosNovos.Refresh();
            gridAlunosNovos.Columns.Add("Matricula", "Matricula");
            gridAlunosNovos.Columns.Add("Nome", "Nome");
            gridAlunosNovos.Columns.Add("Status", "Status");


            Controller.GetAlunos();
           

            foreach (Aluno al in Controller.L_alunos1)
            {
              
             
                try
                {

                    if (al.Nome1 == "" && al.Status1 == "ATIVO")
                    {

                        gridAlunosNovos.Rows.Add(al.Matricula1, al.Nome1, al.Status1

                            );

                    }
                }
                

                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //Listando apontamentos
            if (Controller.L_apontamento1.Count() != 0)
            {
                for (int i = Controller.L_apontamento1.Count - 1; i >= 0; i--)
                {

                    Controller.L_apontamento1.RemoveAt(i);

                }

            }
            for (int i = 0; i < gridaponta.RowCount; i++)
            {
                gridaponta.Rows[i].DataGridView.Columns.Clear();
            }
            gridaponta.DataSource = null;
            gridaponta.Refresh();
            gridaponta.Columns.Add("Matricula", "Matricula");
            gridaponta.Columns.Add("Status", "Status");
            gridaponta.Columns.Add("Dia", "Dia");
            gridaponta.Columns.Add("Mês", "Mês");
            gridaponta.Columns.Add("Ano", "Ano");
            gridaponta.Columns.Add("Hora", "Hora");
            gridaponta.Columns.Add("Minuto", "Minuto");
            gridaponta.Columns.Add("Segundo", "Segundo");
            gridaponta.Columns.Add("Tipo", "Tipo");

           
           
            Controller.getAlunoscNome();
            cmb_alunos.DataSource = Controller.L_alunos1;
            cmb_alunos.DisplayMember = "Aluno";
            cmb_alunos.ValueMember = "Nome1";
            cmb_matricula.DataSource = Controller.L_alunos1;
            cmb_matricula.DisplayMember = "Aluno";
            cmb_matricula.ValueMember = "Matricula1";
            Controller.GetApontamentos(dia,mes,ano,cmb_matricula.Text);

            foreach (Apontamento aponta in Controller.L_apontamento1)
            {
                try
                {



                    gridaponta.Rows.Add(aponta.Matricula_aluno, aponta.Status, aponta.Dia, aponta.Mes, aponta.Ano, aponta.Hora, aponta.Minuto, aponta.Segundo, aponta.Tipo);



                }

                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Controller.GetAlunos();
            int qtd = Controller.L_alunos1.Count(), cont = 0;
            try
          {
                
                // Salvando dados alterados no grid
                foreach (Aluno al in Controller.L_alunos1)
                {
                
                   

                    if (cont<=qtd)
                     {

                        if (al.Matricula1.Equals(gridAlunosNovos.Rows[cont].Cells["Matricula"].Value.ToString()))
                        {
                            al.Nome1 = gridAlunosNovos.Rows[cont].Cells["Nome"].Value.ToString();
                            cont++;
                        }
                        
                        
                     }
                   
                }
                MessageBox.Show("Nomes adicionados com sucesso !");
                Controller.AlteraNomes();

            }

         catch (Exception er)
          {
                MessageBox.Show("erro"+er);
          }
           gridAlunosNovos.Refresh();

            if (Controller.L_alunos1.Count() != 0)
            {
                for (int i = Controller.L_alunos1.Count - 1; i >= 0; i--)
                {

                    Controller.L_alunos1.RemoveAt(i);

                }
            }
            for (int i = 0; i < gridAlunosNovos.RowCount; i++)
            {
                gridAlunosNovos.Rows[i].DataGridView.Columns.Clear();
            }
            gridAlunosNovos.DataSource = null;
            gridAlunosNovos.Refresh();
            gridAlunosNovos.Columns.Add("Matricula", "Matricula");
            gridAlunosNovos.Columns.Add("Nome", "Nome");
            gridAlunosNovos.Columns.Add("Status", "Status");


            Controller.GetAlunos();
            
            foreach (Aluno al in Controller.L_alunos1)
            {
                try
                {

                    if (al.Nome1 == "" && al.Status1 == "ATIVO")
                    {

                        gridAlunosNovos.Rows.Add(al.Matricula1, al.Nome1, al.Status1

                            );

                    }
                }

                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (Controller.L_alunos1.Count() != 0)
            {
                for (int i = Controller.L_alunos1.Count - 1; i >= 0; i--)
                {

                    Controller.L_alunos1.RemoveAt(i);

                }
            }

            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();








        }

        private void gridAlunosNovos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controller.ExcAluno1 = gridAlunosNovos.Rows[e.RowIndex].Cells["Matricula"].Value.ToString();
           
         
         



        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.ExcluiAluno(Controller.ExcAluno1);
                MessageBox.Show("Aluno Excluido com sucesso !");

                for (int i = 0; i < gridAlunosNovos.RowCount; i++)
                {
                    gridAlunosNovos.Rows[i].DataGridView.Columns.Clear();
                }
                gridAlunosNovos.DataSource = null;
                gridAlunosNovos.Refresh();
                gridAlunosNovos.Columns.Add("Matricula", "Matricula");
                gridAlunosNovos.Columns.Add("Nome", "Nome");
                gridAlunosNovos.Columns.Add("Status", "Status");
                Controller.GetAlunos();

                foreach (Aluno al in Controller.L_alunos1)
                {
                    try
                    {

                        if (al.Nome1 == "" && al.Status1 == "ATIVO")
                        {

                            gridAlunosNovos.Rows.Add(al.Matricula1, al.Nome1, al.Status1

                                );

                        }
                    }

                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao tentar excluir o aluno: "+error);

            }

            if (Controller.L_alunos1.Count() != 0)
            {
                for (int i = Controller.L_alunos1.Count - 1; i >= 0; i--)
                {

                    Controller.L_alunos1.RemoveAt(i);

                }
            }
            for (int i = 0; i < gridAlunosNovos.RowCount; i++)
            {
                gridAlunosNovos.Rows[i].DataGridView.Columns.Clear();
            }
            gridAlunosNovos.DataSource = null;
            gridAlunosNovos.Refresh();
            gridAlunosNovos.Columns.Add("Matricula", "Matricula");
            gridAlunosNovos.Columns.Add("Nome", "Nome");
            gridAlunosNovos.Columns.Add("Status", "Status");


            Controller.GetAlunos();
            Controller.L_alunos1.Count();
            foreach (Aluno al in Controller.L_alunos1)
            {
                try
                {

                    if (al.Nome1 == "" && al.Status1 == "ATIVO")
                    {

                        gridAlunosNovos.Rows.Add(al.Matricula1, al.Nome1, al.Status1

                            );

                    }
                }

                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }

        private void cmb_ano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_dia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Apontamentos Objetivo Cubatão";
            printer.SubTitle = string.Format("Data{0}", DateTime.Now);
            printer.SubTitle = "Aluno: "+cmb_alunos.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Objetivo Cubatão";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gridaponta);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridaponta.RowCount; i++)
            {
                gridaponta.Rows[i].DataGridView.Columns.Clear();
            }
            gridaponta.DataSource = null;
            gridaponta.Refresh();
            gridaponta.Columns.Add("Matricula", "Matricula");
            gridaponta.Columns.Add("Status", "Status");
            gridaponta.Columns.Add("Dia", "Dia");
            gridaponta.Columns.Add("Mês", "Mês");
            gridaponta.Columns.Add("Ano", "Ano");
            gridaponta.Columns.Add("Hora", "Hora");
            gridaponta.Columns.Add("Minuto", "Minuto");
            gridaponta.Columns.Add("Segundo", "Segundo");
            gridaponta.Columns.Add("Tipo", "Tipo");

            string data = Convert.ToString(dtm_data.Text);
            string dia = "", mes = "", ano = "";
            int posicao = 6, posicao2 = 1;
            while (data.Substring(posicao, posicao2) != ",")
            {
                posicao++;
            }
            posicao = posicao + 2;
            posicao2++;
            dia = data.Substring(posicao, posicao2);
            posicao = posicao + 4;



            while (data.Substring(posicao, posicao2) != "de")
            {
                posicao++;
            }
            posicao = posicao + 3;
            posicao2 = posicao2 + 2;
            ano = data.Substring(posicao, posicao2);
            if (data.Contains("janeiro"))
            {
                mes = "01";
            }
            else if (data.Contains("fevereiro"))
            {
                mes = "02";
            }
            else if (data.Contains("março"))
            {
                mes = "03";
            }
            else if (data.Contains("abril"))
            {
                mes = "04";
            }
            else if (data.Contains("maio"))
            {
                mes = "05";
            }
            else if (data.Contains("junho"))
            {
                mes = "06";
            }
            else if (data.Contains("julho"))
            {
                mes = "07";
            }
            else if (data.Contains("agosto"))
            {
                mes = "08";
            }

            else if (data.Contains("setembro"))
            {
                mes = "09";
            }
            else if (data.Contains("outubro"))
            {
                mes = "10";
            }

            else if (data.Contains("novembro"))
            {
                mes = "11";
            }
            else if (data.Contains("dezembro"))
            {
                mes = "12";
            }

            // Limpando a lista de apontamentos para realizar o filtro 

            if (Controller.L_apontamento1.Count() != 0)
            {
                for (int i = Controller.L_apontamento1.Count - 1; i >= 0; i--)
                {

                    Controller.L_apontamento1.RemoveAt(i);

                }

            }
            if (dtm_data.Enabled == true)
            {
                Controller.GetApontamentos(dia, mes, ano, cmb_matricula.Text);
            }
            else
            {
                Controller.getExByid(cmb_matricula.Text);
            }
            foreach (Apontamento aponta in Controller.L_apontamento1)
            {
                try
                {
              
                  gridaponta.Rows.Add(aponta.Matricula_aluno, aponta.Status, aponta.Dia, aponta.Mes, aponta.Ano, aponta.Hora, aponta.Minuto, aponta.Segundo, aponta.Tipo);
                   

                }

                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Falha ao tentar realizar o filtro, por favor tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkd_ex.Checked == true)
            {
                dtm_data.Enabled = false;
            }
            else
            {
                dtm_data.Enabled = true;
            }
        }

        private void gridaponta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals("Exceção (A)"))

            {

                gridaponta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;

            }
        }
    }
}
