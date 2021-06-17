using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cobra_Kai
{
    class secretaria : Pessoa
    {
        public secretaria(string senha, int cod, string nome, string email) : base(senha, cod, nome, email)
        {

        }

        public secretaria(int cod) : base(cod)
        {

        }

        public secretaria(string senha, string nome, string email) : base(senha, nome, email)
        {

        }

        public void criaSecretaria()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO secretaria (nome, senha, email) VALUES(@nome, @senha, @email)";
            comm.Parameters.AddWithValue("@nome", this.nome);
            comm.Parameters.AddWithValue("@senha", this.Senha1);
            comm.Parameters.AddWithValue("@email", this.email);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void atualizaSecretaria()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE secretaria SET nome = @nome, senha = @senha, email = @email WHERE(cod_sec = @cod);";
            comm.Parameters.AddWithValue("@nome", this.nome);
            comm.Parameters.AddWithValue("@senha", this.Senha1);
            comm.Parameters.AddWithValue("@email", this.email);
            comm.Parameters.AddWithValue("@cod", this.cod);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void apagaSecretaria()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM secretaria where (cod_sec=@cod);";
            comm.Parameters.AddWithValue("@cod", this.cod);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public secretaria buscaSecretaria()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT senha, nome, email FROM secretaria WHERE cod_sec = @cod;";
            comm.Parameters.AddWithValue("@cod", this.cod);
            comm.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comm.ExecuteReader();
            dr.Read();
            secretaria novo = new secretaria(dr.GetString(0), dr.GetString(1), dr.GetString(2));
            conn.Close();
            return novo;
        }
    }
}
