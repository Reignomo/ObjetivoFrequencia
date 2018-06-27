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
    public partial class TratarDados : MetroFramework.Forms.MetroForm
    {
        public TratarDados()
        {
            InitializeComponent();
        }

        private void TratarDados_Load(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Home Hhome = new Home();
            this.Hide(); // use dessa maneira.
            Hhome.ShowDialog();
        }
    }
}
