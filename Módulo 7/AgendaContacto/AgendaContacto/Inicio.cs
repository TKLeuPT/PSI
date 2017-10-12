using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContacto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void novoContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Agenda.AbrirFicheiro();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda.GuardarFicheiro();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagem f = new Listagem();
            f.MdiParent = this;
            f.Show();
        }
    }
}
