using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin;


namespace Projeto_Cobra_Kai
{
    public partial class Form2 : Form
    {

        private IconButton botaoAtual;
        private Panel painelEsquerdo;

        private int prioridade;
        public Form2(int cod_prioridade)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            prioridade = cod_prioridade;
            if (cod_prioridade == 0)
            {
                buttonSecretaria.Hide();
                buttonPagamentos.Hide();
            }
            painelEsquerdo = new Panel();
            painelEsquerdo.Size = new Size(7, 60);
            menuControles.Controls.Add(painelEsquerdo);
            menuIndicador.ForeColor = Color.FromArgb(230, 57, 70);
            menuIndicador.IconColor = Color.FromArgb(230, 57, 70);
        }

        private void BotaoAtivo(object BotaoEnviado)
        {
            if (!BotaoEnviado.Equals(null))
            {
                botaoInativo();
                botaoAtual = (IconButton)BotaoEnviado;
                botaoAtual.BackColor = Color.FromArgb(230, 230, 230);
                botaoAtual.ForeColor = Color.FromArgb(230, 57, 70);
                botaoAtual.TextAlign = ContentAlignment.MiddleCenter;
                botaoAtual.IconColor = Color.FromArgb(230, 57, 70);
                botaoAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botaoAtual.ImageAlign = ContentAlignment.MiddleRight;

                painelEsquerdo.BackColor = Color.FromArgb(230, 57, 70);
                painelEsquerdo.Visible = true;
                painelEsquerdo.BringToFront();

                menuIndicador.Text = botaoAtual.Text;
                menuIndicador.IconChar = botaoAtual.IconChar;
                menuIndicador.ForeColor = Color.FromArgb(230, 57, 70);
                menuIndicador.IconColor = Color.FromArgb(230, 57, 70);
            }

        }

        private void botaoInativo()
        {
            if (botaoAtual != null)
            {
                botaoAtual.BackColor = Color.FromArgb(32, 32, 32);
                botaoAtual.ForeColor = Color.FromArgb(159, 159, 159);
                botaoAtual.TextAlign = ContentAlignment.MiddleLeft;
                botaoAtual.IconColor = Color.FromArgb(159, 159, 159);
                botaoAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botaoAtual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonSair);
            this.Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonVoltar);
            this.Hide();
            telaLogIn form1 = new telaLogIn();
            form1.ShowDialog();
            this.Close();
        }

        private void buttonCatraca_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonCatraca);
        }

        private void buttonAlunos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAlunos);
        }

        private void buttonResponsaveis_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonResponsaveis);
        }

        private void buttonProfessores_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonProfessores);
        }

        private void buttonAulas_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAulas);
        }

        private void buttonAvisos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAvisos);
        }

        private void buttonSecretaria_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonPagamentos);
        }

        private void buttonAdm_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonSecretaria);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            painelEsquerdo.Visible = false;
            menuIndicador.Text = "Home";
            menuIndicador.IconChar = FontAwesome.Sharp.IconChar.Home;
            menuIndicador.ForeColor = Color.FromArgb(230, 57, 70);
            menuIndicador.IconColor = Color.FromArgb(230, 57, 70);
            botaoInativo();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraDeEventos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuIndicador_Click(object sender, EventArgs e)
        {
            painelEsquerdo.Visible = false;
            menuIndicador.Text = "Home";
            menuIndicador.IconChar = FontAwesome.Sharp.IconChar.Home;
            menuIndicador.ForeColor = Color.FromArgb(230, 57, 70);
            menuIndicador.IconColor = Color.FromArgb(230, 57, 70);
            botaoInativo();
        }

      
    }
}
