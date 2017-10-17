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

namespace Teste_Mod7
{
    public partial class Form1 : Form
    {
        public string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void NovoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirFicheiroBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Ficheiros de Texto(*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            try
            {
                if (File.Exists(path))
                {
                    richTextBox1.Text = File.ReadAllText(path);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());

            }
        }

        private void guardarFicheiroBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            path = saveFileDialog1.FileName;
            if (path != String.Empty)
            {
                File.WriteAllText(path, richTextBox1.Text);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private static char Cripta(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string Encriptar(string input, int key)
        {
            string output = string.Empty;
            
            foreach (char ch in input)
                output += Cripta(ch, key);

            return output;
        }

        public static string Desencriptar(string input, int key)
        {
            return Encriptar(input, 26 - key);
        }

        private void EncriptarBtn_Click(object sender, EventArgs e)
        {
           richTextBox1.Text= Encriptar(richTextBox1.Text,3);
        }

        private void DesencriptarBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Desencriptar(richTextBox1.Text, 3);
        }
    }
}
