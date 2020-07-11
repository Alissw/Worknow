﻿using System;
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

        public void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (EmpreendedorMeiController.CamposPreenchidosCadastroEmpreendedorMEI(
                    txtRazaoSocial.Text,
                    txtNomeFantasia.Text,
                    txtCNPJ.Text,
                    txtCEP.Text,
                    txtSenha.Text,
                    txtConfirmaSenha.Text
                ))
                {
                    if (EmpreendedorMeiController.ConfirmarSenhas(txtSenha.Text, txtConfirmaSenha.Text))
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
                        this.Hide();

                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("As senhas são diferentes!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
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
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
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
