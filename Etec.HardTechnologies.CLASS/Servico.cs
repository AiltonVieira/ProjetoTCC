using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.HardTechnologies.CLASS
{
    public class Servico
    {
        public int IDServico { get; set; }
        public string DtAbertura { get; set; }
        public string Horario { get; set; }
        public string DtVencimento { get; set; }
        public string Finalidade { get; set; }
        public string Categoria { get; set; }
        public string Elemento { get; set; }
        public string Urgencia { get; set; }
        public string Impacto { get; set; }
        public string Problema { get; set; }
    }
}
