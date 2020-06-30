using System;
using System.Windows.Forms;
using Controller;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnConfirmar_Click(object sender, EventArgs e){
            if(
                txtRazaoSocial.Text != "" &&
                txtNomeFantasia.Text != "" &&
                txtCNPJ.Text != "" &&
                txtCEP.Text != "" &&
                txtSenha.Text != "" &&
                txtConfirmaSenha.Text != ""
            ){
                try
                {
                    EmpreendedorMeiController.InserirEmpreendedor(
                        txtRazaoSocial.Text,
                        txtNomeFantasia.Text,
                        txtCNPJ.Text,
                        txtCEP.Text,
                        txtSenha.Text,
                        txtConfirmaSenha.Text
                    );

                    MessageBox.Show(
                        "Dados cadastrados com sucesso!",
                        "Cadastro concluído!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(
                        "Falha ao realizar cadastro no banco de dados!",
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }else{
                MessageBox.Show(
                    "Preencha todos os campos!",
                    "Alerta!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }

        }

        public void btnSair_Click(object sender, EventArgs e){
            this.Close();
        }

        
        //Desabilita o botão fechar do formulário
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
    }
}
