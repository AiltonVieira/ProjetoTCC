using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;
using Etec.HardTechnologies.DATA;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Etec.HardTechnologies.DATA
{
    public class ServicoDATA
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

            return listaServico ;
        }

        public void cadastrar(Servico servico)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

                SqlCommand comando = new SqlCommand("INSERT INTO SERVICO VALUES('" + servico.DtAbertura + "' , '" + servico.Horario + "', '" + servico.DtVencimento + "',  '" + servico.Finalidade + "',  '" + servico.Categoria + "' , '" + servico.Elemento + "' , '" + servico.Urgencia + "' , '" + servico.Impacto + "' , '" + servico.Problema + "');", conexao);


                conexao.Open();

                SqlDataReader executar = comando.ExecuteReader();
                
        
            
        }

        public void atualizar(Servico servico)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE SERVICO SET DTABERTURA='" + servico.DtAbertura + "' , HORARIO='" + servico.Horario + "', DTVENCIMENTO='" + servico.DtVencimento + "', FINALIDADE='" + servico.Finalidade + "', CATEGORIA='" + servico.Categoria + "', ELEMENTO='" + servico.Elemento + "', URGENCIA='" + servico.Urgencia + "', IMPACTO='" + servico.Impacto + "', PROBLEMA='" + servico.Problema + "' WHERE IDSERVICO=" + servico.IDServico , conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(Servico servico)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM FINALIZAR_SERVICO WHERE IDSERVICO = " + servico.IDServico + "DELETE FROM SERVICO_CLIENTE WHERE IDSERVICO = " + servico.IDServico + " DELETE FROM SERVICO WHERE IDSERVICO = " + servico.IDServico, conexao);
            //  "DELETE FROM FORNECEDOR_EQUIPAMENTO WHERE IDEQUIPAMENTO = " + equipamento.IDEquipamento + "DELETE FROM EQUIPAMENTO_CLIENTE WHERE IDEQUIPAMENTO = " + equipamento.IDEquipamento + "DELETE FROM EQUIPAMENTO WHERE IDEQUIPAMENTO = " + equipamento.IDEquipamento, conexao);
            //System.Data.SqlClient.SqlException: 'Sintaxe incorreta próxima a '_SERVICO'.'
            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }
    }
}
