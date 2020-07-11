using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace View
{
    partial class FrmEmpreendedor
    {
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
        private Button btCancelar;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {   
            this.components = new Container();

            this.Text = "Cadastro Empreendedor MEI ";
            this.Size = new Size (300, 500);
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;            

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
            this.txtSenha.PasswordChar = '*';
            this.Controls.Add(txtSenha);

            this.lbConfirmaSenha = new Label();
            this.lbConfirmaSenha.Text = "Confirmar Senha";
            this.lbConfirmaSenha.ForeColor = Color.Black;
            this.lbConfirmaSenha.Location = new Point(20, 355);
            this.Controls.Add(lbConfirmaSenha);

            this.txtConfirmaSenha = new TextBox();
            this.txtConfirmaSenha.Location = new Point(20, 385);
            this.txtConfirmaSenha.Size = new Size(100, 165);
            this.txtConfirmaSenha.PasswordChar = '*';
            this.Controls.Add(txtConfirmaSenha);

            btConfirma = new lib.Button();
            btConfirma.Text = "Confirmar";
            btConfirma.Location = new Point(20, 420);
            btConfirma.Click += new EventHandler(this.btnConfirmar_Click);
            this.Controls.Add(btConfirma);

            btCancelar = new lib.Button();
            btCancelar.Text = "Cancelar";
            btCancelar.Location = new Point(100, 420);
            btCancelar.Click += new EventHandler(this.btnCancelar_Click);
            this.Controls.Add(btCancelar);
        }
    }
}

