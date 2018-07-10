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
    public partial class registros : MetroFramework.Forms.MetroForm
    {
        public registros()
        {
            InitializeComponent();
        }

        private void registros_Load(object sender, EventArgs e)
        {
            
            
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
           

        }
    }
}
