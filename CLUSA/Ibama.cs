using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUSA
{    public class Ibama
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public string Ref_USA { get; set; } = string.Empty;
        public string Importador { get; set; } = string.Empty;
        public string SR { get; set; } = string.Empty;
        public string Exportador { get; set; } = string.Empty;
        public string Navio { get; set; } = string.Empty;
        public string Terminal { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public string Origem { get; set; } = string.Empty;
        public bool TEmbarque { get; set; } = false;
        public string DataDeAtracacao { get; set; } = string.Empty;
        public string DataEmbarque { get; set; } = string.Empty;
        public string Inspecao { get; set; } = string.Empty;
        public string NCM { get; set; } = string.Empty;
        public string LI { get; set; } = string.Empty;
        public string LPCO { get; set; } = string.Empty;
        public string DataRegistroLPCO { get; set; } = string.Empty;
        public string DataDeferimentoLPCO { get; set; } = string.Empty;
        public string ParametrizacaoLPCO { get; set; } = string.Empty;
        public bool Amostra { get; set; } = false;
        public string Pendencia { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;

        public Ibama() { }
        public Ibama(Processo processo)
        {
            Ref_USA = processo.Ref_USA;
            Importador = processo.Importador;
            SR = processo.SR;
            Exportador = processo.Exportador;
            Navio = processo.Navio;
            Terminal = processo.PortoDestino;
            Produto = processo.Produto;
            TEmbarque = processo.PossuiEmbarque;
            DataDeAtracacao = processo.DataDeAtracacao;
            DataEmbarque = processo.DataEmbarque;
            Inspecao = processo.Inspecao;
            LI = processo.LI;
            LPCO = processo.LPCO;
            DataRegistroLPCO = processo.DataRegistroLPCO;
            DataDeferimentoLPCO = processo.DataDeferimentoLPCO;
            ParametrizacaoLPCO = processo.ParametrizacaoLPCO;
            Amostra = processo.Amostra;
            Pendencia = processo.Pendencia;
            StatusDoProcesso = processo.StatusDoProcesso;
        }
    }
}
