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
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            
            if (lblVisor.Text == "0") {
                lblVisor.Text = digito;
            }
            else
            {
                lblVisor.Text += digito;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnVirg_Click(object sender, EventArgs e)
        {

        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
