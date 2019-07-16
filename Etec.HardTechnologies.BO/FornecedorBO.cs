using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;

namespace Etec.HardTechnologies.BO
{
    public class FornecedorBO
    {
        FornecedorDATA Data = new FornecedorDATA();

        public List<Fornecedor> buscarFornecedor()
        {
            return Data.buscarFornecedor();
        }
    
        public void cadastrar(Fornecedor fornecedor)
        {
            Data.cadastrar(fornecedor);
        }

        public void atualizar(Fornecedor fornecedor)
        {
            Data.atualizar(fornecedor);
        }

        public void excluir(Fornecedor fornecedor)
        {
            Data.excluir(fornecedor);
        }
    }
}
