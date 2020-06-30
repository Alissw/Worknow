using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Interfaces
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Label lbRazaoSocial;
        private TextBox txtRazaoSocial;
        private Label lbNomeFantasia;
        private TextBox txtNomeFantasia;
        private Label lbCNPJ;
        private MaskedTextBox txtCNPJ;
        private Label lbCEP;
        private MaskedTextBox txtCEP;
        private Label lbSenha;
        private TextBox txtSenha;
        private Label lbConfirmaSenha;
        private TextBox txtConfirmaSenha;
        private Button btConfirma;
        private Button btSair;

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
            this.components = new Container();

            this.Text = "Cadastro Empreendedor MEI ";
            this.Size = new Size (300, 500);
            this.Font = new Font(this.Font, FontStyle.Bold);

            this.lbRazaoSocial = new Label();
            this.lbRazaoSocial.Text = "Razão Social";
            this.lbRazaoSocial.ForeColor = Color.Black;
            this.lbRazaoSocial.Location = new Point(20,25);
            this.Controls.Add(lbRazaoSocial);

            this.txtRazaoSocial = new TextBox();
            this.txtRazaoSocial.Location = new Point(20, 55);
            this.txtRazaoSocial.Size = new Size(100,20);
            this.Controls.Add(txtRazaoSocial);

            this.lbNomeFantasia = new Label();
            this.lbNomeFantasia.Text = "Nome Fantasia";
            this.lbNomeFantasia.ForeColor = Color.Black;
            this.lbNomeFantasia.Location = new Point(20, 95);
            this.Controls.Add(lbNomeFantasia);

            this.txtNomeFantasia = new TextBox();
            this.txtNomeFantasia.Location = new Point(20, 125);
            this.txtNomeFantasia.Size = new Size(175,20);
            this.Controls.Add(txtNomeFantasia);

            this.lbCNPJ = new Label();
            this.lbCNPJ.Text = "CNPJ";
            this.lbCNPJ.ForeColor = Color.Black;
            this.lbCNPJ.Location = new Point(20, 165);
            this.Controls.Add(lbCNPJ);

            this.txtCNPJ = new MaskedTextBox();
            this.txtCNPJ.Location = new Point(20, 195);
            this.txtCNPJ.Size = new Size(175,20);
            this.txtCNPJ.Mask = " 00,000,000/0000-00";
            this.Controls.Add(txtCNPJ);

            this.lbCEP = new Label();
            this.lbCEP.Text = "CEP";
            this.lbCEP.ForeColor = Color.Black;
            this.lbCEP.Location = new Point(20, 225);
            this.Controls.Add(lbCEP);

            this.txtCEP = new MaskedTextBox();
            this.txtCEP.Location = new Point(20, 255);
            this.txtCEP.Size = new Size(100,20);
            this.txtCEP.Mask = "00000-000";
            this.Controls.Add(txtCEP);

            this.lbSenha = new Label();
            this.lbSenha.Text = "Senha";
            this.lbSenha.ForeColor = Color.Black;
            this.lbSenha.Location = new Point(20, 295);
            this.Controls.Add(lbSenha);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(20, 325);
            this.txtSenha.Size = new Size(100,20);
            this.Controls.Add(txtSenha);

            this.lbConfirmaSenha = new Label();
            this.lbConfirmaSenha.Text = "Confirmar Senha";
            this.lbConfirmaSenha.ForeColor = Color.Black;
            this.lbConfirmaSenha.Location = new Point(20, 355);
            this.Controls.Add(lbConfirmaSenha);

            this.txtConfirmaSenha = new TextBox();
            this.txtConfirmaSenha.Location = new Point(20, 385);
            this.txtConfirmaSenha.Size = new Size(100, 165);
            this.Controls.Add(txtConfirmaSenha);

            btConfirma = new Button();
            btConfirma.Text = "Confirmar";
            btConfirma.Location = new Point(20, 420);
            this.btConfirma.BackColor = ColorTranslator.FromHtml("#00c2cb");
            // btConfirma.Click += new EventHandler(btConfirmaClick);
            this.Controls.Add(btConfirma);

            btSair = new Button();
            btSair.Text = "Sair";
            btSair.Location = new Point(100, 420);
            this.btSair.BackColor = ColorTranslator.FromHtml("#00c2cb");
            // btSair.Click += new EventHandler(btSairClick);
            this.Controls.Add(btSair);
        }

        #endregion
    }
}

