using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "/";
        }

        private void rb_soma_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "+";
        }

        private void rb_sub_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "-";
        }

        private void rb_multi_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "x";
        }

        private void rb_pot_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "yˣ";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txt1.Text);
                double b = double.Parse(txt2.Text);

                if (lbl1.Text == "+")
                {
                    lblres.Text = Convert.ToString(a + b);
                }
                else if (lbl1.Text == "-")
                {
                    lblres.Text = Convert.ToString(a - b);
                }
                else if (lbl1.Text == "x")
                {
                    lblres.Text = Convert.ToString(a * b);
                }
                else if (lbl1.Text == "/")
                {
                    if (b == 0)
                    {
                        MessageBox.Show("Não é possivel dividir por zero!");
                        btnLimpar_Click(sender, e);
                        txt1.Text = "";
                        txt2.Text = "";
                    }
                    else
                        lblres.Text = Convert.ToString(a / b);
                }

                else if (lbl1.Text == "yˣ")
                {
                    lblres.Text = Convert.ToString(Math.Pow(a, b));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                btnLimpar_Click(sender, e);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbl1.Text = "?";
            lblres.Text = "?";
            txt1.Clear();
            txt2.Clear();
            txt1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
