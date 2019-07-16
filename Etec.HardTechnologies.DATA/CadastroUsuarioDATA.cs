using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.DATA
{
    public class CadastroUsuarioDATA
    {
        CadastroUsuario usuario = new CadastroUsuario();

        public List<CadastroUsuario> buscarUsuario()
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("SELECT * FROM LOGIN_USUARIO", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<CadastroUsuario> listaUsuario = new List<CadastroUsuario>();

            while (executar.Read())
            {
                CadastroUsuario usuario = new CadastroUsuario();

                usuario.IDLogin = int.Parse(executar["IDLOGIN"].ToString());
                usuario.Usuario = (executar["USUARIO"].ToString());
                usuario.Senha = (executar["SENHA"].ToString());
                usuario.Nivel = (executar["NIVEL"].ToString());
                usuario.Cliente = (executar["CLIENTE"].ToString());
                usuario.Fornecedor = (executar["FORNECEDOR"].ToString());

                listaUsuario.Add(usuario);
            }

            conexao.Close();

            return listaUsuario;
        }

        public void cadastrar(CadastroUsuario usuario)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO LOGIN_USUARIO VALUES('" + usuario.Usuario + "' , '" + usuario.Senha + "', '" + usuario.Nivel + "', '" + usuario.Cliente + "', '" + usuario.Fornecedor + "');", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void atualizar(CadastroUsuario usuario)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE AGENDA SET USUARIO='" + usuario.Usuario + "' , SENHA='" + usuario.Senha + "', NIVEL='" + usuario.Nivel + "', CLIENTE='" + usuario.Cliente + "', FORNECEDOR='" + usuario.Fornecedor + "' WHERE IDLOGIN = '" + usuario.IDLogin + "'", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(CadastroUsuario usuario)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM LOGIN_USUARIO WHERE IDLOGIN = " + usuario.IDLogin, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }
    }
}
