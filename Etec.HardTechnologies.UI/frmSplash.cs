using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.HardTechnologies.UI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        public int acesso;

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            
            if (barraProgresso.Value < 100)
            {
                barraProgresso.Value = barraProgresso.Value + 1;
                lblCarregando.Text = barraProgresso.Value.ToString() + "%";
            }
            else
            {
                frmMenuPrincipal principal = new frmMenuPrincipal();
                frmLogin login = new frmLogin();
                tmrTempo.Stop();
                principal.mnsNomeUsuario.Text = lblUsuario.Text;
                if(lblNivel.Text == "Cliente" || lblNivel.Text == "Fornecedor")
                {
                    principal.btnAgenda.Visible = false;
                    principal.btnCliente.Visible = false;
                    principal.btnEquipamento.Visible = false;
                    principal.btnFornecedor.Visible = false;
                    principal.btnFuncionario.Visible = false;
                    principal.btnRelatorio.Visible = false;
                    principal.btnFinalizarServico.Visible = false;
                }

                if(lblNivel.Text == "Funcionario")
                {
                    principal.btnRelatorio.Visible = false;
                    principal.btnFuncionario.Visible = false;
                }

                this.Hide();
                principal.ShowDialog();
            }
        }

        private void barraProgresso_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            barraProgresso.Maximum = 100;
            tmrTempo.Start();
        }
    }
}
