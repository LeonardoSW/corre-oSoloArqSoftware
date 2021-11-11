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
    public partial class CorrecaoCalcioMagnésio : Form
    {
        public string calcio { get; set; }
        public string ctc { get; set; }
        public string texturaSolo { get; set; }

        public CorrecaoCalcioMagnésio(string calcio, string ctc, string textSolo)
        {
            this.calcio = calcio;
            this.ctc = ctc;
            this.texturaSolo = texturaSolo;

            InitializeComponent();
        }

        private void CorrecaoCalcioMagnésio_Load(object sender, EventArgs e)
        {
            textSolo.Text = calcio;
            textBox1.Text = ctc;
            textBox2.Text = texturaSolo;
        }

        public void GetParticipacaoAtualCTCCalcio()
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
