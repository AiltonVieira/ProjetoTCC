using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.HardTechnologies.CLASS
{
    public class FinalizarServico
    {
        public int IDFinalizacao { get; set; }
        public int IDServico { get; set; }
        public string Relatorio { get; set; }
        public string DtEncerramento { get; set; }
        public string FormaPagamento { get; set; }
        public string Valor { get; set; }
        public bool Pago { get; set; }

        


    }
}
