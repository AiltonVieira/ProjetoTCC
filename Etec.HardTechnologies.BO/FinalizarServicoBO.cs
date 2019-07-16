using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;

namespace Etec.HardTechnologies.BO

{
    public class FinalizarServicoBO
    {
        
        FinalizarServicoDATA data = new FinalizarServicoDATA();

        public List<Servico> buscarServico()
        {
            return data.buscarServico();
        }

        public List<FinalizarServico> buscarFServico()
        {
            return data.buscarFServico();
        }

        public void cadastrar(FinalizarServico fservico)
        {
            data.cadastrar(fservico);

        }

        public void atualizar(FinalizarServico fservico)
        {
            data.atualizar(fservico);

        }

        public void excluir(FinalizarServico fservico)
        {
            data.excluir(fservico);
        }
    }
}
