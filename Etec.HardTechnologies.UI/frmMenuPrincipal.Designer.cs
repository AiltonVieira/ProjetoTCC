namespace Etec.HardTechnologies.UI
{
    partial class frmMenuPrincipal
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
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblGenesys = new System.Windows.Forms.Label();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.mnsNomeUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFinalizarServico = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.pnlBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraMenu
            // 
            this.pnlBarraMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlBarraMenu.Controls.Add(this.pcbUsuario);
            this.pnlBarraMenu.Controls.Add(this.pictureBox1);
            this.pnlBarraMenu.Controls.Add(this.lblData);
            this.pnlBarraMenu.Controls.Add(this.lblHora);
            this.pnlBarraMenu.Controls.Add(this.lblGenesys);
            this.pnlBarraMenu.Controls.Add(this.mnsMenu);
            this.pnlBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraMenu.Name = "pnlBarraMenu";
            this.pnlBarraMenu.Size = new System.Drawing.Size(772, 41);
            this.pnlBarraMenu.TabIndex = 0;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Location = new System.Drawing.Point(434, 0);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(54, 41);
            this.pcbUsuario.TabIndex = 2;
            this.pcbUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 41);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(692, 22);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            this.lblData.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(701, 5);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblGenesys
            // 
            this.lblGenesys.AutoSize = true;
            this.lblGenesys.Location = new System.Drawing.Point(55, 15);
            this.lblGenesys.Name = "lblGenesys";
            this.lblGenesys.Size = new System.Drawing.Size(48, 13);
            this.lblGenesys.TabIndex = 1;
            this.lblGenesys.Text = "Genesys";
            // 
            // mnsMenu
            // 
            this.mnsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsNomeUsuario});
            this.mnsMenu.Location = new System.Drawing.Point(510, 9);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsMenu.Size = new System.Drawing.Size(160, 24);
            this.mnsMenu.TabIndex = 14;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // mnsNomeUsuario
            // 
            this.mnsNomeUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastrarUsuario,
            this.toolStripSeparator1,
            this.mnsTrocarUsuario,
            this.mnsSair});
            this.mnsNomeUsuario.Name = "mnsNomeUsuario";
            this.mnsNomeUsuario.Size = new System.Drawing.Size(60, 20);
            this.mnsNomeUsuario.Text = "Gerente";
            // 
            // mnsCadastrarUsuario
            // 
            this.mnsCadastrarUsuario.Name = "mnsCadastrarUsuario";
            this.mnsCadastrarUsuario.Size = new System.Drawing.Size(167, 22);
            this.mnsCadastrarUsuario.Text = "Cadastrar Usuario";
            this.mnsCadastrarUsuario.Click += new System.EventHandler(this.mnsCadastrarUsuario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // mnsTrocarUsuario
            // 
            this.mnsTrocarUsuario.Name = "mnsTrocarUsuario";
            this.mnsTrocarUsuario.Size = new System.Drawing.Size(167, 22);
            this.mnsTrocarUsuario.Text = "TrocarUsuario";
            this.mnsTrocarUsuario.Click += new System.EventHandler(this.mnsTrocarUsuario_Click);
            // 
            // mnsSair
            // 
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(167, 22);
            this.mnsSair.Text = "Sair";
            this.mnsSair.Click += new System.EventHandler(this.mnsSair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCliente.Location = new System.Drawing.Point(250, 172);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(116, 104);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFinalizarServico
            // 
            this.btnFinalizarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFinalizarServico.Location = new System.Drawing.Point(128, 173);
            this.btnFinalizarServico.Name = "btnFinalizarServico";
            this.btnFinalizarServico.Size = new System.Drawing.Size(116, 214);
            this.btnFinalizarServico.TabIndex = 4;
            this.btnFinalizarServico.Text = "Finalizar Serviço";
            this.btnFinalizarServico.UseVisualStyleBackColor = false;
            this.btnFinalizarServico.Click += new System.EventHandler(this.btnFinalizarServico_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(494, 283);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(116, 104);
            this.btnSobre.TabIndex = 5;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFuncionario.Location = new System.Drawing.Point(372, 172);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(116, 104);
            this.btnFuncionario.TabIndex = 7;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnServico
            // 
            this.btnServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnServico.Location = new System.Drawing.Point(128, 63);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(238, 104);
            this.btnServico.TabIndex = 8;
            this.btnServico.Text = "Serviço";
            this.btnServico.UseVisualStyleBackColor = false;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.Purple;
            this.btnFornecedor.Location = new System.Drawing.Point(372, 282);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(116, 104);
            this.btnFornecedor.TabIndex = 9;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgenda.Location = new System.Drawing.Point(372, 62);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(116, 104);
            this.btnAgenda.TabIndex = 10;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Purple;
            this.btnRelatorio.Location = new System.Drawing.Point(250, 282);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(116, 104);
            this.btnRelatorio.TabIndex = 12;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEquipamento.Location = new System.Drawing.Point(494, 62);
            this.btnEquipamento.Name = "btnEquipamento";
            this.btnEquipamento.Size = new System.Drawing.Size(116, 104);
            this.btnEquipamento.TabIndex = 13;
            this.btnEquipamento.Text = "Equipamento";
            this.btnEquipamento.UseVisualStyleBackColor = false;
            this.btnEquipamento.Click += new System.EventHandler(this.btnEquipamento_Click);
            // 
            // btnContato
            // 
            this.btnContato.BackColor = System.Drawing.Color.White;
            this.btnContato.Location = new System.Drawing.Point(494, 172);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(116, 104);
            this.btnContato.TabIndex = 5;
            this.btnContato.Text = "Contato";
            this.btnContato.UseVisualStyleBackColor = false;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 395);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFinalizarServico);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnServico);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEquipamento);
            this.Controls.Add(this.pnlBarraMenu);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlBarraMenu.ResumeLayout(false);
            this.pnlBarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblGenesys;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.Button btnServico;
        public System.Windows.Forms.Button btnCliente;
        public System.Windows.Forms.Button btnFinalizarServico;
        public System.Windows.Forms.Button btnSobre;
        public System.Windows.Forms.Button btnFuncionario;
        public System.Windows.Forms.Button btnFornecedor;
        public System.Windows.Forms.Button btnAgenda;
        public System.Windows.Forms.Button btnRelatorio;
        public System.Windows.Forms.Button btnEquipamento;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnsTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnsSair;
        public System.Windows.Forms.ToolStripMenuItem mnsNomeUsuario;
        public System.Windows.Forms.Button btnContato;
        public System.Windows.Forms.ToolStripMenuItem mnsCadastrarUsuario;
    }
}