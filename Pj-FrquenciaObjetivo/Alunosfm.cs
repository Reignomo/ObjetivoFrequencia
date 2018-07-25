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

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }
    }
}
