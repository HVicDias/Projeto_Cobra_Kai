using MaterialSkin;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Projeto_Cobra_Kai
{
    public partial class telaLogIn : Form
    {
        private PrivateFontCollection font_dead_stock;
        private PrivateFontCollection font_Lexend_Deca;

        public telaLogIn()
        {
            initFontes();
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            textSenha.UseSystemPasswordChar = false;
            labelValidaEmail.Visible = labelValidaSenha.Visible = false;
        }

        public void initFontes()
        {
            PrivateFontCollection dead_stock = new PrivateFontCollection();
            PrivateFontCollection lexend = new PrivateFontCollection();
            dead_stock.AddFontFile(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\font\Dead_Stock_-_Demo.ttf")));
            lexend.AddFontFile(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\font\LexendDeca-Regular.ttf")));
            font_Lexend_Deca = lexend;
            font_dead_stock = dead_stock;
        }




        private void telaLogIn_Load(object sender, EventArgs e)
        {
            labelLogIn.Font = new Font(font_dead_stock.Families[0], 42);
            labelCobraKai.Font = new Font(font_dead_stock.Families[0], 64);
            buttonEntrar.Font = textEmail.Font = textSenha.Font = labelSenha.Font = labelUsuario.Font = new Font(font_Lexend_Deca.Families[0], 12);
            labelSenha.ForeColor = labelUsuario.ForeColor = labelLogIn.ForeColor = labelCobraKai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            if (textEmail.Text.Equals("e-mail")) textEmail.Text = "";
        }

        private void textSenha_Click(object sender, EventArgs e)
        {
            if (textSenha.Text.Equals("Senha"))
            {
                textSenha.Text = "";
                textSenha.UseSystemPasswordChar = true;
            }
        }

        private bool ValidaAdm(string email, string senha)
        {
            try
            {
                int retorno = -1;
                MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
                string comando = "SELECT COUNT(*) FROM adm WHERE email=@Email AND Senha=@Senha";
                MySqlCommand cmd = new MySqlCommand(comando, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);
                conn.Open();
                retorno = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return retorno > 0;
            }catch(MySqlException e)
            {
                MessageBox.Show("Erro com conexão ao Banco de Dados\nCOD: " + e);
                return false;
                
            }
        }

        private bool ValidaSecretaria(string email, string senha)
        {
            try
            {
                int retorno = -1;
                MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
                string comando = "SELECT COUNT(*) FROM secretaria WHERE email=@Email AND Senha=@Senha";
                MySqlCommand cmd = new MySqlCommand(comando, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);
                conn.Open();
                retorno = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return retorno > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro com conexão ao Banco de Dados\nCOD: " + e);
                return false;

            }
        }


        private void buttonEntrar_Click(object sender, EventArgs e) {
            
            if (textEmail.Text.Contains("@") ) 
            {
                string[] vetorEmail = textEmail.Text.Split('@');
                if (vetorEmail[1].Contains(".") & vetorEmail[0].Length>0 & vetorEmail[1].Length>2 )
                {
                    labelValidaEmail.Visible = false;
                    if (ValidaAdm(textEmail.Text, textSenha.Text) )
                    {
                        this.Hide();
                        Form2 form2 = new Form2(1);
                        form2.ShowDialog();
                        this.Close();
                    }else if (ValidaSecretaria(textEmail.Text, textSenha.Text))
                    {
                        this.Hide();
                        Form2 form2 = new Form2(0);
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        labelValidaSenha.Visible = true;
                        labelValidaSenha.Font = new Font(font_Lexend_Deca.Families[0], 7);
                        labelValidaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
                    }
                }
                else
                {
                    labelValidaSenha.Visible = false;
                    labelValidaEmail.Visible = true;
                    labelValidaEmail.Font = new Font(font_Lexend_Deca.Families[0], 7);
                    labelValidaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
                }
            }
            else
            {
                labelValidaSenha.Visible = false;
                labelValidaEmail.Visible = true;
                labelValidaEmail.Font = new Font(font_Lexend_Deca.Families[0], 7);
                labelValidaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            }
        }

        private void mostraSenha(object sender, MouseEventArgs e)
        {
            
            showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            textSenha.UseSystemPasswordChar = false;
        }

        private void escondeSenha(object sender, MouseEventArgs e)
        {
            showPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            textSenha.UseSystemPasswordChar = true;
        }


        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                buttonEntrar_Click(sender, e);
        }

        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textSenha.Focus();
                textSenha_Click(sender, e);
            }
                
        }
    }
}
