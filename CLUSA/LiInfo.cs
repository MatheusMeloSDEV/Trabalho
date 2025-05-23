using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class LiInfo
    {
        public string Numero { get; set; } = string.Empty;
        public List<string> OrgaosAnuentes { get; set; } = new List<string>();
        public string LPCO { get; set; } = string.Empty;
        public DateTime? DataRegistroLPCO { get; set; } = (DateTime?)null;
        public bool CheckDataRegistroLPCO { get; set; } = false;
        public DateTime? DataDeferimentoLPCO { get; set; } = (DateTime?)null;
        public bool CheckDataDeferimentoLPCO { get; set; } = false;
        public string ParametrizacaoLPCO { get; set; } = string.Empty;

        public LiInfo(string numero, List<string> orgaos, string lpco, DateTime? dataRegistro, bool checkDataRegistro, DateTime? dataDeferimento, bool checkDataDeferimento, string parametrizacao)
        {
            Numero = numero;
            OrgaosAnuentes = orgaos;
            LPCO = lpco;
            DataRegistroLPCO = dataRegistro;
            CheckDataRegistroLPCO = checkDataRegistro;
            DataDeferimentoLPCO = dataDeferimento;
            CheckDataDeferimentoLPCO = checkDataDeferimento;
            ParametrizacaoLPCO = parametrizacao;
        }
        public LiInfo() { }
    }
}
