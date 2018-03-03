using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ficha_Avaliacao_2
{
    public partial class FormEncriptador9999 : System.Windows.Forms.Form
    {
        public FormEncriptador9999()
        {
            InitializeComponent();
        }

        private void btnAbrirFicheiro_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ficheiro Texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Erro na Leitura do ficheiro");
                }
            }
        }

        private void btnGuardarFicheiro_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Ficheiro Texto (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na gravação do ficheiro");
                }
            }
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Encripta(richTextBox1.Text);
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Desencripta(richTextBox1.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private string Encripta(string Texto)
        {
            string resultado = "";
            foreach (char letra in Texto)
            {
                int a = 0;
                if ((letra > 64 && letra < 91) || (letra >  96 && letra < 123))
                    a = letra.ToString().ToLower().ToCharArray()[0] < 'x' ? 3 : -23;
                resultado += (char)(letra + a);
            }

            return resultado;
        }

        private string Desencripta(string Texto)
        {
            string resultado = "";
            foreach (char letra in Texto)
            {
                int a = 0;
                if ((letra > 64 && letra < 91) || (letra > 96 && letra < 123))
                    a = letra.ToString().ToLower().ToCharArray()[0] > 'c' ? -3 : 23;
                resultado += (char)(letra + a);
            }

            return resultado;
        }
    }
}
