using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            if (lblContas.Text.StartsWith("n"))
            {
                lblContas.Text = "";
            }
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
            if (vOperacao == "xʸ") vOperacao = "^";
            lblContas.Text = vNumAnter + " " + vOperacao;
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
                    if (vNumAtual == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblVisor.Text = "0";
                    }
                    else
                        lblVisor.Text = (vNumAnter / vNumAtual).ToString();
                    break;
                case "^":
                    lblVisor.Text = Convert.ToString(Math.Pow(vNumAnter, vNumAtual));
                    break;

            }

            if (lblVisor.Text.Length >= 13)
            {
                lblContas.Text = "numero muito extenso";
                lblVisor.Text = "";
                
                return;
            }
            lblContas.Text = vNumAnter + " " + vOperacao + " " + vNumAtual;
            vLimparVisor = true;
            
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            vNumAnter = 0;
            lblContas.Text = "";
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            vLimparVisor = true;
        }

        private void btnBackSpc_Click(object sender, EventArgs e)
        {

            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text.Length == 0) lblVisor.Text = "0";
        }

        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            Button botao = new Button();

            //esc
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            //numeros
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                botao.Text = e.KeyCode.ToString().Substring(e.KeyCode.ToString().Length - 1);
                f_digitos(botao, e);
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                botao.Text = ",";
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                botao.Text = "+/-";
            }

                switch (e.KeyCode)
                {
                    //operaçoes teclado numerico
                    case Keys.Add:
                        botao.Text = "+";
                        f_operacoes(botao, e);
                        break;
                    case Keys.Subtract:
                        botao.Text = "-";
                        f_operacoes(botao, e);
                        break;
                    case Keys.Multiply:
                        botao.Text = "x";
                        f_operacoes(botao, e);
                        break;
                    case Keys.Divide:
                        botao.Text = ":";
                        f_operacoes(botao, e);
                        break;
                    case Keys.PageUp:
                        botao.Text = "^";
                        f_operacoes(botao, e);
                        break;
                    //operações teclado normal


                    case Keys.Back:
                        lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
                        if (lblVisor.Text.Length == 0) lblVisor.Text = "0";
                        break;

                    case Keys.Return:
                        btnResult_Click(botao, e);
                        break;

                    case Keys.Oemcomma:
                        if (!lblVisor.Text.Contains(",")) lblVisor.Text += ",";

                        break;

                case Keys.OemMinus:
                        btnMaisMenos_Click(botao, e);
                    break;

                }

            foreach (Control bot in panel1.Controls)
            {
               

                if (((Button)bot).Text == botao.Text)
                {
                    bot.BackColor = ColorTranslator.FromHtml("#bfcddb");
                }
            }

            foreach (Control bot in panel2.Controls)
            {
                if (((Button)bot).Text == botao.Text)
                {
                    bot.BackColor = ColorTranslator.FromHtml("#bfcddb");
                }
            }

        }

        private void frmCalculadora_KeyUp(object sender, KeyEventArgs e)
        {

            foreach(Control botao in panel1.Controls)
            {
                botao.BackColor = Color.White;
            }

            foreach (Control botao in panel2.Controls)
            {
                botao.BackColor = Color.White;
            }
        }
    }
}
