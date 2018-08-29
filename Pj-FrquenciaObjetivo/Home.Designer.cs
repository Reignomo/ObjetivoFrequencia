namespace Pj_FrquenciaObjetivo
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tratarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeFaltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(225, 87);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(278, 41);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Descrição do sistema";
            this.metroTile1.UseSelectable = true;
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.Enabled = false;
            this.rtb_descricao.Location = new System.Drawing.Point(225, 134);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(278, 231);
            this.rtb_descricao.TabIndex = 2;
            this.rtb_descricao.Text = "";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(428, 371);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Sair";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pj_FrquenciaObjetivo.Properties.Resources.img4;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(196, 278);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tratarDadosToolStripMenuItem
            // 
            this.tratarDadosToolStripMenuItem.Name = "tratarDadosToolStripMenuItem";
            this.tratarDadosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.tratarDadosToolStripMenuItem.Text = "Exceções";
            this.tratarDadosToolStripMenuItem.Click += new System.EventHandler(this.tratarDadosToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.registrosToolStripMenuItem.Text = "Apontamentos";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tratarDadosToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.relatórioDeFaltasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // relatórioDeFaltasToolStripMenuItem
            // 
            this.relatórioDeFaltasToolStripMenuItem.Name = "relatórioDeFaltasToolStripMenuItem";
            this.relatórioDeFaltasToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.relatórioDeFaltasToolStripMenuItem.Text = "Relatório de faltas";
            this.relatórioDeFaltasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeFaltasToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 403);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.RichTextBox rtb_descricao;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ToolStripMenuItem tratarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeFaltasToolStripMenuItem;
    }
}