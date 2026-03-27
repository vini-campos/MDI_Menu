using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void OpenChildForm<T>() where T : Form, new()
        {
            var existingForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (existingForm != null)
            {
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

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Mensagem(object sender, EventArgs e)
        {
            //Anderson ainda não explicou nada sobre isso, então não sei o que fazer aqui
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staHora.Text = "Data e Hora: " + DateTime.Now.ToString();
        }

        private void staUsuario_Click(object sender, EventArgs e)
        {
            staUsuario.Text = "Usuário: " + Environment.UserName;
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmCalculosBot>(); // ChildForm é o tipo do formulário filho
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmRadio>();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmCalculadora>();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void calcuadoraWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void visorÙnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmCalculadora>();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmRadio>();
        }
    }
}
