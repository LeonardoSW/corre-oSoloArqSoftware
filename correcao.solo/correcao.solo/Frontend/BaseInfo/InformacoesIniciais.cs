using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace correcao.solo.Frontend
{
    public partial class InformacoesIniciais : Form
    {
        public InformacoesIniciais()
        {
            InitializeComponent();
        }

        private void InformacoesIniciais_Load(object sender, EventArgs e)
        {
            RAN.Text = "1";
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
