namespace Etec.HardTechnologies.UI
{
    partial class frmContato
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblFaleConosco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lblPara = new System.Windows.Forms.Label();
            this.grbCredenciais = new System.Windows.Forms.GroupBox();
            this.cmbPorta = new System.Windows.Forms.ComboBox();
            this.grbCredenciais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(138, 411);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(90, 23);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblFaleConosco
            // 
            this.lblFaleConosco.AutoSize = true;
            this.lblFaleConosco.Location = new System.Drawing.Point(212, 10);
            this.lblFaleConosco.Name = "lblFaleConosco";
            this.lblFaleConosco.Size = new System.Drawing.Size(72, 13);
            this.lblFaleConosco.TabIndex = 12;
            this.lblFaleConosco.Text = "Fale Conosco";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(123, 114);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(266, 20);
            this.txtAssunto.TabIndex = 10;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(120, 98);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 11;
            this.lblAssunto.Text = "Assunto:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(123, 153);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(266, 141);
            this.txtMensagem.TabIndex = 10;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(120, 137);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(62, 13);
            this.lblMensagem.TabIndex = 11;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(256, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(69, 48);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(222, 20);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(22, 51);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(123, 76);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(266, 20);
            this.txtCC.TabIndex = 10;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(120, 60);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(24, 13);
            this.lblCC.TabIndex = 11;
            this.lblCC.Text = "CC:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(123, 39);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(266, 20);
            this.txtPara.TabIndex = 10;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(120, 23);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 11;
            this.lblPara.Text = "Para:";
            // 
            // grbCredenciais
            // 
            this.grbCredenciais.Controls.Add(this.cmbPorta);
            this.grbCredenciais.Controls.Add(this.txtSenha);
            this.grbCredenciais.Controls.Add(this.txtEmail);
            this.grbCredenciais.Controls.Add(this.lblSenha);
            this.grbCredenciais.Controls.Add(this.lblEmail);
            this.grbCredenciais.Location = new System.Drawing.Point(39, 300);
            this.grbCredenciais.Name = "grbCredenciais";
            this.grbCredenciais.Size = new System.Drawing.Size(368, 105);
            this.grbCredenciais.TabIndex = 14;
            this.grbCredenciais.TabStop = false;
            // 
            // cmbPorta
            // 
            this.cmbPorta.FormattingEnabled = true;
            this.cmbPorta.Items.AddRange(new object[] {
            "hotmail",
            "gmail"});
            this.cmbPorta.Location = new System.Drawing.Point(110, 74);
            this.cmbPorta.Name = "cmbPorta";
            this.cmbPorta.Size = new System.Drawing.Size(121, 21);
            this.cmbPorta.TabIndex = 12;
            // 
            // frmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 446);
            this.Controls.Add(this.grbCredenciais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblFaleConosco);
            this.Name = "frmContato";
            this.Text = "frmContato";
            this.Load += new System.EventHandler(this.frmContato_Load);
            this.grbCredenciais.ResumeLayout(false);
            this.grbCredenciais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblFaleConosco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.GroupBox grbCredenciais;
        private System.Windows.Forms.ComboBox cmbPorta;
    }
}