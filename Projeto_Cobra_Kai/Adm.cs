using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cobra_Kai
{
    class Adm : Pessoa
    {
        public Adm(string senha, int cod, string nome, string email) : base(senha, cod, nome, email)
        {

        }

        public Adm(int cod) : base(cod)
        {

        }

        public Adm(string senha, string nome, string email) : base(senha, nome, email)
        {

        }

        public void criaAdm()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO adm (nome, senha, email) VALUES(@nome, @senha, @email)";
            comm.Parameters.AddWithValue("@nome", this.nome);
            comm.Parameters.AddWithValue("@senha", this.Senha1);
            comm.Parameters.AddWithValue("@email", this.email);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void atualizaAdm()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE adm SET nome = @nome, senha = @senha, email = @email WHERE(cod = @cod);";
            comm.Parameters.AddWithValue("@nome", this.nome);
            comm.Parameters.AddWithValue("@senha", this.Senha1);
            comm.Parameters.AddWithValue("@email", this.email);
            comm.Parameters.AddWithValue("@cod", this.cod);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void apagaAdm()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM adm where (cod=@cod);";
            comm.Parameters.AddWithValue("@cod", this.cod);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public Adm buscaAdm()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT senha, nome, email FROM adm WHERE cod = @cod;";
            comm.Parameters.AddWithValue("@cod", this.cod);
            comm.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comm.ExecuteReader();
            dr.Read();
            Adm novo = new Adm(dr.GetString(0), dr.GetString(1), dr.GetString(2));
            conn.Close();
            return novo;
        }
    }
}
