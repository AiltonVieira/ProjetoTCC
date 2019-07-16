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

namespace Etec.HardTechnologies.UI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        frmSplash splash = new frmSplash();
        frmLogin login = new frmLogin();
        

        public void btnServico_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            if (btnFuncionario.Visible == false)
            {
                servico.btnExcluir.Visible = false;
                servico.dgvServico.Visible = false;
            }
            servico.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
            if (btnRelatorio.Visible == false)
            {
                cliente.btnExcluir.Visible = false;
            }
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            frmEquipamento equipamento = new frmEquipamento();
            equipamento.ShowDialog();
            if (btnRelatorio.Visible == false)
            {
                equipamento.btnExcluir.Visible = false;
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.ShowDialog();

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.ShowDialog();
            if (btnRelatorio.Visible == false)
            {
                fornecedor.btnExcluir.Visible = false;
            }
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblData.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }


        private void btnFinalizarServico_Click(object sender, EventArgs e)
        {
            frmFinalizarServico fservico = new frmFinalizarServico();
            
            if (btnRelatorio.Visible == false)
            {
                fservico.btnExcluir.Visible = false;
            }
            fservico.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new frmRelatorio().ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            new frmSobre().ShowDialog();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            new frmAgenda().ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Deseja Realmente Sair ?", "Deseja Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelar.ToString().ToUpper() == "YES")
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void mnsTrocarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Deseja fazer logoff ?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelar.ToString().ToUpper() == "YES")
            {
                Application.Restart();
            }
            else
            {
            }
        }

        private void mnsCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastro = new frmCadastroUsuario();
            cadastro.ShowDialog();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {

        }
    }
}
