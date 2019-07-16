using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.HardTechnologies.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmSplash());
            //Application.Run(new frmMenuPrincipal());
            //Application.Run(new frmServico());
            //Application.Run(new frmFinalizarServico());
            //Application.Run(new frmCliente());
            //Application.Run(new frmFuncionario());
            //Application.Run(new frmEquipamento());
            //Application.Run(new frmEstoque());
            //Application.Run(new frmFornecedor());
            //Application.Run(new frmSobre());
            //Application.Run(new frmContato());
            //Application.Run(new frmRecibo());
            //Application.Run(new frmPagamento());
            //Application.Run(new frmRelatorio());
            //Application.Run(new frmAgenda());
        }
    }
}
