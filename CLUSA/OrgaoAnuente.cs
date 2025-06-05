namespace CLUSA
{
    /// <summary>
    /// Classe base para todos os órgãos anuentes.
    /// </summary>
    public abstract class OrgaoAnuente
    {
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
        public DateTime? DataDeAtracacao { get; set; } = (DateTime?)null;
        public bool CheckDataDeAtracacao { get; set; } = false;
        public DateTime? DataEmbarque { get; set; } = (DateTime?)null;
        public bool CheckDataEmbarque { get; set; } = false;
        public DateTime? Inspecao { get; set; } = (DateTime?)null;
        public bool CheckInspecao { get; set; } = false;
        public string Pendencia { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;
        public List<LiInfo> Li { get; set; } = new();
        public bool Amostra { get; set; } = false;
    }
}