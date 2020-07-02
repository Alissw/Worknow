using System;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class FrmEmpreendedor : Form
    {
        public FrmEmpreendedor()
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

        public void btnCancelar_Click(object sender, EventArgs e){
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();

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
