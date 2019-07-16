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
    public partial class frmEquipamento : Form
    {
        public frmEquipamento()
        {
            InitializeComponent();
        }

        Equipamento equipamento = new Equipamento();
        EquipamentoBO equipamentobo = new EquipamentoBO();

        public void atribuirCampos()
        {
            equipamento.IDEquipamento = int.Parse(txtIDEquipamento.Text);
            equipamento.Nome = txtNome.Text;
            equipamento.DtFabricacao = txtDtFabricacao.Text;
            equipamento.Modelo = txtModelo.Text;
            equipamento.NumeroSerie = txtNumeroSerie.Text;
            equipamento.VlCompra = decimal.Parse(txtVlCompra.Text);
            equipamento.Marca = txtMarca.Text;
            equipamento.Estoque = int.Parse(txtEstoque.Text);
        }

        private void aposCadastro()
        {
            //dgvEquipamento.DataSource = equipamentobo.buscarServico();
            txtIDEquipamento.Enabled = false;
            txtNome.Enabled = false;
            txtDtFabricacao.Enabled = false;
            txtModelo.Enabled = false;
            txtNumeroSerie.Enabled = false;
            txtVlCompra.Enabled = false;
            txtMarca.Enabled = false;
            txtEstoque.Enabled = false;
            btnNovo.Enabled = true;
            dgvEquipamento.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            dgvEquipamento.DataSource = equipamentobo.buscarEquipamento();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtDtFabricacao.Enabled = true;
            txtModelo.Enabled = true;
            txtNumeroSerie.Enabled = true;
            txtVlCompra.Enabled = true;
            txtEstoque.Enabled = true;
            txtMarca.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void limparCampos()
        {
            txtIDEquipamento.Text = ("0"); txtNome.Text = (""); txtDtFabricacao.Text = (""); txtModelo.Text = (""); txtNumeroSerie.Text = ("");
            txtVlCompra.Text = ("0"); txtMarca.Text = (""); txtEstoque.Text = ("");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Tornar os Campos Enabled
            habilitarCampos();
            btnNovo.Enabled = false;
            dgvEquipamento.Enabled = false;
            limparCampos();
            txtDtFabricacao.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDEquipamento.Text == "0")
            {
                if (txtNome.Text == "" || txtDtFabricacao.Text == "" || txtModelo.Text == "" || txtNumeroSerie.Text == "" || txtVlCompra.Text == "" || txtMarca.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    equipamentobo.cadastrar(equipamento);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtNome.Text == "" || txtDtFabricacao.Text == "" || txtModelo.Text == "" || txtNumeroSerie.Text == "" || txtVlCompra.Text == "" || txtMarca.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    equipamentobo.atualizar(equipamento);

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

        private void dgvEquipamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEquipamento.Text = dgvEquipamento.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvEquipamento.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDtFabricacao.Text = dgvEquipamento.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtModelo.Text = dgvEquipamento.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumeroSerie.Text = dgvEquipamento.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtVlCompra.Text = dgvEquipamento.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMarca.Text = dgvEquipamento.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEstoque.Text = dgvEquipamento.Rows[e.RowIndex].Cells[7].Value.ToString();
            habilitarCampos();
            atribuirCampos();
            btnExcluir.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons yesno = MessageBoxButtons.YesNo;
            DialogResult apagar = MessageBox.Show("Deseja Apagar o Registro?", "Apagar Registro?", yesno);
            if (apagar.ToString().ToUpper() == "YES")
            {
                atribuirCampos();
                equipamentobo.excluir(equipamento);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvEquipamento.DataSource = equipamentobo.buscarEquipamento();
                aposCadastro();
                limparCampos();
            }
            else
            {
            }

        }

        private void frmEquipamento_Load(object sender, EventArgs e)
        {
            dgvEquipamento.DataSource = equipamentobo.buscarEquipamento();
            dgvEquipamento.RowHeadersVisible = false;
        }
    }
}