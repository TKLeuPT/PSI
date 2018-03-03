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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Listagem_Load(object sender, EventArgs e)
        {
            foreach (Contacto c in Agenda.listaContacto)
            {
                ListViewItem item = new ListViewItem(new[] { c.Nome, c.Morada, c.Email, c.DataNascimento.ToString(), c.Telemovel });
                listView1.Items.Add(item);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            resultado = MessageBox.Show("Tem a certeza que deseja eliminar o Contacto?",
                "Atenção",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                Agenda.Eliminar(listView1.SelectedIndices[0]);
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
               
            }
        }

        public void abrir()
        {
            int posicao = listView1.SelectedIndices[0];
            Form1 novo = new Form1(posicao);
            novo.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void Listagem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //abrir();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            abrir();
        }
    }
}
