using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.HardTechnologies.CLASS;

namespace Etec.HardTechnologies.DATA
{
    public class AgendaDATA
    {
        Agenda agenda = new Agenda();

        public List<Agenda> buscarAgenda(Agenda agenda)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("SELECT * FROM AGENDA WHERE DATA LIKE '%" + agenda.Mes + "'", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            List<Agenda> listaAgenda = new List<Agenda>();

            while (executar.Read())
            {
                Agenda itemagenda = new Agenda();
                itemagenda.IDAgenda = int.Parse(executar["IDAGENDA"].ToString());
                itemagenda.Local = (executar["LOCAL"].ToString());
                itemagenda.Data = (executar["DATA"].ToString());
                itemagenda.Horario = (executar["HORARIO"].ToString());
                itemagenda.Funcionario = (executar["FUNCIONARIO"].ToString());

                listaAgenda.Add(itemagenda);
            }

            conexao.Close();

            return listaAgenda;
        }

        public void cadastrar(Agenda agenda)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO AGENDA VALUES('" + agenda.Local + "' , '" + agenda.Data + "', '" + agenda.Horario + "', '" + agenda.Funcionario + "');", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void atualizar(Agenda agenda)
        {
            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("UPDATE AGENDA SET LOCAL='" + agenda.Local + "' , DATA='" + agenda.Data + "', HORARIO='" + agenda.Horario+ "', FUNCIONARIO='" + agenda.Funcionario + "' WHERE IDAGENDA = '" + agenda.IDAgenda + "'", conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }

        public void excluir(Agenda agenda)
        {

            string con = "User ID=sa;Password=1234567;Data Source=LAPTOP-9O51ARGN;Database=GenesysDB";

            SqlConnection conexao = new SqlConnection(con);

            conexao.Open();

            SqlCommand comando = new SqlCommand("DELETE FROM AGENDA WHERE IDAGENDA = " + agenda.IDAgenda, conexao);

            SqlDataReader executar = comando.ExecuteReader();

            conexao.Close();
        }
    }
}
