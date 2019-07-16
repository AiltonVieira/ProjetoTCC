namespace Etec.HardTechnologies.UI
{
    partial class frmEquipamento
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvEquipamento = new System.Windows.Forms.DataGridView();
            this.lblServico = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIDMarca = new System.Windows.Forms.TextBox();
            this.txtIDEquipamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.txtVlCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtDtFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.genesysDBMarca = new Etec.HardTechnologies.UI.GenesysDBMarca();
            this.mARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCATableAdapter = new Etec.HardTechnologies.UI.GenesysDBMarcaTableAdapters.MARCATableAdapter();
            this.txtMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(547, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(285, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvEquipamento
            // 
            this.dgvEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamento.Location = new System.Drawing.Point(52, 137);
            this.dgvEquipamento.Name = "dgvEquipamento";
            this.dgvEquipamento.Size = new System.Drawing.Size(704, 201);
            this.dgvEquipamento.TabIndex = 9;
            this.dgvEquipamento.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamento_CellDoubleClick);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(341, 19);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(72, 13);
            this.lblServico.TabIndex = 13;
            this.lblServico.Text = "Equipamento:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(415, 350);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(160, 350);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo Cadastro";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(361, 108);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(87, 20);
            this.txtEstoque.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(154, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(125, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Enabled = false;
            this.txtNumeroSerie.Location = new System.Drawing.Point(361, 76);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroSerie.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(267, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtIDMarca
            // 
            this.txtIDMarca.Enabled = false;
            this.txtIDMarca.Location = new System.Drawing.Point(536, 108);
            this.txtIDMarca.Name = "txtIDMarca";
            this.txtIDMarca.Size = new System.Drawing.Size(60, 20);
            this.txtIDMarca.TabIndex = 8;
            // 
            // txtIDEquipamento
            // 
            this.txtIDEquipamento.Enabled = false;
            this.txtIDEquipamento.Location = new System.Drawing.Point(154, 45);
            this.txtIDEquipamento.Name = "txtIDEquipamento";
            this.txtIDEquipamento.Size = new System.Drawing.Size(60, 20);
            this.txtIDEquipamento.TabIndex = 0;
            this.txtIDEquipamento.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Valor de Compra:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(288, 112);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 49;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Nº de Série:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Data de Fabricação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(463, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "ID Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID:";
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(95, 112);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(40, 13);
            this.lblProblema.TabIndex = 52;
            this.lblProblema.Text = "Marca:";
            // 
            // txtVlCompra
            // 
            this.txtVlCompra.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtVlCompra.Enabled = false;
            this.txtVlCompra.HidePromptOnLeave = true;
            this.txtVlCompra.Location = new System.Drawing.Point(594, 76);
            this.txtVlCompra.Name = "txtVlCompra";
            this.txtVlCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVlCompra.Size = new System.Drawing.Size(86, 20);
            this.txtVlCompra.TabIndex = 5;
            // 
            // txtDtFabricacao
            // 
            this.txtDtFabricacao.Enabled = false;
            this.txtDtFabricacao.Location = new System.Drawing.Point(660, 45);
            this.txtDtFabricacao.Mask = "00/00/0000";
            this.txtDtFabricacao.Name = "txtDtFabricacao";
            this.txtDtFabricacao.Size = new System.Drawing.Size(60, 20);
            this.txtDtFabricacao.TabIndex = 2;
            this.txtDtFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // genesysDBMarca
            // 
            this.genesysDBMarca.DataSetName = "GenesysDBMarca";
            this.genesysDBMarca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARCABindingSource
            // 
            this.mARCABindingSource.DataMember = "MARCA";
            this.mARCABindingSource.DataSource = this.genesysDBMarca;
            // 
            // mARCATableAdapter
            // 
            this.mARCATableAdapter.ClearBeforeFill = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(154, 109);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(125, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // frmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 392);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIDMarca);
            this.Controls.Add(this.txtIDEquipamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.txtVlCompra);
            this.Controls.Add(this.txtDtFabricacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvEquipamento);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmEquipamento";
            this.Text = "frmEquipamento";
            this.Load += new System.EventHandler(this.frmEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesysDBMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvEquipamento;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIDMarca;
        private System.Windows.Forms.TextBox txtIDEquipamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.MaskedTextBox txtVlCompra;
        private System.Windows.Forms.MaskedTextBox txtDtFabricacao;
        private GenesysDBMarca genesysDBMarca;
        private System.Windows.Forms.BindingSource mARCABindingSource;
        private GenesysDBMarcaTableAdapters.MARCATableAdapter mARCATableAdapter;
        private System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.Button btnExcluir;
    }
}