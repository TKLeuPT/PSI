using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Mod_7
{
    public partial class Registo_Vendas : Form
    {
        public Registo_Vendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new[] { dateTimePicker1.Value.ToString(),comboBox1.Text,numericUpDown1.Value.ToString() });
            listView1.Items.Add(item);
            

            try
            {
                
                    Venda novo = new Venda(comboBox1.Text,int.Parse(numericUpDown1.Value.ToString()),dateTimePicker1.Value);

                    Vendas.AddVenda(novo);
               
                MessageBox.Show("Registo Guardado com Sucesso!");
                Vendas.GuardarFicheiro();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        private void Registo_Vendas_Load(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines("pizzas.txt");
            foreach (var linha in linhas)
            {
                string[] tokens = linha.Split(',');
                if (tokens.Length >= 2)
                    comboBox1.Items.Add(tokens[0]);
            }
        }
    }
}
