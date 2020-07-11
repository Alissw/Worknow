using System.Windows.Forms;

namespace View
{
    partial class FrmMenu
    {
        private System.Windows.Forms.Label lbInfo_1;
        private System.Windows.Forms.Button btn_CadastrarAutonomo;
        private System.Windows.Forms.Button btnCdastrarMei;
        private System.Windows.Forms.Label lbInfo_2;
        private System.Windows.Forms.Button btn_EntrarMei;
        private System.Windows.Forms.Button btn_EntrarAutonomo;
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();
            // 
            // lbInfo_1
            // 
            this.lbInfo_1 = new lib.LabelMenu();
            this.lbInfo_1.AutoSize = true;
            this.lbInfo_1.Location = new System.Drawing.Point(27, 24);
            this.lbInfo_1.Name = "lbInfo_1";
            this.lbInfo_1.TabIndex = 0;
            this.lbInfo_1.Text = "Ainda não possui cadastro?";
            // 
            // btn_CadastrarAutonomo
            // 
            this.btn_CadastrarAutonomo = new lib.ButtonMenu();
            this.btn_CadastrarAutonomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadastrarAutonomo.Location = new System.Drawing.Point(28, 61);
            this.btn_CadastrarAutonomo.Name = "btn_CadastrarAutonomo";
            this.btn_CadastrarAutonomo.TabIndex = 1;
            this.btn_CadastrarAutonomo.Text = "Cadastrar-se como autônomo";
            this.btn_CadastrarAutonomo.UseVisualStyleBackColor = true;
            this.btn_CadastrarAutonomo.Click += new System.EventHandler(this.btn_Autonomo_Click);
            // 
            // btnCdastrarMei
            // 
            this.btnCdastrarMei = new lib.ButtonMenu();
            this.btnCdastrarMei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdastrarMei.Location = new System.Drawing.Point(28, 125);
            this.btnCdastrarMei.Name = "btnCdastrarMei";
            this.btnCdastrarMei.TabIndex = 1;
            this.btnCdastrarMei.Text = "Cadastrar-se como MEI";
            this.btnCdastrarMei.UseVisualStyleBackColor = true;
            this.btnCdastrarMei.Click += new System.EventHandler(this.btnCdastrarMei_Click);
            // 
            // lbInfo_2
            // 
            this.lbInfo_2 = new lib.LabelMenu();
            this.lbInfo_2.AutoSize = true;
            this.lbInfo_2.Location = new System.Drawing.Point(9, 212);
            this.lbInfo_2.Name = "lbInfo_2";
            this.lbInfo_2.TabIndex = 0;
            this.lbInfo_2.Text = "Já possui cadastro? Entre agora";
            // 
            // btn_EntrarMei
            // 
            this.btn_EntrarMei = new lib.ButtonMenu();
            this.btn_EntrarMei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntrarMei.Location = new System.Drawing.Point(28, 311);
            this.btn_EntrarMei.Name = "btn_EntrarMei";
            this.btn_EntrarMei.Size = new System.Drawing.Size(228, 46);
            this.btn_EntrarMei.TabIndex = 2;
            this.btn_EntrarMei.Text = "Entrar como MEI";
            this.btn_EntrarMei.UseVisualStyleBackColor = true;
            // 
            // btn_EntrarAutonomo
            // 
            this.btn_EntrarAutonomo = new lib.ButtonMenu();
            this.btn_EntrarAutonomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntrarAutonomo.Location = new System.Drawing.Point(28, 247);
            this.btn_EntrarAutonomo.Name = "btn_EntrarAutonomo";
            this.btn_EntrarAutonomo.Size = new System.Drawing.Size(228, 46);
            this.btn_EntrarAutonomo.TabIndex = 3;
            this.btn_EntrarAutonomo.Text = "Entrar como autônomo";
            this.btn_EntrarAutonomo.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.btn_EntrarMei);
            this.Controls.Add(this.btn_EntrarAutonomo);
            this.Controls.Add(this.btnCdastrarMei);
            this.Controls.Add(this.btn_CadastrarAutonomo);
            this.Controls.Add(this.lbInfo_2);
            this.Controls.Add(this.lbInfo_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

