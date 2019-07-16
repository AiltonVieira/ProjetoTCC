namespace Etec.HardTechnologies.UI
{
    partial class frmFinalizarServico
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDtVencimento = new System.Windows.Forms.Label();
            this.lblIDServico = new System.Windows.Forms.Label();
            this.txtIDServico = new System.Windows.Forms.TextBox();
            this.txtIDFinalizacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dgvFinalizarServico = new System.Windows.Forms.DataGridView();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDtEncerramento = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.btnGerarRecibo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizarServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(532, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(175, 374);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvServico
            // 
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(47, 204);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(704, 152);
            this.dgvServico.TabIndex = 37;
            this.dgvServico.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentDoubleClick);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(342, 25);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(84, 13);
            this.lblServico.TabIndex = 27;
            this.lblServico.Text = "Finalizar Serviço";
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(77, 122);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(34, 13);
            this.lblElemento.TabIndex = 25;
            this.lblElemento.Text = "Valor:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(284, 95);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(111, 13);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Forma de Pagamento:";
            // 
            // lblDtVencimento
            // 
            this.lblDtVencimento.AutoSize = true;
            this.lblDtVencimento.Location = new System.Drawing.Point(73, 95);
            this.lblDtVencimento.Name = "lblDtVencimento";
            this.lblDtVencimento.Size = new System.Drawing.Size(117, 13);
            this.lblDtVencimento.TabIndex = 22;
            this.lblDtVencimento.Text = "Data de Encerramento:";
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.Location = new System.Drawing.Point(225, 64);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(60, 13);
            this.lblIDServico.TabIndex = 19;
            this.lblIDServico.Text = "ID Serviço:";
            // 
            // txtIDServico
            // 
            this.txtIDServico.Enabled = false;
            this.txtIDServico.Location = new System.Drawing.Point(291, 61);
            this.txtIDServico.Name = "txtIDServico";
            this.txtIDServico.Size = new System.Drawing.Size(60, 20);
            this.txtIDServico.TabIndex = 31;
            // 
            // txtIDFinalizacao
            // 
            this.txtIDFinalizacao.Enabled = false;
            this.txtIDFinalizacao.Location = new System.Drawing.Point(157, 61);
            this.txtIDFinalizacao.Name = "txtIDFinalizacao";
            this.txtIDFinalizacao.Size = new System.Drawing.Size(60, 20);
            this.txtIDFinalizacao.TabIndex = 31;
            this.txtIDFinalizacao.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Finalização:";
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Enabled = false;
            this.txtRelatorio.Location = new System.Drawing.Point(133, 144);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(358, 47);
            this.txtRelatorio.TabIndex = 31;
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Location = new System.Drawing.Point(75, 147);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(52, 13);
            this.lblRelatorio.TabIndex = 19;
            this.lblRelatorio.Text = "Relatório:";
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Items.AddRange(new object[] {
            "Serviços Em Aberto",
            "Serviços Encerrados"});
            this.cmbConsultar.Location = new System.Drawing.Point(588, 170);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(133, 21);
            this.cmbConsultar.TabIndex = 34;
            this.cmbConsultar.SelectedIndexChanged += new System.EventHandler(this.cmbConsultar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Consultar:";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.Enabled = false;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Items.AddRange(new object[] {
            "1 - Dinheiro",
            "2 - Débito",
            "3 - Crédito"});
            this.cmbFormaPagamento.Location = new System.Drawing.Point(401, 92);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(106, 21);
            this.cmbFormaPagamento.TabIndex = 30;
            // 
            // dgvFinalizarServico
            // 
            this.dgvFinalizarServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalizarServico.Location = new System.Drawing.Point(47, 204);
            this.dgvFinalizarServico.Name = "dgvFinalizarServico";
            this.dgvFinalizarServico.Size = new System.Drawing.Size(704, 152);
            this.dgvFinalizarServico.TabIndex = 37;
            this.dgvFinalizarServico.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinalizarServico_CellContentDoubleClick);
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Location = new System.Drawing.Point(237, 120);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(51, 17);
            this.chkPago.TabIndex = 42;
            this.chkPago.Text = "Pago";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(294, 374);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtDtEncerramento
            // 
            this.txtDtEncerramento.Enabled = false;
            this.txtDtEncerramento.Location = new System.Drawing.Point(196, 92);
            this.txtDtEncerramento.Mask = "00/00/0000";
            this.txtDtEncerramento.Name = "txtDtEncerramento";
            this.txtDtEncerramento.Size = new System.Drawing.Size(69, 20);
            this.txtDtEncerramento.TabIndex = 43;
            this.txtDtEncerramento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDtEncerramento.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtValor.Location = new System.Drawing.Point(117, 118);
            this.txtValor.Mask = "00000000.00";
            this.txtValor.Name = "txtValor";
            this.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValor.Size = new System.Drawing.Size(111, 20);
            this.txtValor.TabIndex = 43;
            this.txtValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnGerarRecibo
            // 
            this.btnGerarRecibo.Enabled = false;
            this.btnGerarRecibo.Location = new System.Drawing.Point(411, 374);
            this.btnGerarRecibo.Name = "btnGerarRecibo";
            this.btnGerarRecibo.Size = new System.Drawing.Size(90, 23);
            this.btnGerarRecibo.TabIndex = 41;
            this.btnGerarRecibo.Text = "Gerar Recibo";
            this.btnGerarRecibo.UseVisualStyleBackColor = true;
            this.btnGerarRecibo.Click += new System.EventHandler(this.btnGerarRecibo_Click);
            // 
            // frmFinalizarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 427);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDtEncerramento);
            this.Controls.Add(this.chkPago);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGerarRecibo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvFinalizarServico);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.cmbFormaPagamento);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDtVencimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRelatorio);
            this.Controls.Add(this.lblIDServico);
            this.Controls.Add(this.txtIDFinalizacao);
            this.Controls.Add(this.txtRelatorio);
            this.Controls.Add(this.txtIDServico);
            this.Name = "frmFinalizarServico";
            this.Text = "frmFinalizarServico";
            this.Load += new System.EventHandler(this.frmFinalizarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizarServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDtVencimento;
        private System.Windows.Forms.Label lblIDServico;
        private System.Windows.Forms.TextBox txtIDServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.ComboBox cmbConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.DataGridView dgvFinalizarServico;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.MaskedTextBox txtDtEncerramento;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Button btnGerarRecibo;
        public System.Windows.Forms.TextBox txtIDFinalizacao;
        public System.Windows.Forms.Button btnExcluir;
    }
}