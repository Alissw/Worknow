using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCdastrarMei_Click(object sender, EventArgs e)
        {
            FrmEmpreendedor frmEmpreendedor = new FrmEmpreendedor();
            frmEmpreendedor.Show();
            this.Hide();
        }

        private void btn_Autonomo_Click(object sender, EventArgs e)
        {
            Autonomo autonomo = new Autonomo();
            autonomo.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
