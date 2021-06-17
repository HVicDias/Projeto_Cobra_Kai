using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projeto_Cobra_Kai
{
    class Pagamento
    {
        public String data, cod_pag, cod_resp, cod_al;

        public Pagamento(string data, string cod_pag, string cod_resp, string cod_al)
        {
            this.data = data;
            this.cod_pag = cod_pag;
            this.cod_resp = cod_resp;
            this.cod_al = cod_al;
        }

        public void criaPagamento()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT cod_aluno FROM aluno where cpf = @cpf;";
            comm.Parameters.AddWithValue("@cpf", cod_al);
            this.cod_al = Convert.ToInt32(comm.ExecuteScalar())+"";
            comm.CommandText = "SELECT cod_responsavel FROM responsavel where cpf = @cpf2;";
            comm.Parameters.AddWithValue("@cpf2", cod_resp);
            this.cod_resp = Convert.ToInt32(comm.ExecuteScalar())+"";
            comm.CommandText = "INSERT INTO pagamento (cod_pag, data_pag, fk_Responsavel_cod_responsavel, fk_Responsavel_cod_aluno) VALUES(@cod, @data, @cod_resp, @cod_al)";
            comm.Parameters.AddWithValue("@cod", this.cod_pag);
            comm.Parameters.AddWithValue("@data", this.data);
            comm.Parameters.AddWithValue("@cod_resp", this.cod_resp);
            comm.Parameters.AddWithValue("@cod_al", this.cod_al);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
