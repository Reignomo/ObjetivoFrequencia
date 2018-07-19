using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pj_FrquenciaObjetivo
{
    public partial class Home :MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            rtb_descricao.Text= "           Sistema de frequência objetivo Cubatao"+
           "\n  Sistema desenvolvido para gerenciar o controle de frequencia de escolas." +
           "\n  - Funcionalidades" +
           "\n  • Listar apontamento." +
           "\n  • Tratar exceções." +
           "\n  • Salvar apontamento em base de dados." +
           "\n  • Visualizar apontamento." +
           "\n  • Filtrar apontamentos." +
           "\n  • Adicionar e alterar nome de alunos." +
           "\n  • Gerar relatórios dos apontamentos." +
           "\n  Denvolvedor;" +
           "\n  Evandro Ignacio Estudante -IFSP Cubatão";
        }

        private void tratarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string str = string.Empty;
            Controller.CriaLoad();
            Controller.Thread1.Start();
            InitializeComponent();
            Thread.Sleep(2000);
            TratarDados tdados = new TratarDados();        
            this.Hide(); // use dessa maneira.
            tdados.ShowDialog();         
            // Adicionando tela de Load         
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registros regis = new registros();
            this.Hide(); // use dessa maneira.
            regis.ShowDialog();
        }
    }
}
