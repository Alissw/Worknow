using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
     public class Formulario : Form {
          
        Label lbCadastro;
        Label lbLogin;
        Button btnCadastraAutonomo;
        Button btnCadastraMEI;
        // Button btnEntrarMEI;
        // Button btnEntrarAutonomo;
        // Button btVoltar;
        Button btSair;

        public Formulario(){

            this.Text = "WorkNow";
            this.Size = new Size(270, 370);

            lbCadastro = new Label();
            lbCadastro.Text = "Ainda não possui conta?";
            lbCadastro.Location = new Point(95,5);
            this.Controls.Add(lbCadastro);

            // lbLogin = new Label();
            // lbLogin.Text = "Já possui conta? Entre agora";
            // lbLogin.Location = new Point(95,5);
            // this.Controls.Add(lbLogin);

            btnCadastraAutonomo = new Button();
            btnCadastraAutonomo.Text = "Autonômo";
            btnCadastraAutonomo.Location = new Point(95, 45);
            btnCadastraAutonomo.Size = new Size (100,20);
            // btnCadastraAutonomo.Click += new EventHandler (btnCadastraAutonomoClick);
            this.Controls.Add(btnCadastraAutonomo);

            btnCadastraMEI = new Button();
            btnCadastraMEI.Text = "Autonomo MEI";
            btnCadastraMEI.Location = new Point(95, 65);
            btnCadastraMEI.Size = new Size (100,20);
            // btnCadastraMEI.Click += new EventHandler (btnCadastraMEIClick);
            this.Controls.Add(btnCadastraMEI);

            // btnEntrarMEI = new Button();
            // btnEntrarMEI.Text = "Entrar como Empreendedor MEI";
            // btnEntrarMEI.Location = new Point(95, 45);
            // btnEntrarMEI.Size = new Size (100,20);
            // this.btnEntrarMEI.BackColor = ColorTranslator.FromHtml("#00c2cb");
            // // btnEntrarMEI.Click += new EventHandler (btnEntrarMEIClick);
            // this.Controls.Add(btnEntrarMEI);

            // btnEntrarAutonomo = new Button();
            // btnEntrarAutonomo.Text = "Entrar como Autonômo";
            // btnEntrarAutonomo.Location = new Point(95, 45);
            // btnEntrarAutonomo.Size = new Size (100,20);
            // this.btnEntrarAutonomo.BackColor = ColorTranslator.FromHtml("#00c2cb");
            // // btnEntrarAutonomo.Click += new EventHandler (btnEntrarAutonomoClick);
            // this.Controls.Add(btnEntrarAutonomo);

            // btVoltar = new Button();
            // btVoltar.Text = "Voltar";
            // btVoltar.Location = new Point(95, 84);
            // btVoltar.Size = new Size (100,20);
            // btVoltar.Click += new EventHandler (btVoltarClick);
            // this.Controls.Add(btVoltar);

            btSair = new Button();
            btSair.Text = "Sair";
            btSair.Location = new Point(130, 300);
            btSair.Click += new EventHandler(btSairClick);
            this.Controls.Add(btSair);
        }

            // Botão para entrar como MEI

            // private void btnEntrarMEIClick(object sender, EventArgs e)
            // {
            //     ListaFilme listaFilme = new ListaFilme(this);
            //     listaFilme.Show();
            //     this.Hide();
            // }

            //  Botão para entrar como Autonomo

            // private void btnEntrarAutonomoClick(object sender, EventArgs e)
            // {
            //     ListaLocacao listaLocacao = new ListaLocacao(this);
            //     listaLocacao.Show();
            //     this.Hide();
            // }
            
            private void btSairClick(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}