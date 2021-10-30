using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using correcao.solo.Backend.InformaçõesBase;

namespace correcao.solo.IServicosBack
{
    class IServicosBack
    {

        public IServicosBack() { }

        public void carregaInformacoes(string prod, string muni, int talhao, int textSol, string respTec, string lote, double areaTal, int sistCult, double profAmostSol, double areaTT, string matrcLote)
        {
            try
            {
                new Info(prod, muni, talhao, textSol, respTec, lote, areaTal, sistCult, profAmostSol, areaTT, matrcLote);
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possivel savar informações.");
            }
        }
    }
}
