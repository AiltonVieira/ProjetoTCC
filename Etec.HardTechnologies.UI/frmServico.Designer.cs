namespace Etec.HardTechnologies.UI
{
    partial class frmServico
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtIDServico = new System.Windows.Forms.TextBox();
            this.txtDtAbertura = new System.Windows.Forms.MaskedTextBox();
            this.lblIDServico = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.txtDtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDtAbertura = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDtVencimento = new System.Windows.Forms.Label();
            this.lblFinalidade = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.lblImpacto = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            this.cmbImpacto = new System.Windows.Forms.ComboBox();
            this.cmbFinalidade = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(166, 357);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo Cadastro";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtIDServico
            // 
            this.txtIDServico.Enabled = false;
            this.txtIDServico.Location = new System.Drawing.Point(143, 53);
            this.txtIDServico.Name = "txtIDServico";
            this.txtIDServico.Size = new System.Drawing.Size(60, 20);
            this.txtIDServico.TabIndex = 5;
            this.txtIDServico.Text = "0";
            // 
            // txtDtAbertura
            // 
            this.txtDtAbertura.Enabled = false;
            this.txtDtAbertura.Location = new System.Drawing.Point(314, 53);
            this.txtDtAbertura.Mask = "00/00/0000";
            this.txtDtAbertura.Name = "txtDtAbertura";
            this.txtDtAbertura.Size = new System.Drawing.Size(76, 20);
            this.txtDtAbertura.TabIndex = 2;
            this.txtDtAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.Location = new System.Drawing.Point(80, 57);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(60, 13);
            this.lblIDServico.TabIndex = 3;
            this.lblIDServico.Text = "ID Serviço:";
            // 
            // txtElemento
            // 
            this.txtElemento.Enabled = false;
            this.txtElemento.Location = new System.Drawing.Point(521, 94);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(166, 20);
            this.txtElemento.TabIndex = 7;
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Location = new System.Drawing.Point(444, 53);
            this.txtHorario.Mask = "90:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(48, 20);
            this.txtHorario.TabIndex = 3;
            this.txtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtVencimento
            // 
            this.txtDtVencimento.Enabled = false;
            this.txtDtVencimento.Location = new System.Drawing.Point(616, 53);
            this.txtDtVencimento.Mask = "00/00/0000";
            this.txtDtVencimento.Name = "txtDtVencimento";
            this.txtDtVencimento.Size = new System.Drawing.Size(71, 20);
            this.txtDtVencimento.TabIndex = 4;
            this.txtDtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDtAbertura
            // 
            this.lblDtAbertura.AutoSize = true;
            this.lblDtAbertura.Location = new System.Drawing.Point(217, 57);
            this.lblDtAbertura.Name = "lblDtAbertura";
            this.lblDtAbertura.Size = new System.Drawing.Size(91, 13);
            this.lblDtAbertura.TabIndex = 3;
            this.lblDtAbertura.Text = "Data de Abertura:";
            // 
            // txtProblema
            // 
            this.txtProblema.Enabled = false;
            this.txtProblema.Location = new System.Drawing.Point(146, 171);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(577, 48);
            this.txtProblema.TabIndex = 10;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(398, 57);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horário:";
            // 
            // lblDtVencimento
            // 
            this.lblDtVencimento.AutoSize = true;
            this.lblDtVencimento.Location = new System.Drawing.Point(503, 57);
            this.lblDtVencimento.Name = "lblDtVencimento";
            this.lblDtVencimento.Size = new System.Drawing.Size(107, 13);
            this.lblDtVencimento.TabIndex = 3;
            this.lblDtVencimento.Text = "Data de Vencimento:";
            // 
            // lblFinalidade
            // 
            this.lblFinalidade.AutoSize = true;
            this.lblFinalidade.Location = new System.Drawing.Point(80, 98);
            this.lblFinalidade.Name = "lblFinalidade";
            this.lblFinalidade.Size = new System.Drawing.Size(58, 13);
            this.lblFinalidade.TabIndex = 3;
            this.lblFinalidade.Text = "Finalidade:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(280, 98);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(461, 98);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(54, 13);
            this.lblElemento.TabIndex = 3;
            this.lblElemento.Text = "Elemento:";
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Location = new System.Drawing.Point(80, 136);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(53, 13);
            this.lblUrgencia.TabIndex = 3;
            this.lblUrgencia.Text = "Urgência:";
            // 
            // lblImpacto
            // 
            this.lblImpacto.AutoSize = true;
            this.lblImpacto.Location = new System.Drawing.Point(280, 136);
            this.lblImpacto.Name = "lblImpacto";
            this.lblImpacto.Size = new System.Drawing.Size(48, 13);
            this.lblImpacto.TabIndex = 3;
            this.lblImpacto.Text = "Impacto:";
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(80, 171);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(54, 13);
            this.lblProblema.TabIndex = 3;
            this.lblProblema.Text = "Problema:";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(347, 26);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 3;
            this.lblServico.Text = "Serviço";
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.Enabled = false;
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Location = new System.Drawing.Point(143, 132);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(97, 21);
            this.cmbUrgencia.TabIndex = 8;
            // 
            // cmbImpacto
            // 
            this.cmbImpacto.Enabled = false;
            this.cmbImpacto.FormattingEnabled = true;
            this.cmbImpacto.Location = new System.Drawing.Point(341, 132);
            this.cmbImpacto.Name = "cmbImpacto";
            this.cmbImpacto.Size = new System.Drawing.Size(97, 21);
            this.cmbImpacto.TabIndex = 9;
            // 
            // cmbFinalidade
            // 
            this.cmbFinalidade.Enabled = false;
            this.cmbFinalidade.FormattingEnabled = true;
            this.cmbFinalidade.Items.AddRange(new object[] {
            "Instalação",
            "Manutenção",
            "Remoção"});
            this.cmbFinalidade.Location = new System.Drawing.Point(143, 94);
            this.cmbFinalidade.Name = "cmbFinalidade";
            this.cmbFinalidade.Size = new System.Drawing.Size(97, 21);
            this.cmbFinalidade.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(421, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvServico
            // 
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(52, 236);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(704, 103);
            this.dgvServico.TabIndex = 11;
            this.dgvServico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(553, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(291, 357);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Computador",
            "Servidor/Rede",
            "Hardware",
            "Software"});
            this.cmbCategoria.Location = new System.Drawing.Point(341, 93);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(97, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 392);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbFinalidade);
            this.Controls.Add(this.cmbImpacto);
            this.Controls.Add(this.cmbUrgencia);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblImpacto);
            this.Controls.Add(this.lblUrgencia);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFinalidade);
            this.Controls.Add(this.lblDtVencimento);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblDtAbertura);
            this.Controls.Add(this.lblIDServico);
            this.Controls.Add(this.txtDtVencimento);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtDtAbertura);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtIDServico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmServico";
            this.Text = "frmServico";
            this.Load += new System.EventHandler(this.frmServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtIDServico;
        private System.Windows.Forms.MaskedTextBox txtDtAbertura;
        private System.Windows.Forms.Label lblIDServico;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.MaskedTextBox txtDtVencimento;
        private System.Windows.Forms.Label lblDtAbertura;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDtVencimento;
        private System.Windows.Forms.Label lblFinalidade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.Label lblImpacto;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.ComboBox cmbUrgencia;
        private System.Windows.Forms.ComboBox cmbImpacto;
        private System.Windows.Forms.ComboBox cmbFinalidade;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.DataGridView dgvServico;
    }
}