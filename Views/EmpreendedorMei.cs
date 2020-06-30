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
                }
                catch
                {
                    
                }
            }

        }

        public void btnSair_Click(object sender, EventArgs e){
            this.Close();
        }

    }
}
