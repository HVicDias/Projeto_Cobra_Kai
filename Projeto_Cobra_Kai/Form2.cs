using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;

namespace Projeto_Cobra_Kai
{
    public partial class Form2 : Form
    {
        private IconButton botaoAtual;
        private Panel painelEsquerdo;
        private int selectedButton = 0;

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
                buttonAdm.Hide();
            }
            painelEsquerdo = new Panel();
            painelEsquerdo.Size = new Size(7, 60);
            menuControles.Controls.Add(painelEsquerdo);
            menuIndicador.ForeColor = Color.FromArgb(230, 57, 70);
            menuIndicador.IconColor = Color.FromArgb(230, 57, 70);
            materialTabControl1.SelectedIndex = 2;
            comboFaixa.Items.Add("Branca");
            comboFaixa.Items.Add("Amarela");
            comboFaixa.Items.Add("Laranja");
            comboFaixa.Items.Add("Verde");
            comboFaixa.Items.Add("Azul");
            comboFaixa.Items.Add("Roxa");
            comboFaixa.Items.Add("Vermelha");
            comboFaixa.Items.Add("Marrom");
            comboFaixa.Items.Add("Marrom PP");
            comboFaixa.Items.Add("Preta");
            comboFaixas.Items.Add("Branca e Amarela");
            comboFaixas.Items.Add("Laranja e Verde");
            comboFaixas.Items.Add("Azul e Roxa");
            comboFaixas.Items.Add("Vermelha e Marrom");
            comboFaixas.Items.Add("Marrom PP e Preta");
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
                painelEsquerdo.Location = new Point(0, botaoAtual.Location.Y);

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
            materialTabControl1.SelectedIndex = 3;
        }

        private void buttonAlunos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAlunos);
            labelCpf.Visible = true;
            textCpf.Visible = true;
            labelTelefone.Visible = true;
            textTelefone.Visible = true;
            labelEndereco.Visible = true;
            textEndereco.Visible = true;
            labelIdade.Visible = true;
            textIdade.Visible = true;
            labelDigital.Visible = true;
            textDigital.Visible = true;
            labelFaixa.Visible = true;
            comboFaixa.Visible = true;
            buttonDigital.Visible = true;
            panel6.Visible = true;
            labelCodResp.Visible = true;
            textCodResp.Visible = true;
            materialTabControl1.SelectedIndex = 1;
            selectedButton = 1;
        }

        private void buttonResponsaveis_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonResponsaveis);
            labelCpf.Visible = true;
            textCpf.Visible = true;
            labelTelefone.Visible = true;
            textTelefone.Visible = true;
            labelEndereco.Visible = true;
            textEndereco.Visible = true;
            labelIdade.Visible = false;
            textIdade.Visible = false;
            labelDigital.Visible = false;
            textDigital.Visible = false;
            labelFaixa.Visible = false;
            comboFaixa.Visible = false;
            buttonDigital.Visible = false;
            panel6.Visible = false;
            labelCodResp.Visible = false;
            textCodResp.Visible = false;
            materialTabControl1.SelectedIndex = 1;
            selectedButton = 2;
        }

        private void buttonProfessores_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonProfessores);
            materialTabControl1.SelectedIndex = 1;
            labelCpf.Visible = true;
            textCpf.Visible = true;
            labelTelefone.Visible = true;
            textTelefone.Visible = true;
            labelEndereco.Visible = true;
            textEndereco.Visible = true;
            labelIdade.Visible = false;
            textIdade.Visible = false;
            labelDigital.Visible = false;
            textDigital.Visible = false;
            labelFaixa.Visible = true;
            comboFaixa.Visible = true;
            buttonDigital.Visible = false;
            panel6.Visible = false;
            labelCodResp.Visible = false;
            textCodResp.Visible = false;
            selectedButton = 3;
        }

        private void buttonAulas_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAulas);
            materialTabControl1.SelectedIndex = 5;
        }

        private void buttonAvisos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAvisos);
            materialTabControl1.SelectedIndex = 4;

        }

        private void buttonPagamentos_Click(object sender, EventArgs e)
        {
            BotaoAtivo(buttonPagamentos);
            materialTabControl1.SelectedIndex = 0;
        }

        private void buttonSecretaria_Click_1(object sender, EventArgs e)
        {
            BotaoAtivo(buttonSecretaria);
            materialTabControl1.SelectedIndex = 1;
            labelCpf.Visible = false;
            textCpf.Visible = false;
            labelTelefone.Visible = false;
            textTelefone.Visible = false;
            labelEndereco.Visible = false;
            textEndereco.Visible = false;
            labelIdade.Visible = false;
            textIdade.Visible = false;
            labelDigital.Visible = false;
            textDigital.Visible = false;
            labelFaixa.Visible = false;
            comboFaixa.Visible = false;
            buttonDigital.Visible = false;
            panel6.Visible = false;
            labelCodResp.Visible = false;
            textCodResp.Visible = false;
            selectedButton = 4;
        }

        private void buttonAdm_Click_1(object sender, EventArgs e)
        {
            BotaoAtivo(buttonAdm);
            labelCpf.Visible = false;
            textCpf.Visible = false;
            labelTelefone.Visible = false;
            textTelefone.Visible = false;
            labelEndereco.Visible = false;
            textEndereco.Visible = false;
            labelIdade.Visible = false;
            textIdade.Visible = false;
            labelDigital.Visible = false;
            textDigital.Visible = false;
            labelFaixa.Visible = false;
            comboFaixa.Visible = false;
            buttonDigital.Visible = false;
            panel6.Visible = false;
            labelCodResp.Visible = false;
            textCodResp.Visible = false;
            materialTabControl1.SelectedIndex = 1;
            selectedButton = 5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            painelEsquerdo.Visible = false;
            menuIndicador.Text = "Home";
            menuIndicador.IconChar = FontAwesome.Sharp.IconChar.Home;
            menuIndicador.ForeColor = Color.FromArgb(230, 57, 70);
            menuIndicador.IconColor = Color.FromArgb(230, 57, 70);
            botaoInativo();
            materialTabControl1.SelectedIndex = 2;
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


        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = Path.GetExtension(filePath); //get the file extension  
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        int qtdItems = lista.Items.Count;
                        for (int i = 0; i < qtdItems; i++)
                            lista.Items.RemoveAt(0);

                        var xls = new XLWorkbook(filePath);
                        textFile.Text = filePath;
                        var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
                        var totalLinhas = planilha.Rows().Count();
                        for (int l = 2; l <= totalLinhas; l++)
                        {
                            ListViewItem item = new ListViewItem(planilha.Cell($"A{l}").Value.ToString());
                            item.SubItems.Add(planilha.Cell($"C{l}").Value.ToString());
                            item.SubItems.Add(planilha.Cell($"D{l}").Value.ToString());
                            DateTime dia_pag;
                            try
                            {
                                dia_pag = Convert.ToDateTime(planilha.Cell($"B{l}").Value.ToString());
                                item.SubItems.Add($"{dia_pag.Year}-{dia_pag.Month}-{dia_pag.Day}");
                            }
                            catch (Exception) {};
                            

                            lista.Items.Add(item);
                        }

                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Arquivo Invalido");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor escolher um arquivo excel de extensão .xls or .xlsx.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                }
            }
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (selectedButton < 4)
            {
                try
                {
                    string cpf = textCpf.Text;
                    int ver = (cpf[0] - '0') + (cpf[1] - '0') * 2 + (cpf[2] - '0') * 3 + (cpf[3] - '0') * 4 + (cpf[4] - '0') * 5 + (cpf[5] - '0') * 6 + (cpf[6] - '0') * 7 + (cpf[7] - '0') * 8 + (cpf[8] - '0') * 9;
                    ver %= 11;
                    ver %= 10;
                    if (ver == (cpf[9] - '0'))
                    {
                        ver = (cpf[1] - '0') + (cpf[2] - '0') * 2 + (cpf[3] - '0') * 3 + (cpf[4] - '0') * 4 + (cpf[5] - '0') * 5 + (cpf[6] - '0') * 6 + (cpf[7] - '0') * 7 + (cpf[8] - '0') * 8 + ver * 9;
                        ver %= 11;
                        ver %= 10;
                        if (ver == (cpf[10] - '0'))
                        {
                            MessageBox.Show("CPF Válido");
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("CPF Inválido");
                }
            }
            else if (selectedButton == 4)
            {
                try
                {
                    secretaria sec = new secretaria(textSenha.Text, textNome.Text, textEmail.Text);
                    sec.criaSecretaria();
                    MessageBox.Show("Secretaria criada com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada invalida");
                }
            }
            else if (selectedButton == 5)
            {
                try
                {
                    Adm admin = new Adm(textSenha.Text, textNome.Text, textEmail.Text);
                    admin.criaAdm();
                    MessageBox.Show("Adiministrador criado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada invalida");
                }
            }
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            if (selectedButton == 4)
            {
                try
                {
                    secretaria sec = new secretaria(Int32.Parse(textCod.Text));
                    sec = sec.buscaSecretaria();
                    textEmail.Text = sec.email;
                    textNome.Text = sec.nome;
                    textSenha.Text = sec.Senha1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada Invalida");
                }
            }
            else if (selectedButton == 5)
            {
                try
                {
                    Adm admin = new Adm(Int32.Parse(textCod.Text));
                    admin = admin.buscaAdm();
                    textEmail.Text = admin.email;
                    textNome.Text = admin.nome;
                    textSenha.Text = admin.Senha1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada Invalida");
                }
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (selectedButton < 4)
            {
                try
                {
                    string cpf = textCpf.Text;
                    int ver = (cpf[0] - '0') + (cpf[1] - '0') * 2 + (cpf[2] - '0') * 3 + (cpf[3] - '0') * 4 + (cpf[4] - '0') * 5 + (cpf[5] - '0') * 6 + (cpf[6] - '0') * 7 + (cpf[7] - '0') * 8 + (cpf[8] - '0') * 9;
                    ver %= 11;
                    ver %= 10;
                    if (ver == (cpf[9] - '0'))
                    {
                        ver = (cpf[1] - '0') + (cpf[2] - '0') * 2 + (cpf[3] - '0') * 3 + (cpf[4] - '0') * 4 + (cpf[5] - '0') * 5 + (cpf[6] - '0') * 6 + (cpf[7] - '0') * 7 + (cpf[8] - '0') * 8 + ver * 9;
                        ver %= 11;
                        ver %= 10;
                        if (ver == (cpf[10] - '0'))
                        {
                            MessageBox.Show("CPF Válido");
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("CPF Inválido");
                }
            }
            else if (selectedButton == 4)
            {
                try
                {
                    secretaria sec = new secretaria(textSenha.Text, Int32.Parse(textCod.Text), textNome.Text, textEmail.Text);
                    sec.atualizaSecretaria();
                    MessageBox.Show("Secretaria atualizado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada invalida");
                }
            }
            else if (selectedButton == 5)
            {
                try
                {
                    Adm admin = new Adm(textSenha.Text, Int32.Parse(textCod.Text), textNome.Text, textEmail.Text);
                    admin.atualizaAdm();
                    MessageBox.Show("Adiministrador atualizado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada invalida");
                }
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (selectedButton == 4)
            {
                try
                {
                    secretaria sec = new secretaria(Int32.Parse(textCod.Text));
                    sec.apagaSecretaria();
                    MessageBox.Show("Secretaria apagado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada Invalida");
                }
            }
            else if (selectedButton == 5)
            {
                try
                {
                    Adm admin = new Adm(Int32.Parse(textCod.Text));
                    admin.apagaAdm();
                    MessageBox.Show("Adiministrador apagado com sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Entrada Invalida");
                }
            }
        }

        private void buttonAddPagamentos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lista.Items)
            {
                
                    Pagamento pag = new Pagamento(item.SubItems[3].Text, item.Text, item.SubItems[1].Text, item.SubItems[2].Text);
                    pag.criaPagamento();
                


            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVerDigital_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@"server=localhost;database=projeto_cobra_kai;Uid=root;Pwd=1234;");
                string comando = "SELECT count(*) from pagamento where (Month(data_pag) = Month(sysdate()) or Month(data_pag) = Month(sysdate())-1) and fk_Responsavel_cod_aluno = @cod_aluno";
                int retorno = -1; ;
                MySqlCommand cmd = new MySqlCommand(comando, conn);
                cmd.Parameters.AddWithValue("@cod_aluno", textVerDigital.Text);
                conn.Open();
                retorno = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                if (retorno > 0)
                {
                    MessageBox.Show("Aluno Liberado");
                }
                else
                {
                    MessageBox.Show("O aluno nao esta liberado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Invalida");
            }
        }
    }
}
