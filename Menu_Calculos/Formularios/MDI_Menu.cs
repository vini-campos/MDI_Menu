using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos.Formularios
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void OpenChildForm<T>() where T : Form, new()
        {
            var existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (existingForm != null)
            {
                // Se já existe, traz para frente e ativa
                existingForm.BringToFront();
                existingForm.Activate();
            }
            else
            {
                // Se não existe, cria e exibe
                var newForm = new T
                {
                    MdiParent = this,
                };
                newForm.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmCalculosBot>(); // ChildForm é o tipo do formulário filho
        }
        
        private void MDI_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja REALMENTE sair?", "Saindo...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Mensagem(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staHora.Text = "Data e Hora: " + DateTime.Now.ToString();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmCalculosBot>(); // ChildForm é o tipo do formulário filho
        }
    }
}
