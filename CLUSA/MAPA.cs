using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class MAPA
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement ""]
        public string Importador { get; set; }
        public string Navio { get; set; }
        public string Previsao { get; set; }
        public string Terminal { get; set; }
        public string Armazem { get; set; }
        public string Container { get; set; }
        public string Anuete { get; set; }
        public string CE { get; set; }
        public string Descricao { get; set; }
        public bool Capa { get; set; }

        public MAPA(string importador, string navio, string previsao, string terminal, string armazem, string container, string anuete, string cE, string descricao, bool capa)
        {
            Importador = importador;
            Navio = navio;
            Previsao = previsao;
            Terminal = terminal;
            Armazem = armazem;
            Container = container;
            Anuete = anuete;
            CE = cE;
            Descricao = descricao;
            Capa = capa;
        }
    }
}
