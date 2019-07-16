using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.DATA
{
    public class ClienteDATA
    {
        Cliente cliente = new Cliente();

        public List<Cliente> buscarCliente()
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("select * from CLIENTE", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<Cliente> listaCliente = new List<Cliente>();

            while (executar.Read())
            {
                cliente.IDCliente = int.Parse(executar["IDCLIENTE"].ToString());
                cliente.Razao = (executar["RAZAO"].ToString());
                cliente.Nome = (executar["NOME"].ToString());
                cliente.CNPJ = (executar["CNPJ"].ToString());
                cliente.Endereco = (executar["ENDERECO"].ToString());
                cliente.Numero = (executar["NUMERO"].ToString());
                cliente.Complemento = (executar["COMPLEMENTO"].ToString());
                cliente.CEP = (executar["CEP"].ToString());
                cliente.Bairro = (executar["BAIRRO"].ToString());
                cliente.Cidade = (executar["CIDADE"].ToString());
                cliente.Estado = (executar["ESTADO"].ToString());
                cliente.Telefone = (executar["TELEFONE"].ToString());
                cliente.Celular = (executar["CELULAR"].ToString());
                cliente.Email = (executar["EMAIL"].ToString());
                cliente.WebSite = (executar["WEBSITE"].ToString());

                listaCliente.Add(cliente);
            }

            conexao.Close();

            return listaCliente;
        }

        public void cadastrar(Cliente cliente)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO CLIENTE VALUES('" + cliente.Razao + "', '" + cliente.Nome + "', '" + cliente.CNPJ + "', '" + cliente.Endereco + "', '" + cliente.Numero + "', '" + cliente.Complemento + "', '" + cliente.CEP + "', '" + cliente.Bairro + "', '" + cliente.Cidade + "', '" + cliente.Estado + "', '" + cliente.Telefone + "', '" + cliente.Celular + "', '" + cliente.Email + "', '" + cliente.WebSite + "')", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void atualizar(Cliente cliente)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE CLIENTE SET RAZAO='" + cliente.Razao + "', NOME='" + cliente.Nome + "', CNPJ='" + cliente.CNPJ + "', ENDERECO='" + cliente.Endereco + "', NUMERO='" + cliente.Numero + "', COMPLEMENTO='" + cliente.Complemento + "', CEP='" + cliente.CEP + "', BAIRRO='"+ cliente.Bairro + "', CIDADE='" + cliente.Cidade + "', ESTADO='" + cliente.Estado + "', TELEFONE='" +  cliente.Telefone + "', CELULAR='" + cliente.Celular + "', EMAIL='" + cliente.Email + "', WEBSITE='" + cliente.WebSite + "' WHERE IDCLIENTE =" + cliente.IDCliente, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir (Cliente cliente)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM SERVICO_CLIENTE WHERE IDCLIENTE=" + cliente.IDCliente + "DELETE FROM EQUIPAMENTO_CLIENTE WHERE IDCLIENTE = " + cliente.IDCliente + "DELETE FROM LOGIN_USUARIO WHERE CLIENTE= '" + cliente.Nome + "' DELETE FROM CLIENTE WHERE IDCLIENTE=" + cliente.IDCliente, conexao);
            SqlDataReader executar = comando.ExecuteReader();
            //System.Data.SqlClient.SqlException: 'Sintaxe incorreta próxima a 'Telefone'.'
            conexao.Close();

        }
    }
}
