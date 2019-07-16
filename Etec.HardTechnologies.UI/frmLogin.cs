using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.HardTechnologies.BO;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        Login login = new Login();
        LoginBO loginbo = new LoginBO();
        frmSplash splash = new frmSplash();
        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();

            cmbNivel.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                login.Usuario = txtUsuario.Text;
                login.Senha = txtSenha.Text;
                login.Nivel = cmbNivel.Text;
                loginbo.logar(login);

                if (loginbo.logado == true)
                {
                    splash.lblUsuario.Text = txtUsuario.Text;
                    splash.lblNivel.Text = cmbNivel.Text;

                    this.Hide();
                    splash.ShowDialog();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
