using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.BO;

namespace Etec.HardTechnologies.UI
{
    public partial class frmFinalizarServico : Form
    {
        public frmFinalizarServico()
        {
            InitializeComponent();
        }
        FinalizarServico fservico = new FinalizarServico();
        FinalizarServicoBO fservicobo = new FinalizarServicoBO();

        public void atribuirCampos()
        {
            fservico.IDFinalizacao = int.Parse(txtIDFinalizacao.Text);
            fservico.IDServico = int.Parse(txtIDServico.Text);
            fservico.Relatorio = txtRelatorio.Text;
            fservico.DtEncerramento = txtDtEncerramento.Text;
            fservico.FormaPagamento = cmbFormaPagamento.Text;
            fservico.Valor = txtValor.Text;
            fservico.Pago = chkPago.Checked;
        }

        private void aposCadastro()
        {
            dgvServico.DataSource = fservicobo.buscarServico();
            dgvFinalizarServico.DataSource = fservicobo.buscarFServico();
            txtRelatorio.Enabled = false;
            txtDtEncerramento.Enabled = false;
            cmbFormaPagamento.Enabled = false;
            txtValor.Enabled = false;
            chkPago.Enabled = false;
         
            btnExcluir.Enabled = false;
            dgvServico.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtRelatorio.Enabled = true;
            txtDtEncerramento.Enabled = true;
            cmbFormaPagamento.Enabled = true;
            txtValor.Enabled = true;
            chkPago.Enabled = true;

            btnExcluir.Enabled = true;
            dgvServico.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void limparCampos()
        {
            txtIDServico.Text = (""); txtIDFinalizacao.Text = ("0"); txtRelatorio.Text = (""); txtDtEncerramento.Text = ("");
            cmbFormaPagamento.Text = (""); txtValor.Text = ("");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDFinalizacao.Text == "0")
            {
                if (txtIDServico.Text == "" || txtRelatorio.Text == "" || txtDtEncerramento.Text == "" || cmbFormaPagamento.Text == "" || txtValor.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    fservicobo.cadastrar(fservico);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtIDServico.Text == "" || txtRelatorio.Text == "" || txtDtEncerramento.Text == "" || cmbFormaPagamento.Text == "" || txtValor.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    fservicobo.atualizar(fservico);

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
                fservicobo.excluir(fservico);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvServico.DataSource = fservicobo.buscarServico();
                aposCadastro();
                limparCampos();
            }
            else
            {
            }

        }

        private void frmFinalizarServico_Load(object sender, EventArgs e)
        {
            dgvServico.DataSource = fservicobo.buscarServico();
            dgvServico.RowHeadersVisible = false;

            dgvFinalizarServico.DataSource = fservicobo.buscarFServico();
            dgvFinalizarServico.RowHeadersVisible = false;

            cmbConsultar.SelectedIndex = 0;
            cmbFormaPagamento.SelectedIndex = 0;

            //dgvFinalizarServico.Columns["Pago"].Visible = false;
        }

        private void cmbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbConsultar.Text == "Serviços Em Aberto")
            {
                dgvFinalizarServico.Visible = false;
            }
            else if(cmbConsultar.Text == "Serviços Encerrados")
            {
                dgvFinalizarServico.Visible = true;
            }


        }

        private void dgvFinalizarServico_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDFinalizacao.Text = dgvFinalizarServico.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIDServico.Text = dgvFinalizarServico.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRelatorio.Text = dgvFinalizarServico.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDtEncerramento.Text = dgvFinalizarServico.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbFormaPagamento.Text = dgvFinalizarServico.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtValor.Text = dgvFinalizarServico.Rows[e.RowIndex].Cells[5].Value.ToString();
            chkPago.Checked = Convert.ToBoolean(dgvFinalizarServico.Rows[e.RowIndex].Cells[6].Value.ToString());
            habilitarCampos();
            atribuirCampos();
            cmbConsultar.Enabled = false;

            if (chkPago.Checked == true)
            {
                btnGerarRecibo.Enabled = true;
            }
        }

        private void dgvServico_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDServico.Text = dgvServico.Rows[e.RowIndex].Cells[0].Value.ToString();
            habilitarCampos();
            atribuirCampos();
            cmbConsultar.Enabled = false;
        }

        private void btnGerarRecibo_Click(object sender, EventArgs e)
        {
            
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.txtIDFinalizacao.Text = txtIDFinalizacao.Text;
            relatorio.ShowDialog();
        }
    }
}

