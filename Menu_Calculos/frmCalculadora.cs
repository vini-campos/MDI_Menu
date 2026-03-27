using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Menu_Calculos
{
    public partial class frmCalculadora : Form
    {
        
        double vNumAnter;
        string vOperacao;
        bool vLimparVisor;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;

            if (lblVisor.Text == "0" || vLimparVisor)
            {
                lblVisor.Text = "";
                vLimparVisor = false;
            }
            lblVisor.Text += digito;
            
        }
       
        private void f_operacoes(object sender, EventArgs e)
        {
            vNumAnter = double.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(",")) lblVisor.Text += ",";
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            lblVisor.Text = (double.Parse(lblVisor.Text) * -1).ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double vNumAtual = double.Parse(lblVisor.Text);
            switch(vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnter + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnter - vNumAtual).ToString();
                    break;
                case "x":
                    lblVisor.Text = (vNumAnter * vNumAtual).ToString();
                    break;
                case ":":
                    //verificar divisão por zero, ainda tem que ser feito
                    lblVisor.Text = (vNumAnter / vNumAtual).ToString();
                    break;
                case "xʸ":
                    lblVisor.Text = Convert.ToString(Math.Pow(vNumAnter, vNumAtual));
                    break;

            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            vNumAnter = 0;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            //fazer essa porra que não funciona
        }

        private void btnBackSpc_Click(object sender, EventArgs e)
        {

            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text.Length == 0) lblVisor.Text = "0";
        }
    }
}
