using correcao.solo.Backend.InformaçõesBase;
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
            IServiceFront front = new IServiceFront();
            ObjetoInfo objInfo = new ObjetoInfo();

            objInfo.produtor = produtor.Text;
            objInfo.municipio = municipio.Text;
            objInfo.talhao = int.Parse(talhao.Text);
            objInfo.texturaSolo = int.Parse(texturasolo.Text);
            objInfo.responsavelTecnico = responsaveltecnico.Text;
            objInfo.data = data.Value;
            objInfo.lote = lote.Text;
            objInfo.areaTalhao = int.Parse(areaTalhao.Text);
            objInfo.sistemaCultivo = int.Parse(sistemacultivo.Text);
            objInfo.profundidadeAmostraSolos = int.Parse(profundidadeamostrasolo.Text);
            objInfo.areaTotal = int.Parse(areaTotal.Text);
            objInfo.matriculaLote = matriculaLote.Text;

       //     front.gravaInfoIniciais(){ };
        }
    }
}
