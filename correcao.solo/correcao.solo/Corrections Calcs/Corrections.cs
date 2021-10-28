using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcao.solo.Corrections_Calcs
{
    internal class Corrections
    {
        private double teorFosforo;
        private double fontFosforo;
        private double effFosforo;

        private Corrections(double fontTeor, double fontFont, double fontEff)
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
