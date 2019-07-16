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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        FornecedorBO fornecedorbo = new FornecedorBO();
        Fornecedor fornecedor = new Fornecedor();

        private void frmFornecedor_Load(object sender, EventArgs e)
        {

            dgvFornecedor.DataSource = fornecedorbo.buscarFornecedor();
            dgvFornecedor.RowHeadersVisible = false;

        }

        private void atribuirCampos()
        {
            fornecedor.IDFornecedor = int.Parse(txtIDFornecedor.Text);
            fornecedor.Razao = txtRazao.Text;
            fornecedor.Nome = txtNome.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Numero = txtNumero.Text;
            fornecedor.Complemento = txtComplemento.Text;
            fornecedor.CEP = txtCEP.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Estado = cmbEstado.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Celular = txtCelular.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.WebSite = txtSite.Text;
        }

        private void limparCampos()
        {
            txtIDFornecedor.Text = ("0"); txtRazao.Text = (""); txtNome.Text = (""); txtCNPJ.Text = (""); txtEndereco.Text = ("");
            txtNumero.Text = (""); txtComplemento.Text = (""); txtCEP.Text = (""); txtBairro.Text = ("");
            txtCidade.Text = (""); cmbEstado.Text = (""); ; txtTelefone.Text = ("");
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
            txtCEP.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbEstado.Enabled = true;
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
            txtCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtSite.Enabled = false;

            dgvFornecedor.Enabled = true;
            dgvFornecedor.DataSource = fornecedorbo.buscarFornecedor();
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
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
            dgvFornecedor.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDFornecedor.Text == "0")
            {
                if (txtRazao.Text == ("") || txtNome.Text == ("") || txtCNPJ.Text == ("") || txtEndereco.Text == ("") ||
                txtNumero.Text == ("") || txtCEP.Text == ("") || txtBairro.Text == ("") ||
                txtCidade.Text == ("") || cmbEstado.Text == ("") || txtTelefone.Text == ("") ||
                txtCelular.Text == ("") || txtEmail.Text == ("") || txtSite.Text == (""))
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    fornecedorbo.cadastrar(fornecedor);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtRazao.Text == ("") || txtNome.Text == ("") || txtCNPJ.Text == ("") || txtEndereco.Text == ("") ||
                txtNumero.Text == ("") || txtCEP.Text == ("") || txtBairro.Text == ("") ||
                txtCidade.Text == ("") || cmbEstado.Text == ("") || txtTelefone.Text == ("") ||
                txtCelular.Text == ("") || txtEmail.Text == ("") || txtSite.Text == (""))
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    fornecedorbo.atualizar(fornecedor);

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
                fornecedorbo.excluir(fornecedor);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvFornecedor.DataSource = fornecedorbo.buscarFornecedor();
                aposCadastro();
                limparCampos();
            }
            else
            {
            }
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDFornecedor.Text = dgvFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRazao.Text = dgvFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNome.Text = dgvFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCNPJ.Text = dgvFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = dgvFornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNumero.Text = dgvFornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtComplemento.Text = dgvFornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCEP.Text = dgvFornecedor.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBairro.Text = dgvFornecedor.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCidade.Text = dgvFornecedor.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbEstado.Text = dgvFornecedor.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtTelefone.Text = dgvFornecedor.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtCelular.Text = dgvFornecedor.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtEmail.Text = dgvFornecedor.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtSite.Text = dgvFornecedor.Rows[e.RowIndex].Cells[14].Value.ToString();
            atribuirCampos();
            habilitarCampos();
            btnExcluir.Enabled = true;
        }
    }
}
