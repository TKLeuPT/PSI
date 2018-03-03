using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Mod_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (pictureBox1.ImageLocation != null)
                {
                    Pizza novo = new Pizza(nometxt.Text, ingrediente1txt.Text, ingrediente2txt.Text,
                ingrediente3txt.Text, ingrediente4txt.Text, ingrediente5txt.Text, pictureBox1.ImageLocation.ToString());

                    MenuPizza.AddPizza(novo);
                }
                else
                {
                    Pizza novo = new Pizza(nometxt.Text, ingrediente1txt.Text, ingrediente2txt.Text,
                 ingrediente3txt.Text, ingrediente4txt.Text, ingrediente5txt.Text, null);
                    MenuPizza.AddPizza(novo);
                }
                MessageBox.Show("Registo Guardado com Sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPizza.GuardarFicheiro();
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
    }
}
