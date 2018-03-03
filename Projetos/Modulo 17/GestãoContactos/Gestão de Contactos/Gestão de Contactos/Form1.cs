using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestão_de_Contactos
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter dta;
        private SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data source = .\SQLSERVER; Initial Catalog=Contactos; Trusted_Connection=True;");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar();
           
           
        }

        private void Listar()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dta = new SqlDataAdapter("select * from contacto", conn);
                dta.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (SystemException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }
}
