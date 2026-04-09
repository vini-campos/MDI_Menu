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

namespace Menu_Calculos
{
    public partial class frmCalculosBot : Form
    {
        public frmCalculosBot()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            lblResul2.Text = " ";
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }

        private void btnFecharTetxo_Click(object sender, EventArgs e)
        {
            Close(); // fecha a janela
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); 
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "+";
                lblResultado.Text = (a + b).ToString();
                lblResul2.Text = " ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só são permitidos números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); 
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "-"; 
                lblResultado.Text = (a - b).ToString();
                lblResul2.Text = " ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só são permitidos números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text);
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "*"; 
                lblResultado.Text = (a * b).ToString(); 
                lblResul2.Text = " ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtN1.Text); 
            double b = double.Parse(txtN2.Text);

            if (b == 0)
            {
                MessageBox.Show("Não é possivel fazer divisão por zero!");
                lblResultado.Text = "";
            }
            else
            {
                try
                {

                    lblSinal.Text = "/";
                    lblResultado.Text = (a / b).ToString(); 
                    lblResul2.Text = " ";
                }

                catch (FormatException)
                {
                    MessageBox.Show("Só é permitido números neste campo!");
                    button2_Click(sender, e);
                }
            }
            
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); 
                double b = double.Parse(txtN2.Text);

                string typeA = (a % 2 == 0) ? "par" : "ímpar";
                string typeB = (b % 2 == 0) ? "par" : "ímpar";
                
                lblSinal.Text = "";
                lblResul2.Text = $"{a}: {typeA}; {b}: {typeB}.";
                lblResultado.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
            
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); 
                double b = double.Parse(txtN2.Text);
                string Exibir = "";

                if (a > b)
                {
                    Exibir = $"{a} > {b}";
                } else if (a < b)
                {
                    Exibir = $"{a} < {b}";
                }
                else
                {
                    Exibir = $"{a} == {b}";
                }

                lblSinal.Text = "";
                lblResultado.Text = Exibir;
                lblResul2.Text = " ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }
    }
}
