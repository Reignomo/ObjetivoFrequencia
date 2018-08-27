namespace Pj_FrquenciaObjetivo
{
    partial class registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registros));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.gridAlunosNovos = new System.Windows.Forms.DataGridView();
            this.gridaponta = new System.Windows.Forms.DataGridView();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_voltar = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.dtm_data = new System.Windows.Forms.DateTimePicker();
            this.cmb_alunos = new System.Windows.Forms.ComboBox();
            this.Aluno = new System.Windows.Forms.Label();
            this.cmb_matricula = new System.Windows.Forms.ComboBox();
            this.checkd_ex = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosNovos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaponta)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 65);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(419, 36);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Alunos novos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.UseSelectable = true;
            // 
            // gridAlunosNovos
            // 
            this.gridAlunosNovos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlunosNovos.Location = new System.Drawing.Point(23, 107);
            this.gridAlunosNovos.Name = "gridAlunosNovos";
            this.gridAlunosNovos.Size = new System.Drawing.Size(419, 156);
            this.gridAlunosNovos.TabIndex = 1;
            this.gridAlunosNovos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlunosNovos_CellClick);
            // 
            // gridaponta
            // 
            this.gridaponta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridaponta.Location = new System.Drawing.Point(23, 323);
            this.gridaponta.Name = "gridaponta";
            this.gridaponta.ReadOnly = true;
            this.gridaponta.Size = new System.Drawing.Size(419, 150);
            this.gridaponta.TabIndex = 3;
            this.gridaponta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridaponta_CellFormatting);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 278);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(419, 39);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Apontamentos";
            this.metroTile2.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(578, 240);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Salvar alterações";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(465, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(210, 127);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(465, 396);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(147, 16);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "Imprimir";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(618, 396);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(57, 16);
            this.metroButton4.TabIndex = 10;
            this.metroButton4.Text = "Filtar";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(542, 292);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Filtro";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(612, 464);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(68, 19);
            this.btn_voltar.TabIndex = 13;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseSelectable = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(465, 240);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(107, 23);
            this.metroButton5.TabIndex = 14;
            this.metroButton5.Text = "Excluir";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // dtm_data
            // 
            this.dtm_data.Location = new System.Drawing.Point(465, 314);
            this.dtm_data.Name = "dtm_data";
            this.dtm_data.Size = new System.Drawing.Size(210, 20);
            this.dtm_data.TabIndex = 15;
            this.dtm_data.Value = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            // 
            // cmb_alunos
            // 
            this.cmb_alunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_alunos.FormattingEnabled = true;
            this.cmb_alunos.Location = new System.Drawing.Point(465, 369);
            this.cmb_alunos.Name = "cmb_alunos";
            this.cmb_alunos.Size = new System.Drawing.Size(147, 21);
            this.cmb_alunos.TabIndex = 16;
            // 
            // Aluno
            // 
            this.Aluno.AutoSize = true;
            this.Aluno.Location = new System.Drawing.Point(521, 353);
            this.Aluno.Name = "Aluno";
            this.Aluno.Size = new System.Drawing.Size(34, 13);
            this.Aluno.TabIndex = 17;
            this.Aluno.Text = "Aluno";
            // 
            // cmb_matricula
            // 
            this.cmb_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_matricula.Enabled = false;
            this.cmb_matricula.FormattingEnabled = true;
            this.cmb_matricula.Location = new System.Drawing.Point(618, 369);
            this.cmb_matricula.Name = "cmb_matricula";
            this.cmb_matricula.Size = new System.Drawing.Size(57, 21);
            this.cmb_matricula.TabIndex = 18;
            // 
            // checkd_ex
            // 
            this.checkd_ex.AutoSize = true;
            this.checkd_ex.Location = new System.Drawing.Point(575, 340);
            this.checkd_ex.Name = "checkd_ex";
            this.checkd_ex.Size = new System.Drawing.Size(100, 17);
            this.checkd_ex.TabIndex = 19;
            this.checkd_ex.Text = "Listar exceções";
            this.checkd_ex.UseVisualStyleBackColor = true;
            this.checkd_ex.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(23, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 11);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Apontamento artificial (A)";
            // 
            // registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkd_ex);
            this.Controls.Add(this.cmb_matricula);
            this.Controls.Add(this.Aluno);
            this.Controls.Add(this.cmb_alunos);
            this.Controls.Add(this.dtm_data);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.gridaponta);
            this.Controls.Add(this.gridAlunosNovos);
            this.Controls.Add(this.metroTile1);
            this.Name = "registros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlunosNovos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaponta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView gridAlunosNovos;
        private System.Windows.Forms.DataGridView gridaponta;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_voltar;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.DateTimePicker dtm_data;
        private System.Windows.Forms.ComboBox cmb_alunos;
        private System.Windows.Forms.Label Aluno;
        private System.Windows.Forms.ComboBox cmb_matricula;
        private System.Windows.Forms.CheckBox checkd_ex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}