namespace Etec.HardTechnologies.UI
{
    partial class frmSplash
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
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.lblGenesys = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrTempo
            // 
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(68, 236);
            this.barraProgresso.MarqueeAnimationSpeed = 40;
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(534, 10);
            this.barraProgresso.TabIndex = 0;
            this.barraProgresso.Click += new System.EventHandler(this.barraProgresso_Click);
            // 
            // lblGenesys
            // 
            this.lblGenesys.AutoSize = true;
            this.lblGenesys.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenesys.Location = new System.Drawing.Point(87, 110);
            this.lblGenesys.Name = "lblGenesys";
            this.lblGenesys.Size = new System.Drawing.Size(155, 39);
            this.lblGenesys.TabIndex = 1;
            this.lblGenesys.Text = "Genesys";
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Location = new System.Drawing.Point(294, 254);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(62, 13);
            this.lblCarregando.TabIndex = 2;
            this.lblCarregando.Text = "Carregando";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Enabled = false;
            this.lblUsuario.Location = new System.Drawing.Point(158, 163);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "label1";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Enabled = false;
            this.lblNivel.Location = new System.Drawing.Point(248, 186);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(35, 13);
            this.lblNivel.TabIndex = 15;
            this.lblNivel.Text = "label1";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Enabled = false;
            this.lblBemVindo.Location = new System.Drawing.Point(91, 163);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(61, 13);
            this.lblBemVindo.TabIndex = 15;
            this.lblBemVindo.Text = "Bem Vindo:";
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Enabled = false;
            this.lblPermissao.Location = new System.Drawing.Point(110, 186);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(132, 13);
            this.lblPermissao.TabIndex = 15;
            this.lblPermissao.Text = "Você tem permissão nível:";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 305);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblPermissao);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.lblGenesys);
            this.Controls.Add(this.barraProgresso);
            this.Name = "frmSplash";
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Label lblGenesys;
        private System.Windows.Forms.Label lblCarregando;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblNivel;
        public System.Windows.Forms.Label lblBemVindo;
        public System.Windows.Forms.Label lblPermissao;
    }
}