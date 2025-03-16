using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class FatRec
    {
        public FatRec(string ref_USA, string importador, string endereco_Importador, string navio, string dataAtracacao, string marca, string quantidade, string mercadoria, string valRecebidos, string dataRecebimento, string dI, string dAtaDI, string impostoImportacao, string iPI, string dÍ_ADICAO, string pIS_PASEP, string cOFINS, string mULTA_LI, string iCMS, string agenciaN, string armazenagemN, string armazenagemP, string freteMaritimoN, string freteMaritimoP, string gRUANVISAN, string gRUANVISAP, string liCancelada_IndeferidaN, string liCancelada_IndeferidaP, string expedienteLiCanceladaN, string expedienteLiCanceladaP, string encaminhamentoAmostrasN, string encaminhamentoAmostrasP, string darfAvisaN, string darfAvisAP, string motoboyN, string motoboyP, string liN, string liP, string expediente, string despesasDesembaracoN, string despesasDesembaracoP, string hD, string cartorio, List<string> nomesDocumentos, List<string> numeroDocumentos, float totalDespesas, float nComissão, float subTotal, float adiantamento, float saldo, string tipoFinalizacao)
        {
            Ref_USA = ref_USA;
            Importador = importador;
            Endereco_Importador = endereco_Importador;
            Navio = navio;
            DataAtracacao = dataAtracacao;
            Marca = marca;
            Quantidade = quantidade;
            Mercadoria = mercadoria;
            ValRecebidos = valRecebidos;
            DataRecebimento = dataRecebimento;
            DI = dI;
            DAtaDI = dAtaDI;
            ImpostoImportacao = impostoImportacao;
            IPI = iPI;
            DÍ_ADICAO = dÍ_ADICAO;
            PIS_PASEP = pIS_PASEP;
            COFINS = cOFINS;
            MULTA_LI = mULTA_LI;
            ICMS = iCMS;
            AgenciaN = agenciaN;
            ArmazenagemN = armazenagemN;
            ArmazenagemP = armazenagemP;
            FreteMaritimoN = freteMaritimoN;
            FreteMaritimoP = freteMaritimoP;
            GRUANVISAN = gRUANVISAN;
            GRUANVISAP = gRUANVISAP;
            LiCancelada_IndeferidaN = liCancelada_IndeferidaN;
            LiCancelada_IndeferidaP = liCancelada_IndeferidaP;
            ExpedienteLiCanceladaN = expedienteLiCanceladaN;
            ExpedienteLiCanceladaP = expedienteLiCanceladaP;
            EncaminhamentoAmostrasN = encaminhamentoAmostrasN;
            EncaminhamentoAmostrasP = encaminhamentoAmostrasP;
            DarfAvisaN = darfAvisaN;
            DarfAvisAP = darfAvisAP;
            MotoboyN = motoboyN;
            MotoboyP = motoboyP;
            LiN = liN;
            LiP = liP;
            Expediente = expediente;
            DespesasDesembaracoN = despesasDesembaracoN;
            DespesasDesembaracoP = despesasDesembaracoP;
            HD = hD;
            Cartorio = cartorio;
            NomesDocumentos = nomesDocumentos;
            NumeroDocumentos = numeroDocumentos;
            TotalDespesas = totalDespesas;
            NComissão = nComissão;
            SubTotal = subTotal;
            Adiantamento = adiantamento;
            Saldo = saldo;
            TipoFinalizacao = tipoFinalizacao;
        }

        public ObjectId Id { get; set; }

        public string Ref_USA { get; set; } = string.Empty;
        public string Importador { get; set; } = string.Empty;
        public string Endereco_Importador { get; set; } = string.Empty;
        public string Navio { get; set; } = string.Empty;
        public string DataAtracacao { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Quantidade { get; set; } = string.Empty;
        public string Mercadoria { get; set; } = string.Empty;
        public string ValRecebidos { get; set; } = string.Empty;
        public string DataRecebimento { get; set; } = string.Empty;
        public string DI { get; set; } = string.Empty;
        public string DAtaDI { get; set; } = string.Empty;
        public string ImpostoImportacao { get; set; } = string.Empty;
        public string IPI { get; set; } = string.Empty;
        public string DÍ_ADICAO { get; set; } = string.Empty;
        public string PIS_PASEP {  get; set; } = string.Empty;
        public string COFINS {  get; set; } = string.Empty;
        public string MULTA_LI {  get; set; } = string.Empty;
        public string ICMS {  get; set; } = string.Empty;
        public string AgenciaN {  get; set; } = string.Empty;
        public string ArmazenagemN {  get; set; } = string.Empty;
        public string ArmazenagemP { get; set; } = string.Empty;
        public string FreteMaritimoN {  get; set; } = string.Empty;
        public string FreteMaritimoP {  get; set; } = string.Empty;
        public string GRUANVISAN {  get; set; } = string.Empty;
        public string GRUANVISAP {  get; set; } = string.Empty;
        public string LiCancelada_IndeferidaN {  get; set; } = string.Empty;
        public string LiCancelada_IndeferidaP { get; set; } = string.Empty;
        public string ExpedienteLiCanceladaN {  get; set; } = string.Empty;
        public string ExpedienteLiCanceladaP { get; set; } = string.Empty;
        public string EncaminhamentoAmostrasN {  get; set; } = string.Empty;
        public string EncaminhamentoAmostrasP { get; set; } = string.Empty;
        public string DarfAvisaN {  get; set; } = string.Empty;
        public string DarfAvisAP { get; private set; } = string.Empty;
        public string MotoboyN {  get; set; } = string.Empty;
        public string MotoboyP { get; private set; } = string.Empty;
        public string LiN {  get; set; } = string.Empty;
        public string LiP { get; set;} = string.Empty;
        public string Expediente {  get; set; } = string.Empty;
        public string DespesasDesembaracoN {  get; set; } = string.Empty;
        public string DespesasDesembaracoP { get; set; } = string.Empty;
        public string HD {  get; set; } = string.Empty;
        public string Cartorio {  get; set; } = string.Empty;
        public List<string> NomesDocumentos {  get; set; }
        public List<string> NumeroDocumentos { get; set; }
        public float TotalDespesas {  get; set; }
        public float NComissão {  get; set; }
        public float SubTotal {  get; set; }
        public float Adiantamento {  get; set; }
        public float Saldo {  get; set; }
        public string TipoFinalizacao {  get; set; } = string.Empty;
    }
}
