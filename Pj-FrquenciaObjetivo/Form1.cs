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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text =="admin" && metroTextBox2.Text == "objetivo")
            {
                Home Hhome = new Home();
                this.Hide(); // use dessa maneira.
                Hhome.ShowDialog();
                
               

            }

            else
            { 
             

                MetroMessageBox.Show(this, "Login ou senha inválidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
