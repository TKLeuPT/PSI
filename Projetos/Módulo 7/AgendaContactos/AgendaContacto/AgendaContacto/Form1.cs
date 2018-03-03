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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int indice)
        {
            InitializeComponent();
            nometxt.Text = Agenda.listaContacto[indice].Nome;
            moradatxt.Text = Agenda.listaContacto[indice].Morada;
            emailtxt.Text = Agenda.listaContacto[indice].Email;
            datanascimentodtp.Value = Agenda.listaContacto[indice].DataNascimento;
            telemoveltxt.Text = Agenda.listaContacto[indice].Nome;
            pictureBox1.ImageLocation = Text = Agenda.listaContacto[indice].Foto;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nometxt.Clear();
            moradatxt.Clear();
            emailtxt.Clear();
            datanascimentodtp.Value = DateTime.Now;
            telemoveltxt.Clear();
            pictureBox1.ImageLocation = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Todos os ficheiros de imagem |*.jpg|*.png|*.gif";
            try
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.ImageLocation != null)
                {
                    Contacto novo = new Contacto(nometxt.Text, moradatxt.Text, emailtxt.Text,
                telemoveltxt.Text, datanascimentodtp.Value, pictureBox1.ImageLocation.ToString());

                    Agenda.AddContacto(novo);
                }
                else
                {
                    Contacto novo = new Contacto(nometxt.Text, moradatxt.Text, emailtxt.Text,
              telemoveltxt.Text, datanascimentodtp.Value,null);
                    Agenda.AddContacto(novo);
                }
                MessageBox.Show("Registo Guardado com Sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }
    }
}
