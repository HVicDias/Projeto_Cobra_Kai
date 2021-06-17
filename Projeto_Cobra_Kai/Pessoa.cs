using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cobra_Kai
{
    class Pessoa
    {
        private string senha;
        public int cod;
        public string nome;
        public string email;

        public Pessoa(string senha, int cod, string nome, string email)
        {
            this.Senha1 = senha;
            this.cod = cod;
            this.nome = nome;
            this.email = email;
        }

        public Pessoa(string senha, string nome, string email)
        {
            this.Senha1 = senha;
            this.nome = nome;
            this.email = email;
        }

        public Pessoa(int cod)
        {
            this.cod = cod;
        }

        public string Senha { get => Senha1; set => Senha1 = value; }
        public string Senha1 { get => senha; set => senha = value; }
    }
}

