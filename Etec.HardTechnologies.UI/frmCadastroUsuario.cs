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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        CadastroUsuario usuario = new CadastroUsuario();
        CadastroUsuarioBO usuarioBO = new CadastroUsuarioBO();

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genesysDBFornecedor.FORNECEDOR' table. You can move, or remove it, as needed.
            this.fORNECEDORTableAdapter.Fill(this.genesysDBFornecedor.FORNECEDOR);
            // TODO: This line of code loads data into the 'genesysDBCliente.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.genesysDBCliente.CLIENTE);

            limparCampos();
            dgvUsuario.DataSource = usuarioBO.buscarUsuario();

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNivel.Text == "Fornecedor")
            {
                cmbFornecedor.Enabled = true;
            }
            else
            {
                cmbFornecedor.Enabled = false;
            }

            if (cmbNivel.Text == "Cliente")
            {
                cmbCliente.Enabled = true;
            }

            else
            {
                cmbCliente.Enabled = false;
            }
        }


        private void dgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDLogin.Text = dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbNivel.Text = dgvUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbCliente.Text = dgvUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbFornecedor.Text = dgvUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();

            habilitarCampos();
            atribuirCampos();
            
            btnExcluir.Enabled = true;
        }

        public void atribuirCampos()
        {
            usuario.IDLogin = int.Parse(txtIDLogin.Text);
            usuario.Usuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = cmbNivel.Text;
            usuario.Cliente = cmbCliente.Text;
            usuario.Fornecedor = cmbFornecedor.Text;
        }

        private void aposCadastro()
        {
            dgvUsuario.DataSource = usuarioBO.buscarUsuario();
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            cmbNivel.Enabled = false;
            cmbCliente.Enabled = false;
            cmbFornecedor.Enabled = false;
            btnNovo.Enabled = true;

            dgvUsuario.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            cmbNivel.Enabled = true;
            

            btnNovo.Enabled = true;
            dgvUsuario.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void limparCampos()
        {
            txtIDLogin.Text = ("0"); txtUsuario.Text = (""); txtSenha.Text = (""); cmbNivel.Text = ("");
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Tornar os Campos Enabled
            habilitarCampos();
            btnNovo.Enabled = false;
            dgvUsuario.Enabled = false;
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDLogin.Text == "0")
            {
                if (txtUsuario.Text == "" || txtSenha.Text == "" || cmbNivel.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    if (cmbCliente.Enabled == false)
                    {
                        usuario.Cliente = txtVazio.Text;
                    }
                    if (cmbFornecedor.Enabled == false)
                    {
                        usuario.Fornecedor = txtVazio.Text;
                    }
                    usuarioBO.cadastrar(usuario);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtUsuario.Text == "" || txtSenha.Text == "" || cmbNivel.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    if (cmbCliente.Enabled == false)
                    {
                        usuario.Cliente = txtVazio.Text;
                    }
                    if (cmbFornecedor.Enabled == false)
                    {
                        usuario.Fornecedor = txtVazio.Text;
                    }
                    
                    usuarioBO.atualizar(usuario);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Atualização realizada com Sucesso!", "Atualizar Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }

            }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons yesno = MessageBoxButtons.YesNo;
            DialogResult apagar = MessageBox.Show("Deseja Apagar o Registro?", "Apagar Registro?", yesno);
            if (apagar.ToString().ToUpper() == "YES")
            {
                atribuirCampos();
                usuarioBO.excluir(usuario);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvUsuario.DataSource = usuarioBO.buscarUsuario();
                aposCadastro();
                limparCampos();
            }
            else
            {
            }
        }
    }
}
