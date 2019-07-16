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
    public partial class frmAgenda : Form
    {

        public frmAgenda()
        {
            InitializeComponent();

        }

        AgendaBO agendaBO = new AgendaBO();
        Agenda agenda = new Agenda();

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genesysDBFuncionario.FUNCIONARIO' table. You can move, or remove it, as needed.
            this.fUNCIONARIOTableAdapter.Fill(this.genesysDBFuncionario.FUNCIONARIO);

            // Propriedades do DataGrid
            dgvAgenda.DataSource = agendaBO.buscarAgenda(agenda);
            dgvAgenda.RowHeadersVisible = false;
            //dgvAgenda.Columns["IDAgenda"].Visible = false;
            dgvAgenda.Columns["Mes"].Visible = false;

            //CMB Mes

        }
        
        
        private void dgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDAgenda.Text = dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLocal.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtData.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHorario.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbFuncionario.Text = dgvAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();

            habilitarCampos();
            atribuirCampos();
            btnExcluir.Enabled = true;
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.Text == "Janeiro")
            {
                agenda.Mes = 01;

            }

            if (cmbMes.Text == "Fevereiro")
            {
                agenda.Mes = 02;

            }

            if (cmbMes.Text == "Março")
            {
                agenda.Mes = 03;

            }

            if (cmbMes.Text == "Abril")
            {
                agenda.Mes = 04;

            }

            if (cmbMes.Text == "Maio")
            {
                agenda.Mes = 05;

            }

            if (cmbMes.Text == "Junho")
            {
                agenda.Mes = 06;

            }

            if (cmbMes.Text == "Julho")
            {
                agenda.Mes = 07;

            }

            if (cmbMes.Text == "Agosto")
            {
                agenda.Mes = 08;

            }

            if (cmbMes.Text == "Setembro")
            {
                agenda.Mes = 09;

            }

            if (cmbMes.Text == "Outubro")
            {
                agenda.Mes = 10;

            }

            if (cmbMes.Text == "Novembro")
            {
                agenda.Mes = 11;
                
            }

            if (cmbMes.Text == "Dezembro")
            {
                agenda.Mes = 12;
            }
            dgvAgenda.DataSource = agendaBO.buscarAgenda(agenda);

        }

        public void atribuirCampos()
        {
            agenda.IDAgenda = int.Parse(txtIDAgenda.Text);
            agenda.Local = txtLocal.Text;
            agenda.Data = txtData.Text;
            agenda.Horario = txtHorario.Text;
            agenda.Funcionario = cmbFuncionario.Text;
        }

        private void aposCadastro()
        {
            dgvAgenda.DataSource = agendaBO.buscarAgenda(agenda);
            txtLocal.Enabled = false;
            txtData.Enabled = false;
            txtHorario.Enabled = false;
            cmbFuncionario.Enabled = false;
            btnNovo.Enabled = true;

            dgvAgenda.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtLocal.Enabled = true;
            txtData.Enabled = true;
            txtHorario.Enabled = true;
            cmbFuncionario.Enabled = true;
            btnNovo.Enabled = true;
            dgvAgenda.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void limparCampos()
        {
            txtIDAgenda.Text = ("0"); txtLocal.Text = (""); txtData.Text = (""); txtHorario.Text = (""); cmbFuncionario.Text = ("");
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Tornar os Campos Enabled
            habilitarCampos();
            btnNovo.Enabled = false;
            dgvAgenda.Enabled = false;
            limparCampos();
            txtData.Text = DateTime.Today.ToString("dd-MM-yyyy");
            txtHorario.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDAgenda.Text == "0")
            {
                if (txtLocal.Text == "" || txtData.Text == "" || txtHorario.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    agendaBO.cadastrar(agenda);

                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Novo Cadastro", ok);
                    aposCadastro();
                    limparCampos();
                }
            }
            else
            {
                if (txtLocal.Text == "" || txtData.Text == "" || txtHorario.Text == "")
                {
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show("Preencha todos os campos obrigatórios (*)", "Existem campos Vazios", ok);
                }
                else
                {
                    atribuirCampos();
                    agendaBO.atualizar(agenda);

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
                agendaBO.excluir(agenda);
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show("Registro apagado com sucesso!", "Registro excluído", ok);
                dgvAgenda.DataSource = agendaBO.buscarAgenda(agenda);
                aposCadastro();
                limparCampos();
            }
            else
            {
            }

        }
    }
}