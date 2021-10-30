using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcao.solo.CalculosCorrecoes
{
    internal class CalculosPadrões
    {
        private double teorFosforo;
        private double fontFosforo;
        private double effFosforo;

        private CalculosPadrões(double fontTeor, double fontFont, double fontEff)
        {
            this.teorFosforo = fontTeor;
            this.fontFosforo = fontFont;
            this.effFosforo = fontEff;
        }

        private string getQtdToApply()
        {

            return "";
        }

    }
}
