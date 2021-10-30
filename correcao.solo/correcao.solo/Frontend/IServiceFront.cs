using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using correcao.solo.Backend;

namespace correcao.solo.Frontend
{
    class IServiceFront
    {
        public IServiceFront()
        {   }

        public string produtor;
        public string municipio;
        public int talhao;
        public int texturaSolo;
        public string responsavelTecnico;
        public int resultadoAnaliseSolosN;
        public DateTime data;
        public string lote;
        public double areaTalhao;
        public string argiloso;
        public int sistemaCultivo;
        public double profundidadeAmostraSolos;
        public double areaTotal;
        public string matriculaLote;

        public void gravaInfoIniciais()
        {
            IServicosBack.IServicosBack back = new IServicosBack.IServicosBack();

//            back.carregaInformacoes();
        }
        
    }
}
