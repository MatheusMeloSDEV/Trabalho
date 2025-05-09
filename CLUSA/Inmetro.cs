using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUSA
{
    public class Inmetro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        public string Ref_USA { get; set; } = string.Empty;
        public string Importador { get; set; } = string.Empty;
        public string SR { get; set; } = string.Empty;
        public string Exportador { get; set; } = string.Empty;
        public string Navio { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public string Origem { get; set; } = string.Empty;
        public bool TEmbarque { get; set; } = false;
        public DateTime? DataDeAtracacao { get; set; } = (DateTime?)null;
        public bool CheckDataDeAtracacao { get; set; } = false;
        public DateTime? DataEmbarque { get; set; } = (DateTime?)null;
        public bool CheckDataEmbarque { get; set; } = false;
        public DateTime? InspecaoInmetro { get; set; } = (DateTime?)null;
        public bool CheckInspecaoInmetro { get; set; } = false;
        public string NCM { get; set; } = string.Empty;
        public string LI { get; set; } = string.Empty;
        public string LPCO { get; set; } = string.Empty;
        public DateTime? DataRegistroLPCO { get; set; } = (DateTime?)null;
        public bool CheckDataRegistroLPCO { get; set; } = false;
        public DateTime? DataDeferimentoLPCO { get; set; } = (DateTime?)null;
        public bool CheckDataDeferimentoLPCO { get; set; } = false;
        public string ParametrizacaoLPCO { get; set; } = string.Empty;
        public bool Amostra { get; set; } = false;
        public string Pendencia { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;

        public Inmetro() { }
        public Inmetro(Processo processo)
        {
            Ref_USA = processo.Ref_USA;
            Importador = processo.Importador;
            SR = processo.SR;
            Exportador = processo.Exportador;
            Navio = processo.Navio;
            Produto = processo.Produto;
            TEmbarque = processo.PossuiEmbarque;
            DataDeAtracacao = processo.DataDeAtracacao;
            CheckDataDeAtracacao = processo.CheckDataDeAtracacao;
            DataEmbarque = processo.DataEmbarque;
            CheckDataEmbarque = processo.CheckDataEmbarque;
            LI = processo.LI;
            LPCO = processo.LPCO;
            DataRegistroLPCO = processo.DataRegistroLPCO;
            CheckDataRegistroLPCO = processo.CheckDataRegistroLPCO;
            DataDeferimentoLPCO = processo.DataDeferimentoLPCO;
            CheckDataDeferimentoLPCO = processo.CheckDataDeferimentoLPCO;
            ParametrizacaoLPCO = processo.ParametrizacaoLPCO;
            Amostra = processo.Amostra;
            Pendencia = processo.Pendencia;
            StatusDoProcesso = processo.StatusDoProcesso;
        }
    }
}
