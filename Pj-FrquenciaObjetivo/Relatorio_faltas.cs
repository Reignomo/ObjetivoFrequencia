using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pj_FrquenciaObjetivo
{
    public partial class Relatorio_faltas :  MetroFramework.Forms.MetroForm
    {
        public Relatorio_faltas()
        {
            InitializeComponent();
        }

        private void Relatorio_faltas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'objetivoDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.AlunosTableAdapter.Fill(this.objetivoDataSet.Alunos);

            this.reportViewer1.RefreshReport();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
