namespace Pj_FrquenciaObjetivo
{
    partial class Alunosfm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.grid_alunosAtivos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.Grid_alunosInativos = new System.Windows.Forms.DataGridView();
            this.btn_faltas = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alunosAtivos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_alunosInativos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(313, 560);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Voltar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(6, 19);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(359, 39);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Alunos inativos";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(6, 19);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(359, 38);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Alunos ativos";
            this.metroTile2.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_faltas);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroTile2);
            this.groupBox1.Controls.Add(this.grid_alunosAtivos);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 264);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(109, 235);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(102, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Salvar alteração";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(6, 235);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Excluir aluno";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // grid_alunosAtivos
            // 
            this.grid_alunosAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alunosAtivos.Location = new System.Drawing.Point(6, 57);
            this.grid_alunosAtivos.Name = "grid_alunosAtivos";
            this.grid_alunosAtivos.Size = new System.Drawing.Size(359, 172);
            this.grid_alunosAtivos.TabIndex = 0;
            this.grid_alunosAtivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_alunosAtivos_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.Grid_alunosInativos);
            this.groupBox2.Controls.Add(this.metroTile1);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 255);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(6, 225);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(109, 23);
            this.metroButton4.TabIndex = 1;
            this.metroButton4.Text = "Reativar cadastro";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Grid_alunosInativos
            // 
            this.Grid_alunosInativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_alunosInativos.Location = new System.Drawing.Point(6, 58);
            this.Grid_alunosInativos.Name = "Grid_alunosInativos";
            this.Grid_alunosInativos.ReadOnly = true;
            this.Grid_alunosInativos.Size = new System.Drawing.Size(359, 161);
            this.Grid_alunosInativos.TabIndex = 0;
            this.Grid_alunosInativos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_alunosInativos_CellClick);
            // 
            // btn_faltas
            // 
            this.btn_faltas.Location = new System.Drawing.Point(217, 235);
            this.btn_faltas.Name = "btn_faltas";
            this.btn_faltas.Size = new System.Drawing.Size(148, 23);
            this.btn_faltas.TabIndex = 7;
            this.btn_faltas.Text = "Gerar relatório de faltas";
            this.btn_faltas.UseSelectable = true;
            this.btn_faltas.Click += new System.EventHandler(this.btn_faltas_Click);
            // 
            // Alunosfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton1);
            this.Name = "Alunosfm";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunosfm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_alunosAtivos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_alunosInativos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView grid_alunosAtivos;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.DataGridView Grid_alunosInativos;
        private MetroFramework.Controls.MetroButton btn_faltas;
    }
}