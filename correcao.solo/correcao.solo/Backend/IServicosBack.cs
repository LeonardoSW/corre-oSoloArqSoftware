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

        public void carregaInformacoes(ObjetoInfo obj)
        {

            try
            {
            new Info(obj);
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possivel savar informações.");
            }
        }
    }
}
