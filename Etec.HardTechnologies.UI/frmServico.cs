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
    public partial class frmServico : Form
    {


        public frmServico()
        {
            InitializeComponent();
        }

        Servico servico = new Servico();
        ServicoBO servicobo = new ServicoBO();

        public void atribuirCampos()
        {
            servico.IDServico = int.Parse(txtIDServico.Text);
            servico.DtAbertura = txtDtAbertura.Text;
            servico.Horario = txtHorario.Text;
            servico.DtVencimento = txtDtVencimento.Text;
            servico.Finalidade = cmbFinalidade.Text;
            servico.Categoria = cmbCategoria.Text;
            servico.Elemento = txtElemento.Text;
            servico.Urgencia = cmbUrgencia.Text;
            servico.Impacto = cmbImpacto.Text;
            servico.Problema = txtProblema.Text;
        }

        private void aposCadastro()
        {
            dgvServico.DataSource = servicobo.buscarServico();
            txtDtAbertura.Enabled = false;
            txtHorario.Enabled = false;
            txtDtVencimento.Enabled = false;
            cmbFinalidade.Enabled = false;
            cmbCategoria.Enabled = false;
            txtElemento.Enabled = false;
            cmbUrgencia.Enabled = false;
            cmbImpacto.Enabled = false;
            txtProblema.Enabled = false;
            btnNovo.Enabled = true;
            dgvServico.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtDtAbertura.Enabled = true;
            txtHorario.Enabled = true;
            txtDtVencimento.Enabled = true;
            cmbFinalidade.Enabled = true;
            cmbCategoria.Enabled = true;
            txtElemento.Enabled = true;
            cmbUrgencia.Enabled = true;
            cmbImpacto.Enabled = true;
            txtProblema.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void limparCampos()
        {
            txtIDServico.Text = ("0"); txtDtAbertura.Text = (""); txtHorario.Text = (""); txtDtVencimento.Text = ("");
            cmbFinalidade.Text = (""); cmbCategoria.Text = (""); txtElemento.Text = ("");
            cmbUrgencia.Text = (""); cmbImpacto.Text = (""); txtProblema.Text = ("");
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Tornar os Campos Enabled
            habilitarCampos();
            btnNovo.Enabled = false;
            dgvServico.Enabled = false;
            limparCampos();
            txtDtVencimento.Text = DateTime.Today.AddDays(30).ToString("dd-MM-yyyy");
            txtDtAbertura.Text = DateTime.Today.ToString("dd-MM-yyyy");
            txtHorario.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDServico.Text == "0")
            {
                if (txtDtAbertura.Text == "" || txtHorario.Text == "" || txtDtVencimento.Text == "" || cmbFinalidade.Text == "" || cmbCategoria.Text == "" || txtElemento.Text == "" || cmbUrgencia.Text == "" || cmbImpacto.Text == "" || txtProblema.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    servicobo.cadastrar(servico);
                    
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtDtAbertura.Text == "" || txtHorario.Text == "" || txtDtVencimento.Text == "" || cmbFinalidade.Text == "" || cmbCategoria.Text == "" || txtElemento.Text == "" || cmbUrgencia.Text == "" || cmbImpacto.Text == "" || txtProblema.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    servicobo.atualizar(servico);

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

        private void frmServico_Load(object sender, EventArgs e)
        {
            
            dgvServico.DataSource = servicobo.buscarServico();
            dgvServico.RowHeadersVisible = false;

            System.Globalization.CultureInfo ptBRCulture = new
            System.Globalization.CultureInfo("pt-BR");
            Convert.ToString(txtDtAbertura, ptBRCulture);

            //dgvServico.Columns["DtVencimento"].Visible = false;
            //dgvServico.Columns["Elemento"].Visible = false;
            //dgvServico.Columns["Urgencia"].Visible = false;
            //dgvServico.Columns["Impacto"].Visible = false;
            //dgvServico.Columns["Problema"].Width = 200;


        }

        private void dgvServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDServico.Text = dgvServico.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDtAbertura.Text = dgvServico.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHorario.Text = dgvServico.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDtVencimento.Text = dgvServico.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbFinalidade.Text = dgvServico.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbCategoria.Text = dgvServico.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtElemento.Text = dgvServico.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbUrgencia.Text = dgvServico.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbImpacto.Text = dgvServico.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtProblema.Text = dgvServico.Rows[e.RowIndex].Cells[9].Value.ToString();
            habilitarCampos();
            atribuirCampos();
            btnExcluir.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons yesno = MessageBoxButtons.YesNo;
            DialogResult apagar = MessageBox.Show("Deseja Apagar o Registro?", "Apagar Registro?", yesno);
            if(apagar.ToString().ToUpper() == "YES")
            {
                atribuirCampos();
                servicobo.excluir(servico);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvServico.DataSource = servicobo.buscarServico();
                aposCadastro();
                limparCampos();
            }
            else
            {
            }
            
        }
    }
}

