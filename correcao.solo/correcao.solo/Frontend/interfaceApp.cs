using correcao.solo.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace correcao.solo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InformacoesClienteSolo telaClienteSolo = new InformacoesClienteSolo();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarInformacoes_Click(object sender, EventArgs e)
        {
            telaClienteSolo.ShowDialog();
            textBox1.Text = telaClienteSolo.texturaSolo == 1 ? "9,0" : telaClienteSolo.texturaSolo == 2 ? "12,0" : "";
            textBox2.Text = telaClienteSolo.texturaSolo == 1 ? "0,35" : telaClienteSolo.texturaSolo == 2 ? "0,25" : "";
            textBox3.Text = telaClienteSolo.texturaSolo == 1 ? "6,0" : telaClienteSolo.texturaSolo == 2 ? "4,0" : "";
            textBox4.Text = telaClienteSolo.texturaSolo == 1 ? "1,5" : telaClienteSolo.texturaSolo == 2 ? "1,0" : "";
            textBox27.Text = telaClienteSolo.texturaSolo == 1 ? "9,0" : telaClienteSolo.texturaSolo == 2 ? "6,0" : "";
            textBox6.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
