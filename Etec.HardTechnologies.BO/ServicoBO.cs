using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;

namespace Etec.HardTechnologies.BO
{
    public class ServicoBO
    {

        ServicoDATA Data = new ServicoDATA();

        public List<Servico> buscarServico()
        {
            return Data.buscarServico();
        }

        public void cadastrar(Servico servico)
        {
            Data.cadastrar(servico);

        }

        public void atualizar(Servico servico)
        {
            Data.atualizar(servico);

        }

        public void excluir(Servico servico)
        {
            Data.excluir(servico);
        }
    }
}
