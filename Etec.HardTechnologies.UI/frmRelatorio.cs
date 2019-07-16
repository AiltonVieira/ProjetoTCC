using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.HardTechnologies.UI
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        frmFinalizarServico fservico = new frmFinalizarServico();
        
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genesysDBUsuarios.LOGIN_USUARIO' table. You can move, or remove it, as needed.
            this.lOGIN_USUARIOTableAdapter.Fill(this.genesysDBUsuarios.LOGIN_USUARIO);
            // TODO: This line of code loads data into the 'GenesysDBFinalizacaoServico.FINALIZACAO_DE_SERVICO' table. You can move, or remove it, as needed.
            this.FINALIZACAO_DE_SERVICOTableAdapter.Fill(this.GenesysDBFinalizacaoServico.FINALIZACAO_DE_SERVICO);
            // TODO: This line of code loads data into the 'genesysDBGanhosDebitos.EXTRATO' table. You can move, or remove it, as needed.
            this.eXTRATOTableAdapter.Fill(this.genesysDBGanhosDebitos.EXTRATO);
            // TODO: This line of code loads data into the 'genesysDBAbertosEncerrados.SERVICOS_ABERTOS_E_ENCERRADOS' table. You can move, or remove it, as needed.
            this.sERVICOS_ABERTOS_E_ENCERRADOSTableAdapter.Fill(this.genesysDBAbertosEncerrados.SERVICOS_ABERTOS_E_ENCERRADOS);
            // TODO: This line of code loads data into the 'genesysDBServicoFinalidade.SERVICO_POR_FINALIDADE' table. You can move, or remove it, as needed.
            this.sERVICO_POR_FINALIDADETableAdapter.Fill(this.genesysDBServicoFinalidade.SERVICO_POR_FINALIDADE);
            // TODO: This line of code loads data into the 'GenesysDBGanhosServico.GANHOS_POR_SERVIÇO' table. You can move, or remove it, as needed.

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GenesysDBReciboTableAdapters.FINALIZACAO_DE_SERVICOTableAdapter adapter = new GenesysDBReciboTableAdapters.FINALIZACAO_DE_SERVICOTableAdapter();
            GenesysDBRecibo.FINALIZACAO_DE_SERVICODataTable table = new GenesysDBRecibo.FINALIZACAO_DE_SERVICODataTable();

            adapter.FillByID(table, int.Parse(txtIDFinalizacao.Text));

            ReportDataSource relatorioRecibo = new ReportDataSource("ImpressaoRecibo", (DataTable)table);
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(relatorioRecibo);
            this.reportViewer2.LocalReport.Refresh();


            this.reportViewer2.RefreshReport();
        }
    }
}
