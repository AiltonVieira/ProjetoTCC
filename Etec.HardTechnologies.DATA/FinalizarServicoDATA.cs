using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using System.Data.SqlClient;

namespace Etec.HardTechnologies.DATA
{
    public class FinalizarServicoDATA
    {
        public List<Servico> buscarServico()
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("select * from SERVICO", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<Servico> listaServico = new List<Servico>();

            while (executar.Read())
            {
                Servico itemServico = new Servico();

                itemServico.IDServico = int.Parse(executar["IDSERVICO"].ToString());
                itemServico.DtAbertura = (executar["DTABERTURA"].ToString());
                itemServico.Horario = (executar["HORARIO"].ToString());
                itemServico.DtVencimento = (executar["DTVENCIMENTO"].ToString());
                itemServico.Finalidade = (executar["FINALIDADE"].ToString());
                itemServico.Categoria = (executar["CATEGORIA"].ToString());
                itemServico.Elemento = (executar["ELEMENTO"].ToString());
                itemServico.Urgencia = (executar["URGENCIA"].ToString());
                itemServico.Impacto = (executar["IMPACTO"].ToString());
                itemServico.Problema = (executar["PROBLEMA"].ToString());

                listaServico.Add(itemServico);
            }

            conexao.Close();

            return listaServico;
        }
             public List<FinalizarServico> buscarFServico()
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("select * from FINALIZAR_SERVICO", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<FinalizarServico> listaFServico = new List<FinalizarServico>();

            while (executar.Read())
            {
                FinalizarServico itemFServico = new FinalizarServico();

                itemFServico.IDFinalizacao = int.Parse(executar["IDFINALIZACAO"].ToString());
                itemFServico.IDServico = int.Parse(executar["IDSERVICO"].ToString());
                itemFServico.Relatorio = (executar["RELATORIO"].ToString());
                itemFServico.DtEncerramento = (executar["DTENCERRAMENTO"].ToString());
                itemFServico.FormaPagamento = (executar["FORMAPAGAMENTO"].ToString());
                itemFServico.Valor = (executar["VALOR"].ToString());
                itemFServico.Pago = bool.Parse(executar["PAGO"].ToString());

                listaFServico.Add(itemFServico);
            }

            conexao.Close();

            return listaFServico;
        }

        public void cadastrar(FinalizarServico fservico)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            SqlCommand comando = new SqlCommand("INSERT INTO FINALIZAR_SERVICO VALUES('" + fservico.IDServico + "' , '" + fservico.Relatorio + "', '" + fservico.DtEncerramento + "',  '" + fservico.FormaPagamento + "' , '" + fservico.Valor + "' , '" + fservico.Pago + "');", conexao);

            conexao.Open();

            SqlDataReader executar = comando.ExecuteReader();



        }

        public void atualizar(FinalizarServico fservico)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE FINALIZAR_SERVICO SET IDSERVICO='" + fservico.IDServico + "', RELATORIO='" + fservico.Relatorio + "', DTENCERRAMENTO='" + fservico.DtEncerramento + "', FORMAPAGAMENTO='" + fservico.FormaPagamento + "', VALOR='" + fservico.Valor + "', PAGO='" + fservico.Pago + "' WHERE IDFINALIZACAO = " + fservico.IDFinalizacao, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(FinalizarServico fservico)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM FINALIZAR_SERVICO WHERE IDFINALIZACAO = " + fservico.IDFinalizacao, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }
    }
}
