using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.DATA;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.BO
{
    public class CadastroUsuarioBO
    {
        CadastroUsuarioDATA data = new CadastroUsuarioDATA();
        public List<CadastroUsuario> buscarUsuario()
        {
            return data.buscarUsuario();
        }

        public void cadastrar(CadastroUsuario usuario)
        {
            data.cadastrar(usuario);
        }

        public void atualizar(CadastroUsuario usuario)
        {
            data.atualizar(usuario);
        }

        public void excluir(CadastroUsuario usuario)
        {
            data.excluir(usuario);
        }
    }
}
