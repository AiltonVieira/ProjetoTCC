using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Etec.HardTechnologies.UI

{
    public partial class frmRecibo : Form
    {
        public frmRecibo(string nome, string CNPJ, string endereco, string cidade, string estado, string pais, string DtInicio, string DtEncerramento, string IDFinalizacao, string valor, string finalidade, string relatorio)
        {
            InitializeComponent();

            //setar o arquivo rtlc

            rpvRecibo.LocalReport.ReportEmbeddedResource = "Recibo.Recibo.rdlc";

            // setar os parametros

            Microsoft.Reporting.WinForms.ReportParameter[] p =
            new Microsoft.Reporting.WinForms.ReportParameter[12];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("nome", nome);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("CNPJ", CNPJ);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("endereco", endereco);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("cidade", cidade);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("estado", estado);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("pais", pais);
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("DtInicio", DtInicio);
            p[7] = new Microsoft.Reporting.WinForms.ReportParameter("DtEncerramento", DtEncerramento);
            p[8] = new Microsoft.Reporting.WinForms.ReportParameter("IDFinalizacao", IDFinalizacao);
            p[9] = new Microsoft.Reporting.WinForms.ReportParameter("valor", valor);
            p[10] = new Microsoft.Reporting.WinForms.ReportParameter("finalidade", finalidade);
            p[11] = new Microsoft.Reporting.WinForms.ReportParameter("relatorio", relatorio);
            rpvRecibo.LocalReport.SetParameters(p);
        }





        private void frmRecibo_Load(object sender, EventArgs e)
        {

            this.rpvRecibo.RefreshReport();
        }

        private void frmRecibo_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvRecibo.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
