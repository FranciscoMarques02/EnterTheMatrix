using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterTheMatrix
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idade = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(txbAnoNasc.Text);

                if (idade >= 18)
                {
                    pibResultado.Image = Properties.Resources.aceito;
                    lblResultado.Text = "Bem vindo " + txbNome.Text.ToUpper() + " " + txbSobrenome.Text.ToUpper();
                    lblResultado.ForeColor = Color.Lime;
                }
                else
                {
                    pibResultado.Image = Properties.Resources.erro;
                    lblResultado.Text = "ACESSO NEGADO!";
                    lblResultado.ForeColor = Color.Red;
                }
            }
            catch
            {
                lblResultado.Text = "PREENCHA OS CAMPOS!";
                lblResultado.ForeColor = Color.Red;
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbAnoNasc.Text = "";
            txbNome.Text = "";
            txbSobrenome.Text = "";
            lblResultado.Text = "";
            pibResultado.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
