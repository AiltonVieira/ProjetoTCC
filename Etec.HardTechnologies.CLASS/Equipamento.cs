using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.HardTechnologies.CLASS
{
    public class Equipamento
    {
        public int IDEquipamento { get; set; }
        public string Nome { get; set; }
        public string DtFabricacao { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public decimal VlCompra { get; set; }
        public string Marca { get; set; }
        public int Estoque { get; set; }
    }
}
