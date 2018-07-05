namespace Pj_FrquenciaObjetivo
{
    partial class TratarDados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chekd_diretorio = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.tb_caminho = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_qtEntrada = new MetroFramework.Controls.MetroTextBox();
            this.tb_saida = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_qtex = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_voltar = new MetroFramework.Controls.MetroButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tile_dia = new MetroFramework.Controls.MetroLabel();
            this.title_mes = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.title_ano = new MetroFramework.Controls.MetroTile();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.cmb_ano = new System.Windows.Forms.ComboBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.pgb_coleta = new System.Windows.Forms.ProgressBar();
            this.lb_carregando = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.metroTile1.SuspendLayout();
            this.title_mes.SuspendLayout();
            this.title_ano.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_carregando);
            this.groupBox1.Controls.Add(this.pgb_coleta);
            this.groupBox1.Controls.Add(this.chekd_diretorio);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.tb_caminho);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(89, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coletando dados";
            // 
            // chekd_diretorio
            // 
            this.chekd_diretorio.AutoSize = true;
            this.chekd_diretorio.Location = new System.Drawing.Point(149, 73);
            this.chekd_diretorio.Name = "chekd_diretorio";
            this.chekd_diretorio.Size = new System.Drawing.Size(106, 15);
            this.chekd_diretorio.TabIndex = 4;
            this.chekd_diretorio.Text = "Mudar diretório";
            this.chekd_diretorio.UseSelectable = true;
            this.chekd_diretorio.Click += new System.EventHandler(this.metroCheckBox1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(173, 94);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(82, 22);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Coletar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tb_caminho
            // 
            // 
            // 
            // 
            this.tb_caminho.CustomButton.Image = null;
            this.tb_caminho.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.tb_caminho.CustomButton.Name = "";
            this.tb_caminho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_caminho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_caminho.CustomButton.TabIndex = 1;
            this.tb_caminho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_caminho.CustomButton.UseSelectable = true;
            this.tb_caminho.CustomButton.Visible = false;
            this.tb_caminho.Enabled = false;
            this.tb_caminho.Lines = new string[] {
        "C:\\\\Apontamento\\\\Apontamento.txt"};
            this.tb_caminho.Location = new System.Drawing.Point(85, 44);
            this.tb_caminho.MaxLength = 32767;
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.PasswordChar = '\0';
            this.tb_caminho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_caminho.SelectedText = "";
            this.tb_caminho.SelectionLength = 0;
            this.tb_caminho.SelectionStart = 0;
            this.tb_caminho.ShortcutsEnabled = true;
            this.tb_caminho.Size = new System.Drawing.Size(170, 23);
            this.tb_caminho.TabIndex = 2;
            this.tb_caminho.Text = "C:\\\\Apontamento\\\\Apontamento.txt";
            this.tb_caminho.UseSelectable = true;
            this.tb_caminho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_caminho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_caminho.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Diretório:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_qtEntrada);
            this.groupBox2.Controls.Add(this.tb_saida);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.tb_qtex);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(89, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exeções";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tb_qtEntrada
            // 
            // 
            // 
            // 
            this.tb_qtEntrada.CustomButton.Image = null;
            this.tb_qtEntrada.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.tb_qtEntrada.CustomButton.Name = "";
            this.tb_qtEntrada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_qtEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_qtEntrada.CustomButton.TabIndex = 1;
            this.tb_qtEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_qtEntrada.CustomButton.UseSelectable = true;
            this.tb_qtEntrada.CustomButton.Visible = false;
            this.tb_qtEntrada.Enabled = false;
            this.tb_qtEntrada.Lines = new string[0];
            this.tb_qtEntrada.Location = new System.Drawing.Point(214, 37);
            this.tb_qtEntrada.MaxLength = 32767;
            this.tb_qtEntrada.Name = "tb_qtEntrada";
            this.tb_qtEntrada.PasswordChar = '\0';
            this.tb_qtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_qtEntrada.SelectedText = "";
            this.tb_qtEntrada.SelectionLength = 0;
            this.tb_qtEntrada.SelectionStart = 0;
            this.tb_qtEntrada.ShortcutsEnabled = true;
            this.tb_qtEntrada.Size = new System.Drawing.Size(52, 23);
            this.tb_qtEntrada.TabIndex = 7;
            this.tb_qtEntrada.UseSelectable = true;
            this.tb_qtEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_qtEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_saida
            // 
            // 
            // 
            // 
            this.tb_saida.CustomButton.Image = null;
            this.tb_saida.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.tb_saida.CustomButton.Name = "";
            this.tb_saida.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_saida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_saida.CustomButton.TabIndex = 1;
            this.tb_saida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_saida.CustomButton.UseSelectable = true;
            this.tb_saida.CustomButton.Visible = false;
            this.tb_saida.Enabled = false;
            this.tb_saida.Lines = new string[0];
            this.tb_saida.Location = new System.Drawing.Point(214, 66);
            this.tb_saida.MaxLength = 32767;
            this.tb_saida.Name = "tb_saida";
            this.tb_saida.PasswordChar = '\0';
            this.tb_saida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_saida.SelectedText = "";
            this.tb_saida.SelectionLength = 0;
            this.tb_saida.SelectionStart = 0;
            this.tb_saida.ShortcutsEnabled = true;
            this.tb_saida.Size = new System.Drawing.Size(52, 23);
            this.tb_saida.TabIndex = 6;
            this.tb_saida.UseSelectable = true;
            this.tb_saida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_saida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(58, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Quantidade de saidas:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Quantidade de entrada:";
            // 
            // tb_qtex
            // 
            // 
            // 
            // 
            this.tb_qtex.CustomButton.Image = null;
            this.tb_qtex.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.tb_qtex.CustomButton.Name = "";
            this.tb_qtex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_qtex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_qtex.CustomButton.TabIndex = 1;
            this.tb_qtex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_qtex.CustomButton.UseSelectable = true;
            this.tb_qtex.CustomButton.Visible = false;
            this.tb_qtex.Enabled = false;
            this.tb_qtex.Lines = new string[0];
            this.tb_qtex.Location = new System.Drawing.Point(214, 93);
            this.tb_qtex.MaxLength = 32767;
            this.tb_qtex.Name = "tb_qtex";
            this.tb_qtex.PasswordChar = '\0';
            this.tb_qtex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_qtex.SelectedText = "";
            this.tb_qtex.SelectionLength = 0;
            this.tb_qtex.SelectionStart = 0;
            this.tb_qtex.ShortcutsEnabled = true;
            this.tb_qtex.Size = new System.Drawing.Size(52, 23);
            this.tb_qtex.TabIndex = 3;
            this.tb_qtex.UseSelectable = true;
            this.tb_qtex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_qtex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(85, 136);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(134, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Tratar exeções";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(58, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(150, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Quantidade de exeções:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(265, 693);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(57, 23);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseSelectable = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(13, 440);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(434, 194);
            this.grid.TabIndex = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 418);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Relatório";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(13, 664);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Filtro:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(328, 662);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(114, 23);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "Filtrar";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.tile_dia);
            this.metroTile1.Location = new System.Drawing.Point(51, 640);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(108, 21);
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "dwd";
            this.metroTile1.UseSelectable = true;
            // 
            // tile_dia
            // 
            this.tile_dia.AutoSize = true;
            this.tile_dia.Location = new System.Drawing.Point(3, 2);
            this.tile_dia.Name = "tile_dia";
            this.tile_dia.Size = new System.Drawing.Size(104, 19);
            this.tile_dia.TabIndex = 0;
            this.tile_dia.Text = "Dia: Exemplo 01";
            // 
            // title_mes
            // 
            this.title_mes.ActiveControl = null;
            this.title_mes.Controls.Add(this.metroLabel8);
            this.title_mes.Location = new System.Drawing.Point(165, 640);
            this.title_mes.Name = "title_mes";
            this.title_mes.Size = new System.Drawing.Size(91, 21);
            this.title_mes.TabIndex = 17;
            this.title_mes.Text = "metroTile2";
            this.title_mes.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 2);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Mês";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title_ano
            // 
            this.title_ano.ActiveControl = null;
            this.title_ano.Controls.Add(this.metroLabel9);
            this.title_ano.Location = new System.Drawing.Point(262, 640);
            this.title_ano.Name = "title_ano";
            this.title_ano.Size = new System.Drawing.Size(60, 21);
            this.title_ano.TabIndex = 18;
            this.title_ano.Text = "Anos";
            this.title_ano.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 2);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Ano";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro "});
            this.cmb_mes.Location = new System.Drawing.Point(165, 664);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(91, 21);
            this.cmb_mes.TabIndex = 19;
            // 
            // cmb_ano
            // 
            this.cmb_ano.FormattingEnabled = true;
            this.cmb_ano.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmb_ano.Location = new System.Drawing.Point(262, 664);
            this.cmb_ano.Name = "cmb_ano";
            this.cmb_ano.Size = new System.Drawing.Size(60, 21);
            this.cmb_ano.TabIndex = 20;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(51, 664);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(107, 20);
            this.tb_dia.TabIndex = 21;
            this.tb_dia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(328, 693);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(114, 23);
            this.metroButton5.TabIndex = 22;
            this.metroButton5.Text = "Limpar filtro";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(51, 690);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(80, 23);
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = "Imprimir";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // pgb_coleta
            // 
            this.pgb_coleta.Location = new System.Drawing.Point(76, 135);
            this.pgb_coleta.Name = "pgb_coleta";
            this.pgb_coleta.Size = new System.Drawing.Size(157, 12);
            this.pgb_coleta.TabIndex = 5;
            this.pgb_coleta.Visible = false;
            this.pgb_coleta.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lb_carregando
            // 
            this.lb_carregando.AutoSize = true;
            this.lb_carregando.Location = new System.Drawing.Point(118, 119);
            this.lb_carregando.Name = "lb_carregando";
            this.lb_carregando.Size = new System.Drawing.Size(71, 13);
            this.lb_carregando.TabIndex = 6;
            this.lb_carregando.Text = "Carregando...";
            this.lb_carregando.Visible = false;
            // 
            // TratarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 722);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.cmb_ano);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.title_ano);
            this.Controls.Add(this.title_mes);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TratarDados";
            this.Text = "Tratar apontamentos";
            this.TransparencyKey = System.Drawing.Color.PowderBlue;
            this.Load += new System.EventHandler(this.TratarDados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.title_mes.ResumeLayout(false);
            this.title_mes.PerformLayout();
            this.title_ano.ResumeLayout(false);
            this.title_ano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox tb_caminho;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_voltar;
        private MetroFramework.Controls.MetroCheckBox chekd_diretorio;
        private MetroFramework.Controls.MetroTextBox tb_qtex;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_qtEntrada;
        private MetroFramework.Controls.MetroTextBox tb_saida;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView grid;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel tile_dia;
        private MetroFramework.Controls.MetroTile title_mes;
        private MetroFramework.Controls.MetroTile title_ano;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.ComboBox cmb_ano;
        private System.Windows.Forms.TextBox tb_dia;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ProgressBar pgb_coleta;
        private System.Windows.Forms.Label lb_carregando;
    }
}