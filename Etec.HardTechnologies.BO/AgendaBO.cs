using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.DATA;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.BO
{
    public class AgendaBO
    {
        AgendaDATA data = new AgendaDATA();
        public List<Agenda> buscarAgenda(Agenda agenda)
        {
            return data.buscarAgenda(agenda);
        }

        public void cadastrar(Agenda agenda)
        {
            data.cadastrar(agenda);
        }

        public void atualizar(Agenda agenda)
        {
            data.atualizar(agenda);
        }

        public void excluir(Agenda agenda)
        {
            data.excluir(agenda);
        }
    }
}
