using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using System.Windows.Forms;

namespace Etec.HardTechnologies.DATA
{
    public class LoginDATA
    {
        Login login = new Login();

        public bool logado = false;

        public bool conectar(Login login)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";


            SqlConnection conexao = new SqlConnection(con);



            try
            {
                
                SqlCommand comando = new SqlCommand("SELECT COUNT(IDLOGIN) FROM LOGIN_USUARIO WHERE USUARIO = @usuario AND SENHA = @senha AND Nivel = @nivel", conexao);

                comando.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = login.Usuario;
                comando.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = login.Senha;
                comando.Parameters.AddWithValue("@nivel", SqlDbType.VarChar).Value = login.Nivel;
                conexao.Open();

                int v = (int)comando.ExecuteScalar();

                if (v > 0)
                {
                    return logado = true;
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha e/ou nível de acesso estão incorretos!");
                    return logado = false;
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e + "Falha de conexão com banco de dados, contate o suporte.");
                return logado = false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

