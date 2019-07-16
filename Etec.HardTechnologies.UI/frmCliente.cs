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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        ClienteBO clientebo = new ClienteBO();
        Cliente cliente = new Cliente();

        private void frmCliente_Load(object sender, EventArgs e)
        {
            
            dgvCliente.DataSource = clientebo.buscarCliente();
            dgvCliente.RowHeadersVisible = false;
            
        }

        private void atribuirCampos()
        {
            cliente.IDCliente = int.Parse(txtIDCliente.Text);
            cliente.Razao = txtRazao.Text;
            cliente.Nome = txtNome.Text;
            cliente.CNPJ = txtCNPJ.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cmbEstado.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtEmail.Text;
            cliente.WebSite = txtSite.Text;
        }

        private void limparCampos()
        {
            txtIDCliente.Text = ("0"); txtRazao.Text = (""); txtNome.Text = (""); txtCNPJ.Text = (""); txtEndereco.Text = ("");
            txtNumero.Text = (""); txtComplemento.Text = (""); txtCidade.Text = (""); txtBairro.Text = ("");
            cmbEstado.Text = (""); txtCEP.Text = (""); txtTelefone.Text = ("");
            txtCelular.Text = (""); txtEmail.Text = (""); txtSite.Text = ("");
        }

        private void habilitarCampos()
        {
            txtRazao.Enabled = true;
            txtNome.Enabled = true;
            txtCNPJ.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            cmbEstado.Enabled = true;
            cmbPais.Enabled = true;
            txtCEP.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtSite.Enabled = true;

            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void aposCadastro()
        {
            txtRazao.Enabled = false;
            txtNome.Enabled = false;
            txtCNPJ.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            cmbEstado.Enabled = false;
            cmbPais.Enabled = false;
            txtCEP.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtSite.Enabled = false;

            dgvCliente.Enabled = true;
            dgvCliente.DataSource = clientebo.buscarCliente();
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Deseja Realmente Cancelar ?", "Deseja Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelar.ToString().ToUpper() == "YES")
            {
                this.Hide();
            }
            else
            {
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            dgvCliente.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == "0")
            {
                if (txtRazao.Text == ("") || txtNome.Text == ("") || txtCNPJ.Text == ("") || txtEndereco.Text == ("") ||
                txtNumero.Text == ("") || txtCidade.Text == ("") || txtBairro.Text == ("") ||
                cmbEstado.Text == ("") || txtCEP.Text == ("") || txtTelefone.Text == ("") ||
                txtCelular.Text == ("") || txtEmail.Text == ("") || txtSite.Text == (""))
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    clientebo.cadastrar(cliente);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtRazao.Text == ("") || txtNome.Text == ("") || txtCNPJ.Text == ("") || txtEndereco.Text == ("") ||
                txtNumero.Text == ("") || txtCidade.Text == ("") || txtBairro.Text == ("") ||
                cmbEstado.Text == ("") || txtCEP.Text == ("") || txtTelefone.Text == ("") ||
                txtCelular.Text == ("") || txtEmail.Text == ("") || txtSite.Text == (""))
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    clientebo.atualizar(cliente);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Atualização realizada com Sucesso!", "Atualizar Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons yesno = MessageBoxButtons.YesNo;
            DialogResult apagar = MessageBox.Show("Deseja Apagar o Registro?", "Apagar Registro?", yesno);
            if (apagar.ToString().ToUpper() == "YES")
            {
                atribuirCampos();
                clientebo.excluir(cliente);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvCliente.DataSource = clientebo.buscarCliente();
                aposCadastro();
                limparCampos();
            }
            else
            {
            }
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCliente.Text = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRazao.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNome.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCNPJ.Text = dgvCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = dgvCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNumero.Text = dgvCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtComplemento.Text = dgvCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCEP.Text = dgvCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBairro.Text = dgvCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCidade.Text = dgvCliente.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbEstado.Text = dgvCliente.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtTelefone.Text = dgvCliente.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtCelular.Text = dgvCliente.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtEmail.Text = dgvCliente.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtSite.Text = dgvCliente.Rows[e.RowIndex].Cells[14].Value.ToString();
            atribuirCampos();
            habilitarCampos();
            btnExcluir.Enabled = true;
        }
    }
}
