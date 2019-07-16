using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;

namespace Etec.HardTechnologies.BO
{
    public class ClienteBO
    {
        ClienteDATA Data = new ClienteDATA();
        public List<Cliente> buscarCliente()
        {
            return Data.buscarCliente();
        }

        public void cadastrar(Cliente cliente)
        {
            Data.cadastrar(cliente);
        }

        public void atualizar(Cliente cliente)
        {
            Data.atualizar(cliente);
        }

        public void excluir(Cliente cliente)
        {
            Data.excluir(cliente);
        }
    }
}
