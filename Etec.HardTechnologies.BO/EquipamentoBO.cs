using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;

namespace Etec.HardTechnologies.BO
{
    public class EquipamentoBO
    {
        EquipamentoDATA data = new EquipamentoDATA();

        public List<Equipamento> buscarEquipamento()
        {
            return data.buscarEquipamento();
        }

        public void cadastrar(Equipamento equipamento)
        {
            data.cadastrar(equipamento);
        }

        public void atualizar(Equipamento equipamento)
        {
            data.atualizar(equipamento);
        }

        public void excluir(Equipamento equipamento)
        {
            data.excluir(equipamento);
        }
    }
}

