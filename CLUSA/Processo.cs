using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class Processo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public bool TDecex { get; set; } = false;
        public bool TAnvisa { get; set; } = false;
        public bool TMapa { get; set; } = false;
        public bool TImetro { get; set; } = false;
        public bool TIbama { get; set; } = false;


        public string Ref_USA { get; set; } = string.Empty;
        public string Importador { get; set; } = string.Empty;
        public string SR { get; set; } = string.Empty;
        public string Exportador { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public string PortoDestino { get; set; } = string.Empty;
        public string Ordem { get; set; } = string.Empty;
        public string FLO { get; set; } = string.Empty;
        public int FreeTime { get; set; } = 0;
        public string BL { get; set; } = string.Empty;
        public string AgenteDeCarga { get; set; } = string.Empty;


        public string LI_LPCO { get; set; } = string.Empty;
        public string DataRegistroLILPCO { get; set; } = string.Empty;
        public string DataDeferimentoLILPCO { get; set; } = string.Empty;
        public string ParametrizacaoLILPCO { get; set; } = string.Empty;


        public string DI { get; set; } = string.Empty;
        public string DataRegistroDI { get; set; } = string.Empty;
        public string DataDesembaracoDI { get; set; } = string.Empty;
        public string DataCarregamentoDI { get; set; } = string.Empty;
        public string ParametrizacaoDI { get; set; } = string.Empty;


        public bool PossuiEmbarque { get; set; } = false;
        public string DataDeAtracacao { get; set; } = string.Empty;
        public string Inspecao { get; set; } = string.Empty;
        public string DataEmbarque { get; set; } = string.Empty;
        public string Previsao { get; set; } = string.Empty;
        public string RecebOriginais { get; set; } = string.Empty;
        public string FormaRecebERecebidos { get; set; } = string.Empty;
        public bool Amostra { get; set; } = false;
        public bool Desovado { get; set; } = false;
        public string Pendencia { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;
    }
}
