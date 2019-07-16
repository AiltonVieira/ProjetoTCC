using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.DATA;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.BO
{
    public class LoginBO
    {
        LoginDATA data = new LoginDATA();
        public bool logado = false;

        public bool logar(Login login)
        {
            if(data.conectar(login) == true)
            {
                return logado = true;
            }
            else
            {
                return logado = false;
            }
            
        }

    }
}
