namespace Pj_FrquenciaObjetivo
{
    partial class Relatorio_faltas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoDataSet = new Pj_FrquenciaObjetivo.objetivoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlunosTableAdapter = new Pj_FrquenciaObjetivo.objetivoDataSetTableAdapters.AlunosTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.AlunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AlunosBindingSource
            // 
            this.AlunosBindingSource.DataMember = "Alunos";
            this.AlunosBindingSource.DataSource = this.objetivoDataSet;
            // 
            // objetivoDataSet
            // 
            this.objetivoDataSet.DataSetName = "objetivoDataSet";
            this.objetivoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlunosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pj_FrquenciaObjetivo.Relatorio_faltas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(605, 331);
            this.reportViewer1.TabIndex = 0;
            // 
            // AlunosTableAdapter
            // 
            this.AlunosTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(534, 414);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(66, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Voltar";
            this.metroButton1.UseSelectable = true;
            // 
            // Relatorio_faltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio_faltas";
            this.Text = "Relatório de faltas";
            this.Load += new System.EventHandler(this.Relatorio_faltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlunosBindingSource;
        private objetivoDataSet objetivoDataSet;
        private objetivoDataSetTableAdapters.AlunosTableAdapter AlunosTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}