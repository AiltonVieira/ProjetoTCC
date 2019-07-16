using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.DATA
{
    public class FornecedorDATA
    {
        public List<Fornecedor> buscarFornecedor()
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("select * from FORNECEDOR", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<Fornecedor> listaFornecedor = new List<Fornecedor>();

            while (executar.Read())
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.IDFornecedor = int.Parse(executar["IDFORNECEDOR"].ToString());
                fornecedor.Razao = (executar["RAZAO"].ToString());
                fornecedor.Nome = (executar["NOME"].ToString());
                fornecedor.CNPJ = (executar["CNPJ"].ToString());
                fornecedor.Endereco = (executar["ENDERECO"].ToString());
                fornecedor.Numero = (executar["NUMERO"].ToString());
                fornecedor.Complemento = (executar["COMPLEMENTO"].ToString());
                fornecedor.CEP = (executar["CEP"].ToString());
                fornecedor.Bairro = (executar["BAIRRO"].ToString());
                fornecedor.Cidade = (executar["CIDADE"].ToString());
                fornecedor.Estado = (executar["ESTADO"].ToString());
                fornecedor.Telefone = (executar["TELEFONE"].ToString());
                fornecedor.Celular = (executar["CELULAR"].ToString());
                fornecedor.Email = (executar["EMAIL"].ToString());
                fornecedor.WebSite = (executar["WEBSITE"].ToString());

                listaFornecedor.Add(fornecedor);
            }

            conexao.Close();

            return listaFornecedor;
        }

        public void cadastrar(Fornecedor fornecedor)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO FORNECEDOR VALUES('" + fornecedor.Razao + "', '" + fornecedor.Nome + "', '" + fornecedor.CNPJ + "', '" + fornecedor.Endereco + "', '" + fornecedor.Numero + "', '" + fornecedor.Complemento + "', '" + fornecedor.CEP + "', '" + fornecedor.Bairro + "', '" + fornecedor.Cidade + "', '" + fornecedor.Estado + "', '" + fornecedor.Telefone + "', '" + fornecedor.Celular + "', '" + fornecedor.Email + "', '" + fornecedor.WebSite + "')", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void atualizar(Fornecedor fornecedor)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE FORNECEDOR SET RAZAO='" + fornecedor.Razao + "', NOME='" + fornecedor.Nome + "', CNPJ='" + fornecedor.CNPJ + "', ENDERECO='" + fornecedor.Endereco + "', NUMERO='" + fornecedor.Numero + "', COMPLEMENTO='" + fornecedor.Complemento + "', CEP='" + fornecedor.CEP + "', BAIRRO='" + fornecedor.Bairro + "', CIDADE='" + fornecedor.Cidade + "', ESTADO='" + fornecedor.Estado + "', TELEFONE='" + fornecedor.Telefone + "', CELULAR='" + fornecedor.Celular + "', EMAIL='" + fornecedor.Email + "', WEBSITE='" + fornecedor.WebSite + "' WHERE IDFORNECEDOR =" + fornecedor.IDFornecedor, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(Fornecedor fornecedor)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM FORNECEDOR_EQUIPAMENTO WHERE IDFORNECEDOR = " + fornecedor.IDFornecedor + "DELETE FROM LOGIN_USUARIO WHERE FORNECEDOR=" + fornecedor.Nome + " DELETE FROM FORNECEDOR WHERE IDFORNECEDOR=" + fornecedor.IDFornecedor, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();

        }
    }
}
