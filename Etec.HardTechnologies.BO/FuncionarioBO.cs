using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;

namespace Etec.HardTechnologies.BO
{
    public class FuncionarioBO
    {

        FuncionarioDATA Data = new FuncionarioDATA();

        public List<Funcionario> buscarFuncionario()
        {
            return Data.buscarFuncionario();
        }

        public void cadastrar(Funcionario funcionario)
        {
            Data.cadastrar(funcionario);
        }

        public void atualizar(Funcionario funcionario)
        {
            Data.atualizar(funcionario);
        }

        public void excluir(Funcionario funcionario)
        {
            Data.excluir(funcionario);
        }
    }
}
