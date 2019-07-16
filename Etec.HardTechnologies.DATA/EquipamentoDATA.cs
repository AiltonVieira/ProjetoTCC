    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.DATA
{
    public class EquipamentoDATA
    {
            public List<Equipamento> buscarEquipamento()
            {
                //string con = "User ID=sa; Password=Ailton010313; Data Source=(local); Database=GenesysDB;";
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

                conexao.Open();

                SqlCommand comando = new SqlCommand("select * from EQUIPAMENTO", conexao);

                SqlDataReader executar = comando.ExecuteReader();

                List<Equipamento> listaEquipamento = new List<Equipamento>();

                while (executar.Read())
                {
                    Equipamento equipamento = new Equipamento();

                    equipamento.IDEquipamento = int.Parse(executar["IDEQUIPAMENTO"].ToString());
                    equipamento.Nome = (executar["NOME"].ToString());
                    equipamento.DtFabricacao = (executar["FABRICACAO"].ToString());
                    equipamento.Modelo = (executar["MODELO"].ToString());
                    equipamento.NumeroSerie = (executar["NUMEROSERIE"].ToString());
                    equipamento.VlCompra = decimal.Parse(executar["VLCOMPRA"].ToString());
                    equipamento.Marca = (executar["MARCA"].ToString());
                    equipamento.Estoque = int.Parse(executar["ESTOQUE"].ToString());

                listaEquipamento.Add(equipamento);
                }

                conexao.Close();

                return listaEquipamento;
            }

        public void cadastrar(Equipamento equipamento)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO EQUIPAMENTO VALUES('" + equipamento.Nome + "' , '" + equipamento.DtFabricacao + "', '" + equipamento.Modelo + "', '" + equipamento.NumeroSerie + "',  '" + equipamento.VlCompra + "' , '" + equipamento.Marca + "' , '" + equipamento.Estoque + "');", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void atualizar(Equipamento equipamento)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE EQUIPAMENTO SET NOME='" + equipamento.Nome + "' , FABRICACAO='" + equipamento.DtFabricacao + "', MODELO='" + equipamento.Modelo + "', NUMEROSERIE='" + equipamento.NumeroSerie + "', VLCOMPRA='" + equipamento.VlCompra + "', MARCA='" + equipamento.Marca + "', ESTOQUE='" + equipamento.Estoque + "' WHERE IDEQUIPAMENTO=" + equipamento.IDEquipamento, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(Equipamento equipamento)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM FORNECEDOR_EQUIPAMENTO WHERE IDEQUIPAMENTO = "+ equipamento.IDEquipamento + "DELETE FROM EQUIPAMENTO_CLIENTE WHERE IDEQUIPAMENTO = " + equipamento.IDEquipamento + "DELETE FROM EQUIPAMENTO WHERE IDEQUIPAMENTO = " + equipamento.IDEquipamento, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }
    }
}
