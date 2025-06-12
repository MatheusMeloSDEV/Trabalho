using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUSA
{
    /// <summary>
    /// Classe base para todos os órgãos anuentes.
    /// </summary>
    public abstract class OrgaoAnuente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        /// <summary>
        /// Identificador único do órgão (ex: "MAPA", "ANVISA", "IBAMA", etc).
        /// </summary>
        public string Ref_USA { get; set; } = string.Empty;
        public string Importador { get; set; } = string.Empty;
        public string SR { get; set; } = string.Empty;
        public string Exportador { get; set; } = string.Empty;
        public string Terminal { get; set; } = string.Empty;
        public string Veiculo { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public string Origem { get; set; } = string.Empty;
        public DateTime? DataDeAtracacao { get; set; } = null;
        public bool CheckDataDeAtracacao { get; set; } = false;
        public DateTime? DataEmbarque { get; set; } = null;
        public bool CheckDataEmbarque { get; set; } = false;
        public DateTime? Inspecao { get; set; } = null;
        public bool CheckInspecao { get; set; } = false;
        public string Pendencia { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;
        public List<LiInfo> LI { get; set; } = new();
        public bool Amostra { get; set; } = false;
    }

    public static class OrgaoAnuenteExtensions
    {
        public static (DateTime? dataInspecao, bool checkInspecao) ObterInspecaoEspecifica(this OrgaoAnuente orgao)
        {
            switch (orgao)
            {
                case MAPA mapa:
                    return (mapa.InspecaoMapa, mapa.CheckInspecaoMapa);
                case DECEX decex:
                    return (decex.InspecaoDecex, decex.CheckInspecaoDecex);
                case ANVISA anvisa:
                    return (anvisa.InspecaoAnvisa, anvisa.CheckInspecaoAnvisa);
                case IBAMA ibama:
                    return (ibama.InspecaoIbama, ibama.CheckInspecaoIbama);
                case INMETRO inmetro:
                    return (inmetro.InspecaoInmetro, inmetro.CheckInspecaoInmetro);
                default:
                    return (orgao.Inspecao, orgao.CheckInspecao);
            }
        }
    }
}