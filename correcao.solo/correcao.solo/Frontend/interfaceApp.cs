using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using correcao.solo.Frontend;

namespace correcao.solo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CarregarInformacoes_Click(object sender, EventArgs e)
        {
            InformacoesIniciais telaCarregaInfo = new InformacoesIniciais();
            telaCarregaInfo.ShowDialog();
        }
    }
}
