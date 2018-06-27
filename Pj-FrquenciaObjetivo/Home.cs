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
    public partial class Home :MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tratarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TratarDados tdados = new TratarDados();
            this.Hide(); // use dessa maneira.
            tdados.ShowDialog();

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registros regis = new registros();
            this.Hide(); // use dessa maneira.
            regis.ShowDialog();
        }
    }
}
