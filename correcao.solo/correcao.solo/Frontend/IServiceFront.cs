using correcao.solo.Backend.InformaçõesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcao.solo.Frontend
{
    class IServiceFront
    {
        public IServiceFront()
        {   }
        public void gravaInfoIniciais(ObjetoInfo obj)
        {
            IServicosBack.IServicosBack back = new IServicosBack.IServicosBack();
            
            //paramos aqui, trocamos o modo de passagem por parametro, passando direto um objeto ao inves de todas as informações brutas.
            // parte de obtenção de dados iniciais finalizada, agora falta a gravação para posterior carregamento.
            back.carregaInformacoes(obj);
        }
        
    }
}
