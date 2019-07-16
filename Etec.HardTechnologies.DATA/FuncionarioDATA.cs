using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.DATA
{
    public class FuncionarioDATA
    {
        Funcionario funcionario = new Funcionario();

        public List<Funcionario> buscarFuncionario()
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";


            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("select * from FUNCIONARIO", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<Funcionario> listaFuncionario = new List<Funcionario>();

            while (executar.Read())
            {
                Funcionario funcionario = new Funcionario();

                funcionario.IDFuncionario = int.Parse(executar["IDFUNCIONARIO"].ToString());
                funcionario.Nome = (executar["NOME"].ToString());
                funcionario.CPF = (executar["CPF"].ToString());
                funcionario.Endereco = (executar["ENDERECO"].ToString());
                funcionario.Numero = (executar["NUMERO"].ToString());
                funcionario.Complemento = (executar["COMPLEMENTO"].ToString());
                funcionario.CEP = (executar["CEP"].ToString());
                funcionario.Bairro = (executar["BAIRRO"].ToString());
                funcionario.Cidade = (executar["CIDADE"].ToString());
                funcionario.Estado = (executar["ESTADO"].ToString());
                funcionario.Telefone = (executar["TELEFONE"].ToString());
                funcionario.Celular = (executar["CELULAR"].ToString());
                funcionario.Email = (executar["EMAIL"].ToString());
                funcionario.Cargo = (executar["CARGO"].ToString());

                listaFuncionario.Add(funcionario);
            }

            conexao.Close();

            return listaFuncionario;
        }


        public void cadastrar(Funcionario funcionario)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO FUNCIONARIO VALUES('" + funcionario.Nome + "', '" + funcionario.CPF + "', '" + funcionario.Endereco + "', '" + funcionario.Numero + "', '" + funcionario.Complemento + "', '" + funcionario.CEP + "', '" + funcionario.Bairro + "', '" + funcionario.Cidade + "', '" + funcionario.Estado + "', '" + funcionario.Telefone + "', '" + funcionario.Celular + "', '" + funcionario.Email + "', '" + funcionario.Cargo + "')", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void atualizar(Funcionario funcionario)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE FUNCIONARIO SET NOME='" + funcionario.Nome + "', CPF='" + funcionario.CPF + "', ENDERECO='" + funcionario.Endereco + "', NUMERO='" + funcionario.Numero + "', COMPLEMENTO='" + funcionario.Complemento + "', CEP='" + funcionario.CEP + "', BAIRRO='" + funcionario.Bairro + "', CIDADE='" + funcionario.Cidade + "', ESTADO='" + funcionario.Estado + "', TELEFONE='" + funcionario.Telefone + "', CELULAR='" + funcionario.Celular + "', EMAIL='" + funcionario.Email + "', CARGO='" + funcionario.Cargo + "' WHERE IDFUNCIONARIO =" + funcionario.IDFuncionario, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(Funcionario funcionario)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM FUNCIONARIO_TURNO WHERE IDFUNCIONARIO = " + funcionario.IDFuncionario + " DELETE FROM FUNCIONARIO WHERE IDFUNCIONARIO = " + funcionario.IDFuncionario , conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();

        }
    }
}
