using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    partial class Autonomo
    {   private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        Label LbNomeAutonomo;
        TextBox tbNomeAutonomo;

        Label lbCPF;
        MaskedTextBox mtbCPF;

        Label lbDataNascimento;
        MaskedTextBox mtbDataNascimento;

        Label lbServicosPrestados;
        TextBox tbServicosPrestados;

        Label lbCEP;
        MaskedTextBox mtbCEP;
        
        Label lbEmail;
        TextBox tbEmail;

        Button btnConfirmar;
        Button btnCancelar;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Text = "Cadastro Autonomo";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;  

            //NOME
            this.LbNomeAutonomo = new Label();
            this.LbNomeAutonomo.Text = "Nome: ";
            this.LbNomeAutonomo.Location = new Point(10,10);
            this.LbNomeAutonomo.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Controls.Add(LbNomeAutonomo);

            this.tbNomeAutonomo = new TextBox();
            this.tbNomeAutonomo.Location = new Point(10,30);
            this.tbNomeAutonomo.Size = new Size(180,20);
            this.Controls.Add(tbNomeAutonomo);


            //CPF
            this.lbCPF = new Label();
            this.lbCPF.Text = "CPF: ";
            this.lbCPF.Location = new Point(10,55);
            this.lbCPF.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Controls.Add(lbCPF);

            this.mtbCPF = new MaskedTextBox();
            this.mtbCPF.Location = new Point(10,70);
            this.mtbCPF.Size = new Size(85,20);
            this.mtbCPF.Mask = "000.000.000-00";
            this.Controls.Add(mtbCPF);


            //DATA DE NASCIMENTO
            this.lbDataNascimento = new Label();
            this.lbDataNascimento.Text = "Data de Nascimento: ";
            this.lbDataNascimento.Location = new Point(10,100);
            this.lbDataNascimento.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Controls.Add(lbDataNascimento);

            this.mtbDataNascimento = new MaskedTextBox();
            this.mtbDataNascimento.Location = new Point(10,115);
            this.mtbDataNascimento.Size = new Size(70,20);
            this.mtbDataNascimento.Mask = "00/00/0000";
            this.Controls.Add(mtbDataNascimento);


            //SERVIÇO PRESTADO
            this.lbServicosPrestados = new Label();
            this.lbServicosPrestados.Text = "Serviços Prestados: ";
            this.lbServicosPrestados.Location = new Point(10,145);
            this.lbServicosPrestados.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Controls.Add(lbServicosPrestados);

            this.tbServicosPrestados = new TextBox();
            this.tbServicosPrestados .Location = new Point(10,160);
            this.tbServicosPrestados.Size = new Size(150,20);
            this.Controls.Add(tbServicosPrestados);


            //CEP
            this.lbCEP = new Label();
            this.lbCEP.Text = "CEP: ";
            this.lbCEP.Location = new Point(10,190);
            this.lbCEP.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Controls.Add(lbCEP);

            this.mtbCEP = new MaskedTextBox();
            this.mtbCEP.Location = new Point(10,205);
            this.mtbCEP.Size = new Size(70,20);
            this.mtbCEP.Mask = "00000-000";
            this.Controls.Add(mtbCEP);


            //EMAIL
            this.lbEmail = new Label();
            this.lbEmail.Text = "Email: ";
            this.lbEmail.Location = new Point(10,235);
            this.lbEmail.AutoSize = true;
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Controls.Add(lbEmail);

            this.tbEmail = new TextBox();
            this.tbEmail.Location = new Point(10,250);
            this.tbEmail.Size = new Size(150,20);
            this.Controls.Add(tbEmail);


            this.btnConfirmar = new Button();
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Size = new Size(80,30);
            this.btnConfirmar.Location = new Point(20,280);
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
            this.Controls.Add(btnConfirmar);

            this.btnCancelar = new Button();
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Size = new Size(80,30);
            this.btnCancelar.Location = new Point(130,280);
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            this.Controls.Add(btnCancelar);
        }

        #endregion
    }
}

