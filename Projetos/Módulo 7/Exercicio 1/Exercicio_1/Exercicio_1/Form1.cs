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

namespace Exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("../../TextFile1.txt"))
            {
                Stream entrada = File.Open("../../TextFile1.txt",FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                richTextBox1.Text = leitor.ReadToEnd();
                entrada.Close();
                leitor.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open(("../../TextFile1.txt"), FileMode.Append);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.WriteLine(richTextBox1.Text);
            escritor.Close();
            saida.Close();
        }
    }
}
