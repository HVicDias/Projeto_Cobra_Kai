
using System.Drawing.Text;
using System.IO;
using System;
using System.Drawing;

namespace Projeto_Cobra_Kai
{
    partial class telaLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEntrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.showPassword = new FontAwesome.Sharp.IconButton();
            this.labelValidaSenha = new MaterialSkin.Controls.MaterialLabel();
            this.labelValidaEmail = new MaterialSkin.Controls.MaterialLabel();
            this.textSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.labelSenha = new MaterialSkin.Controls.MaterialLabel();
            this.textEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLogIn = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCobraKai = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(387, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 353);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 54);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.buttonEntrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(64, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 48);
            this.panel1.TabIndex = 0;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.AutoSize = true;
            this.buttonEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEntrar.Depth = 0;
            this.buttonEntrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEntrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEntrar.Icon = null;
            this.buttonEntrar.Location = new System.Drawing.Point(0, 0);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Primary = false;
            this.buttonEntrar.Size = new System.Drawing.Size(116, 48);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.showPassword, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelValidaSenha, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelValidaEmail, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textSenha, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelUsuario, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSenha, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textEmail, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.10256F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67521F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36752F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 234);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // showPassword
            // 
            this.showPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showPassword.FlatAppearance.BorderSize = 0;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.showPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.showPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.showPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showPassword.IconSize = 24;
            this.showPassword.Location = new System.Drawing.Point(219, 154);
            this.showPassword.Margin = new System.Windows.Forms.Padding(0);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(25, 29);
            this.showPassword.TabIndex = 4;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mostraSenha);
            this.showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.escondeSenha);
            // 
            // labelValidaSenha
            // 
            this.labelValidaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValidaSenha.AutoSize = true;
            this.labelValidaSenha.Depth = 0;
            this.labelValidaSenha.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValidaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelValidaSenha.Location = new System.Drawing.Point(24, 183);
            this.labelValidaSenha.Margin = new System.Windows.Forms.Padding(0);
            this.labelValidaSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelValidaSenha.Name = "labelValidaSenha";
            this.labelValidaSenha.Size = new System.Drawing.Size(195, 48);
            this.labelValidaSenha.TabIndex = 5;
            this.labelValidaSenha.Text = "senha ou e-mail incorreto";
            // 
            // labelValidaEmail
            // 
            this.labelValidaEmail.AutoSize = true;
            this.labelValidaEmail.Depth = 0;
            this.labelValidaEmail.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValidaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelValidaEmail.Location = new System.Drawing.Point(24, 70);
            this.labelValidaEmail.Margin = new System.Windows.Forms.Padding(0);
            this.labelValidaEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelValidaEmail.Name = "labelValidaEmail";
            this.labelValidaEmail.Size = new System.Drawing.Size(128, 24);
            this.labelValidaEmail.TabIndex = 4;
            this.labelValidaEmail.Text = "email inválido";
            // 
            // textSenha
            // 
            this.textSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSenha.Depth = 0;
            this.textSenha.Hint = "";
            this.textSenha.Location = new System.Drawing.Point(27, 155);
            this.textSenha.MaxLength = 32767;
            this.textSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '\0';
            this.textSenha.SelectedText = "";
            this.textSenha.SelectionLength = 0;
            this.textSenha.SelectionStart = 0;
            this.textSenha.Size = new System.Drawing.Size(189, 28);
            this.textSenha.TabIndex = 3;
            this.textSenha.TabStop = false;
            this.textSenha.Text = "Senha";
            this.textSenha.UseSystemPasswordChar = true;
            this.textSenha.Click += new System.EventHandler(this.textSenha_Click);
            this.textSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Depth = 0;
            this.labelUsuario.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUsuario.Location = new System.Drawing.Point(24, 14);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(195, 24);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSenha.AutoSize = true;
            this.labelSenha.Depth = 0;
            this.labelSenha.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSenha.Location = new System.Drawing.Point(24, 128);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(0);
            this.labelSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(195, 24);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.BackColor = System.Drawing.Color.White;
            this.textEmail.Depth = 0;
            this.textEmail.ForeColor = System.Drawing.Color.White;
            this.textEmail.Hint = "";
            this.textEmail.Location = new System.Drawing.Point(27, 41);
            this.textEmail.MaxLength = 32767;
            this.textEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.SelectedText = "";
            this.textEmail.SelectionLength = 0;
            this.textEmail.SelectionStart = 0;
            this.textEmail.Size = new System.Drawing.Size(189, 28);
            this.textEmail.TabIndex = 2;
            this.textEmail.TabStop = false;
            this.textEmail.Text = "e-mail";
            this.textEmail.UseSystemPasswordChar = false;
            this.textEmail.Click += new System.EventHandler(this.textEmail_Click);
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.labelLogIn, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(305, 80);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(415, 170);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Depth = 0;
            this.labelLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogIn.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLogIn.Location = new System.Drawing.Point(86, 0);
            this.labelLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(243, 170);
            this.labelLogIn.TabIndex = 0;
            this.labelLogIn.Text = "Log In";
            this.labelLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.labelCobraKai, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 603);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1000, 249);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // labelCobraKai
            // 
            this.labelCobraKai.AutoSize = true;
            this.labelCobraKai.Depth = 0;
            this.labelCobraKai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobraKai.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCobraKai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCobraKai.Location = new System.Drawing.Point(203, 0);
            this.labelCobraKai.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCobraKai.Name = "labelCobraKai";
            this.labelCobraKai.Size = new System.Drawing.Size(594, 249);
            this.labelCobraKai.TabIndex = 4;
            this.labelCobraKai.Text = "Cobra Kai";
            this.labelCobraKai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telaLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1024, 853);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "telaLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powered by VÖR";
            this.Load += new System.EventHandler(this.telaLogIn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textEmail;
        private MaterialSkin.Controls.MaterialLabel labelSenha;
        private MaterialSkin.Controls.MaterialLabel labelUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField textSenha;
        private MaterialSkin.Controls.MaterialLabel labelValidaSenha;
        private MaterialSkin.Controls.MaterialLabel labelValidaEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialLabel labelLogIn;
        private MaterialSkin.Controls.MaterialLabel labelCobraKai;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton buttonEntrar;
        private FontAwesome.Sharp.IconButton showPassword;
    }
}

