namespace Etec.HardTechnologies.UI
{
    partial class frmRelatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title21 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title22 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title23 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title24 = new System.Windows.Forms.DataVisualization.Charting.Title();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FINALIZACAO_DE_SERVICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenesysDBFinalizacaoServico = new Etec.HardTechnologies.UI.GenesysDBFinalizacaoServico();
            this.chtFinalidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sERVICOPORFINALIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesysDBServicoFinalidade = new Etec.HardTechnologies.UI.GenesysDBServicoFinalidade();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sERVICOSABERTOSEENCERRADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesysDBAbertosEncerrados = new Etec.HardTechnologies.UI.GenesysDBAbertosEncerrados();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eXTRATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesysDBGanhosDebitos = new Etec.HardTechnologies.UI.GenesysDBGanhosDebitos();
            this.tbcMenus = new System.Windows.Forms.TabControl();
            this.Relatorios = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lOGINUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genesysDBUsuarios = new Etec.HardTechnologies.UI.GenesysDBUsuarios();
            this.Impressao = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.Recibo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtIDFinalizacao = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sERVICO_POR_FINALIDADETableAdapter = new Etec.HardTechnologies.UI.GenesysDBServicoFinalidadeTableAdapters.SERVICO_POR_FINALIDADETableAdapter();
            this.sERVICOS_ABERTOS_E_ENCERRADOSTableAdapter = new Etec.HardTechnologies.UI.GenesysDBAbertosEncerradosTableAdapters.SERVICOS_ABERTOS_E_ENCERRADOSTableAdapter();
            this.eXTRATOTableAdapter = new Etec.HardTechnologies.UI.GenesysDBGanhosDebitosTableAdapters.EXTRATOTableAdapter();
            this.FINALIZACAO_DE_SERVICOTableAdapter = new Etec.HardTechnologies.UI.GenesysDBFinalizacaoServicoTableAdapters.FINALIZACAO_DE_SERVICOTableAdapter();
            this.lOGIN_USUARIOTableAdapter = new Etec.HardTechnologies.UI.GenesysDBUsuariosTableAdapters.LOGIN_USUARIOTableAdapter();
            this.GenesysDBRecibo = new Etec.HardTechnologies.UI.GenesysDBRecibo();
            ((System.ComponentModel.ISupportInitialize)(this.FINALIZACAO_DE_SERVICOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesysDBFinalizacaoServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFinalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOPORFINALIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBServicoFinalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSABERTOSEENCERRADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBAbertosEncerrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXTRATOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBGanhosDebitos)).BeginInit();
            this.tbcMenus.SuspendLayout();
            this.Relatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBUsuarios)).BeginInit();
            this.Impressao.SuspendLayout();
            this.Recibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenesysDBRecibo)).BeginInit();
            this.SuspendLayout();
            // 
            // FINALIZACAO_DE_SERVICOBindingSource
            // 
            this.FINALIZACAO_DE_SERVICOBindingSource.DataMember = "FINALIZACAO DE SERVICO";
            this.FINALIZACAO_DE_SERVICOBindingSource.DataSource = this.GenesysDBFinalizacaoServico;
            // 
            // GenesysDBFinalizacaoServico
            // 
            this.GenesysDBFinalizacaoServico.DataSetName = "GenesysDBFinalizacaoServico";
            this.GenesysDBFinalizacaoServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chtFinalidade
            // 
            chartArea21.Name = "ChartArea1";
            this.chtFinalidade.ChartAreas.Add(chartArea21);
            this.chtFinalidade.DataSource = this.sERVICOPORFINALIDADEBindingSource;
            legend21.Name = "Legend1";
            legend21.Title = "Finalidade";
            this.chtFinalidade.Legends.Add(legend21);
            this.chtFinalidade.Location = new System.Drawing.Point(-4, 0);
            this.chtFinalidade.Name = "chtFinalidade";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series36.IsValueShownAsLabel = true;
            series36.Legend = "Legend1";
            series36.Name = "Dados";
            series36.XValueMember = "FINALIDADE";
            series36.YValueMembers = "Nº DE SERVIÇOS";
            this.chtFinalidade.Series.Add(series36);
            this.chtFinalidade.Size = new System.Drawing.Size(493, 220);
            this.chtFinalidade.TabIndex = 2;
            this.chtFinalidade.Text = "chart1";
            title21.Name = "Title1";
            title21.Text = "Nº de Serviços por Finalidade";
            this.chtFinalidade.Titles.Add(title21);
            // 
            // sERVICOPORFINALIDADEBindingSource
            // 
            this.sERVICOPORFINALIDADEBindingSource.DataMember = "SERVICO POR FINALIDADE";
            this.sERVICOPORFINALIDADEBindingSource.DataSource = this.genesysDBServicoFinalidade;
            // 
            // genesysDBServicoFinalidade
            // 
            this.genesysDBServicoFinalidade.DataSetName = "GenesysDBServicoFinalidade";
            this.genesysDBServicoFinalidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea22.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea22.AxisY.Title = "Nº de Serviços";
            chartArea22.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea22);
            this.chart1.DataSource = this.sERVICOSABERTOSEENCERRADOSBindingSource;
            legend22.Name = "Serviços:";
            legend22.Title = "Serviços";
            this.chart1.Legends.Add(legend22);
            this.chart1.Location = new System.Drawing.Point(495, 0);
            this.chart1.Name = "chart1";
            series37.ChartArea = "ChartArea1";
            series37.Legend = "Serviços:";
            series37.Name = "Abertos";
            series37.YValueMembers = "ABERTOS";
            series38.ChartArea = "ChartArea1";
            series38.Legend = "Serviços:";
            series38.Name = "Encerrados";
            series38.YValueMembers = "ENCERRADOS";
            this.chart1.Series.Add(series37);
            this.chart1.Series.Add(series38);
            this.chart1.Size = new System.Drawing.Size(562, 220);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title22.Name = "Title1";
            title22.Text = "Nº de Serviços Abertos / Encerrados";
            this.chart1.Titles.Add(title22);
            // 
            // sERVICOSABERTOSEENCERRADOSBindingSource
            // 
            this.sERVICOSABERTOSEENCERRADOSBindingSource.DataMember = "SERVICOS ABERTOS E ENCERRADOS";
            this.sERVICOSABERTOSEENCERRADOSBindingSource.DataSource = this.genesysDBAbertosEncerrados;
            // 
            // genesysDBAbertosEncerrados
            // 
            this.genesysDBAbertosEncerrados.DataSetName = "GenesysDBAbertosEncerrados";
            this.genesysDBAbertosEncerrados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart2
            // 
            chartArea23.AxisY.Interval = 20D;
            chartArea23.AxisY.Title = "Valor em R$";
            chartArea23.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea23);
            this.chart2.DataSource = this.eXTRATOBindingSource;
            legend23.Name = "Legend1";
            legend23.Title = "Valores";
            this.chart2.Legends.Add(legend23);
            this.chart2.Location = new System.Drawing.Point(495, 226);
            this.chart2.Name = "chart2";
            series39.BorderWidth = 3;
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Legend = "Legend1";
            series39.Name = "Receita";
            series39.XValueMember = "SERVICO";
            series39.YValueMembers = "RECEITA";
            series40.BorderWidth = 3;
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series40.Legend = "Legend1";
            series40.Name = "Débito";
            series40.XValueMember = "SERVICO";
            series40.YValueMembers = "DÉBITO";
            series41.BorderWidth = 3;
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series41.Legend = "Legend1";
            series41.Name = "Lucro";
            series41.XValueMember = "SERVICO";
            series41.YValueMembers = "LUCRO";
            series41.YValuesPerPoint = 3;
            this.chart2.Series.Add(series39);
            this.chart2.Series.Add(series40);
            this.chart2.Series.Add(series41);
            this.chart2.Size = new System.Drawing.Size(562, 252);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            title23.Name = "Title1";
            title23.Text = "Situação Financeira";
            this.chart2.Titles.Add(title23);
            // 
            // eXTRATOBindingSource
            // 
            this.eXTRATOBindingSource.DataMember = "EXTRATO";
            this.eXTRATOBindingSource.DataSource = this.genesysDBGanhosDebitos;
            // 
            // genesysDBGanhosDebitos
            // 
            this.genesysDBGanhosDebitos.DataSetName = "GenesysDBGanhosDebitos";
            this.genesysDBGanhosDebitos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcMenus
            // 
            this.tbcMenus.Controls.Add(this.Relatorios);
            this.tbcMenus.Controls.Add(this.Impressao);
            this.tbcMenus.Controls.Add(this.Recibo);
            this.tbcMenus.Location = new System.Drawing.Point(-1, 1);
            this.tbcMenus.Name = "tbcMenus";
            this.tbcMenus.SelectedIndex = 0;
            this.tbcMenus.Size = new System.Drawing.Size(1071, 504);
            this.tbcMenus.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbcMenus.TabIndex = 5;
            // 
            // Relatorios
            // 
            this.Relatorios.Controls.Add(this.chart3);
            this.Relatorios.Controls.Add(this.chart1);
            this.Relatorios.Controls.Add(this.chart2);
            this.Relatorios.Controls.Add(this.chtFinalidade);
            this.Relatorios.Location = new System.Drawing.Point(4, 22);
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Padding = new System.Windows.Forms.Padding(3);
            this.Relatorios.Size = new System.Drawing.Size(1063, 478);
            this.Relatorios.TabIndex = 0;
            this.Relatorios.Text = "Relatórios";
            this.Relatorios.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea24.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea24);
            this.chart3.DataSource = this.lOGINUSUARIOBindingSource;
            legend24.Name = "Legend1";
            legend24.Title = "Tipo de Usuário";
            this.chart3.Legends.Add(legend24);
            this.chart3.Location = new System.Drawing.Point(-4, 226);
            this.chart3.Name = "chart3";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series42.IsValueShownAsLabel = true;
            series42.Legend = "Legend1";
            series42.Name = "Series1";
            series42.XValueMember = "Nivel";
            series42.YValueMembers = "Qtd_ de Usuários";
            this.chart3.Series.Add(series42);
            this.chart3.Size = new System.Drawing.Size(493, 252);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            title24.Name = "Title1";
            title24.Text = "Quantidade de Usuários";
            this.chart3.Titles.Add(title24);
            // 
            // lOGINUSUARIOBindingSource
            // 
            this.lOGINUSUARIOBindingSource.DataMember = "LOGIN_USUARIO";
            this.lOGINUSUARIOBindingSource.DataSource = this.genesysDBUsuarios;
            // 
            // genesysDBUsuarios
            // 
            this.genesysDBUsuarios.DataSetName = "GenesysDBUsuarios";
            this.genesysDBUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Impressao
            // 
            this.Impressao.Controls.Add(this.reportViewer1);
            this.Impressao.Controls.Add(this.btnImprimir);
            this.Impressao.Location = new System.Drawing.Point(4, 22);
            this.Impressao.Name = "Impressao";
            this.Impressao.Padding = new System.Windows.Forms.Padding(3);
            this.Impressao.Size = new System.Drawing.Size(1063, 478);
            this.Impressao.TabIndex = 1;
            this.Impressao.Text = "Impressão";
            this.Impressao.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource12.Name = "ImpressaoRelatorio";
            reportDataSource12.Value = this.FINALIZACAO_DE_SERVICOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Etec.HardTechnologies.UI.rpvImpressao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1057, 472);
            this.reportViewer1.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(344, 23);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Recibo
            // 
            this.Recibo.Controls.Add(this.label1);
            this.Recibo.Controls.Add(this.btnGerar);
            this.Recibo.Controls.Add(this.txtIDFinalizacao);
            this.Recibo.Controls.Add(this.reportViewer2);
            this.Recibo.Location = new System.Drawing.Point(4, 22);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(1063, 478);
            this.Recibo.TabIndex = 2;
            this.Recibo.Text = "Recibo";
            this.Recibo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID da Finalização:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(231, 14);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(103, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar Recibo";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtIDFinalizacao
            // 
            this.txtIDFinalizacao.Enabled = false;
            this.txtIDFinalizacao.Location = new System.Drawing.Point(125, 16);
            this.txtIDFinalizacao.Name = "txtIDFinalizacao";
            this.txtIDFinalizacao.Size = new System.Drawing.Size(100, 20);
            this.txtIDFinalizacao.TabIndex = 1;
            this.txtIDFinalizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reportViewer2
            // 
            reportDataSource11.Name = "ImpressaoRecibo";
            reportDataSource11.Value = this.FINALIZACAO_DE_SERVICOBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Etec.HardTechnologies.UI.rpvRecibo.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-4, 45);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1064, 456);
            this.reportViewer2.TabIndex = 0;
            // 
            // sERVICO_POR_FINALIDADETableAdapter
            // 
            this.sERVICO_POR_FINALIDADETableAdapter.ClearBeforeFill = true;
            // 
            // sERVICOS_ABERTOS_E_ENCERRADOSTableAdapter
            // 
            this.sERVICOS_ABERTOS_E_ENCERRADOSTableAdapter.ClearBeforeFill = true;
            // 
            // eXTRATOTableAdapter
            // 
            this.eXTRATOTableAdapter.ClearBeforeFill = true;
            // 
            // FINALIZACAO_DE_SERVICOTableAdapter
            // 
            this.FINALIZACAO_DE_SERVICOTableAdapter.ClearBeforeFill = true;
            // 
            // lOGIN_USUARIOTableAdapter
            // 
            this.lOGIN_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // GenesysDBRecibo
            // 
            this.GenesysDBRecibo.DataSetName = "GenesysDBRecibo";
            this.GenesysDBRecibo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 501);
            this.Controls.Add(this.tbcMenus);
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FINALIZACAO_DE_SERVICOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenesysDBFinalizacaoServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFinalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOPORFINALIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBServicoFinalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSABERTOSEENCERRADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBAbertosEncerrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXTRATOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBGanhosDebitos)).EndInit();
            this.tbcMenus.ResumeLayout(false);
            this.Relatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBUsuarios)).EndInit();
            this.Impressao.ResumeLayout(false);
            this.Recibo.ResumeLayout(false);
            this.Recibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenesysDBRecibo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtFinalidade;
        
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage Impressao;
        private System.Windows.Forms.Button btnImprimir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GenesysDBServicoFinalidade genesysDBServicoFinalidade;
        private System.Windows.Forms.BindingSource sERVICOPORFINALIDADEBindingSource;
        private GenesysDBServicoFinalidadeTableAdapters.SERVICO_POR_FINALIDADETableAdapter sERVICO_POR_FINALIDADETableAdapter;
        private GenesysDBAbertosEncerrados genesysDBAbertosEncerrados;
        private System.Windows.Forms.BindingSource sERVICOSABERTOSEENCERRADOSBindingSource;
        private GenesysDBAbertosEncerradosTableAdapters.SERVICOS_ABERTOS_E_ENCERRADOSTableAdapter sERVICOS_ABERTOS_E_ENCERRADOSTableAdapter;
        private GenesysDBGanhosDebitos genesysDBGanhosDebitos;
        private System.Windows.Forms.BindingSource eXTRATOBindingSource;
        private GenesysDBGanhosDebitosTableAdapters.EXTRATOTableAdapter eXTRATOTableAdapter;
        private System.Windows.Forms.BindingSource FINALIZACAO_DE_SERVICOBindingSource;
        private GenesysDBFinalizacaoServico GenesysDBFinalizacaoServico;
        private GenesysDBFinalizacaoServicoTableAdapters.FINALIZACAO_DE_SERVICOTableAdapter FINALIZACAO_DE_SERVICOTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private GenesysDBUsuarios genesysDBUsuarios;
        private System.Windows.Forms.BindingSource lOGINUSUARIOBindingSource;
        private GenesysDBUsuariosTableAdapters.LOGIN_USUARIOTableAdapter lOGIN_USUARIOTableAdapter;
        private GenesysDBRecibo GenesysDBRecibo;
        public System.Windows.Forms.TabControl tbcMenus;
        public System.Windows.Forms.TabPage Relatorios;
        public System.Windows.Forms.TabPage Recibo;
        public System.Windows.Forms.TextBox txtIDFinalizacao;
    }
}