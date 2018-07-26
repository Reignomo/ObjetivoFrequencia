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

namespace Pj_FrquenciaObjetivo
{
    public partial class Alunosfm :  MetroFramework.Forms.MetroForm
    {
        public Alunosfm()
        {
            InitializeComponent();
        }

        private void Alunosfm_Load(object sender, EventArgs e)
        {
            // Alunos ativos

            if (Controller.L_alunos1.Count() != 0)
            {
                for (int i = Controller.L_alunos1.Count - 1; i >= 0; i--)
                {

                    Controller.L_alunos1.RemoveAt(i);

                }
            }
            Controller.GetAlunos();
            
            for (int i = 0; i < grid_alunosAtivos.RowCount; i++)
            {
                grid_alunosAtivos.Rows[i].DataGridView.Columns.Clear();
            }
            grid_alunosAtivos.DataSource = null;
            grid_alunosAtivos.Refresh();
            grid_alunosAtivos.Columns.Add("Matricula", "Matricula");
            grid_alunosAtivos.Columns.Add("Nome", "Nome");
            grid_alunosAtivos.Columns.Add("Status", "Status");

            foreach (Aluno al in Controller.L_alunos1)
            {
                if (al.Nome1 != "" && al.Status1 == "ATIVO")
                {
                    grid_alunosAtivos.Rows.Add(al.Matricula1, al.Nome1, al.Status1);
                }
            }
            // Grid 2 Alunos inativos

            for (int i = 0; i < Grid_alunosInativos.RowCount; i++)
            {
                Grid_alunosInativos.Rows[i].DataGridView.Columns.Clear();
            }
            Grid_alunosInativos.DataSource = null;
            Grid_alunosInativos.Refresh();
            Grid_alunosInativos.Columns.Add("Matricula", "Matricula");
            Grid_alunosInativos.Columns.Add("Nome", "Nome");
            Grid_alunosInativos.Columns.Add("Status", "Status");
            

            foreach (Aluno al in Controller.L_alunos1)
            {
                if (al.Status1 != "ATIVO")
                {
                    Grid_alunosInativos.Rows.Add(al.Matricula1, al.Nome1, al.Status1);
                }
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
            try
            {
                Controller.getAlunoscNome();
                int qtd = Controller.L_alunos1.Count(), cont = 0;
                // Salvando dados alterados no grid
                foreach (Aluno al in Controller.L_alunos1)
                {



                    if (cont <= qtd)
                    {

                        if (al.Matricula1.Equals(grid_alunosAtivos.Rows[cont].Cells["Matricula"].Value.ToString()))
                        {
                            al.Nome1 = grid_alunosAtivos.Rows[cont].Cells["Nome"].Value.ToString();
                            cont++;
                        }


                    }

                }
                MessageBox.Show("Nomes adicionados com sucesso !");
                Controller.AlteraNomes();

            }

            catch (Exception er)
            {
                MessageBox.Show("erro" + er);
            }
            grid_alunosAtivos.Refresh();

          

            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();

        }
    }
}
