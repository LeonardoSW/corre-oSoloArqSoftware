using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace correcao.solo.Backend.InformaçõesBase
{
    class Info
    {
        

        public Info(string prod, string muni, int talhao, int textSol, string respTec, string lote, double areaTal, int sistCult, double profAmostSol, double areaTT, string matrcLote )
        {
            ObjetoInfo obj = new ObjetoInfo();

            obj.produtor = prod;
            obj.municipio = muni;
            obj.talhao = talhao;
            obj.texturaSolo = textSol;
            obj.responsavelTecnico = respTec;
            obj.lote = lote;
            obj.areaTalhao = areaTal;
            obj.sistemaCultivo = sistCult;
            obj.profundidadeAmostraSolos = profAmostSol;
            obj.areaTotal = areaTT;
            obj.matriculaLote = matrcLote;

            saveData(obj);

        }

        private void saveData(ObjetoInfo objetoDeInformacoes)
        {
            string JsonSave = JsonConvert.SerializeObject(objetoDeInformacoes);

            try
            {
                StreamWriter file = File.CreateText("..Backend/informacoesTrabalho.txt");
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, objetoDeInformacoes);
            }
            catch (Exception e)
            {

            }
        }
    }
}
