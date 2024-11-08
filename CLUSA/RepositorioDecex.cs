using MongoDB.Driver;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class RepositorioDecex
    {
        private IMongoCollection<Processo> _Processo;
        private IMongoCollection<Anvisa> _Anvisa;
        private IMongoCollection<Decex> _Decex;
        private IMongoCollection<MAPA> _MAPA;

        public List<Decex> ListaDecex
        {
            get
            {
                var filter = Builders<Decex>.Filter.Empty;
                return _Decex.Find<Decex>(filter).ToList<Decex>();
            }
        }

        public async Task Delete(Decex decex)
        {
            await Task.Run(() =>
            {
                var filter = Builders<Decex>.Filter.Eq("Id", decex.Id);
                _Decex.DeleteOne(filter);
            });
        }

        public async Task Udpate(Decex decex)
        {
            await Task.Run(() =>
            {
                var filterDecex = Builders<Decex>.Filter.Eq("Id", decex.Id);
                var updateDecex = Builders<Decex>.Update
                        .Set("Ref_USA", decex.Ref_USA)
                        .Set("Importador", decex.Importador)
                        .Set("SR", decex.SR)
                        .Set("Exportador", decex.Exportador)
                        .Set("Produto", decex.Produto)
                        .Set("PortoDestino", decex.PortoDestino)
                        .Set("Ordem", decex.Ordem)
                        .Set("FLO", decex.FLO)
                        .Set("FreeTime", decex.FreeTime)
                        .Set("BL", decex.BL)
                        .Set("AgenteDeCarga", decex.AgenteDeCarga)

                        .Set("LI_LPCO", decex.LI_LPCO)
                        .Set("DataRegistroLILPCO", decex.DataRegistroLILPCO)
                        .Set("DataDeferimentoLILPCO", decex.DataDeferimentoLILPCO)
                        .Set("ParametrizacaoLILPCO", decex.ParametrizacaoLILPCO)

                        .Set("DI", decex.DI)
                        .Set("DataRegistroDI", decex.DataRegistroDI)
                        .Set("DataDesembaracoDI", decex.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", decex.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", decex.ParametrizacaoDI)

                        .Set("PossuiEmbarque", decex.PossuiEmbarque)
                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("DataEmbarque", decex.DataEmbarque)
                        .Set("Previsao", decex.Previsao)
                        .Set("RecebOriginais", decex.RecebOriginais)
                        .Set("FormaRecebERecebidos", decex.FormaRecebERecebidos)
                        .Set("Amostra", decex.Amostra)
                        .Set("Desovado", decex.Desovado)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Decex.UpdateOne(filterDecex, updateDecex);

                Processo processo = new();
                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.Ref_USA, decex.Ref_USA);
                var resultIDProcesso = _Processo.Find(filterProcesso).FirstOrDefaultAsync<Processo>().Result?.Id;
                var filterProcessoUpdate = Builders<Processo>.Filter.Eq("Id", resultIDProcesso);
                var updateProcesso = Builders<Processo>.Update
                        .Set("Ref_USA", decex.Ref_USA)
                        .Set("Importador", decex.Importador)
                        .Set("SR", decex.SR)
                        .Set("Exportador", decex.Exportador)
                        .Set("Produto", decex.Produto)
                        .Set("PortoDestino", decex.PortoDestino)
                        .Set("Ordem", decex.Ordem)
                        .Set("FLO", decex.FLO)
                        .Set("FreeTime", decex.FreeTime)
                        .Set("BL", decex.BL)
                        .Set("AgenteDeCarga", decex.AgenteDeCarga)

                        .Set("LI_LPCO", decex.LI_LPCO)
                        .Set("DataRegistroLILPCO", decex.DataRegistroLILPCO)
                        .Set("DataDeferimentoLILPCO", decex.DataDeferimentoLILPCO)
                        .Set("ParametrizacaoLILPCO", decex.ParametrizacaoLILPCO)

                        .Set("DI", decex.DI)
                        .Set("DataRegistroDI", decex.DataRegistroDI)
                        .Set("DataDesembaracoDI", decex.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", decex.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", decex.ParametrizacaoDI)

                        .Set("PossuiEmbarque", decex.PossuiEmbarque)
                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("DataEmbarque", decex.DataEmbarque)
                        .Set("Previsao", decex.Previsao)
                        .Set("RecebOriginais", decex.RecebOriginais)
                        .Set("FormaRecebERecebidos", decex.FormaRecebERecebidos)
                        .Set("Amostra", decex.Amostra)
                        .Set("Desovado", decex.Desovado)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Processo.UpdateOne(filterProcessoUpdate, updateProcesso);

                MAPA mapa = new();
                var filterMapa = Builders<MAPA>.Filter.Eq("NR", mapa.Ref_USA);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaUpdate = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                var updateMapa = Builders<MAPA>.Update
                        .Set("Ref_USA", decex.Ref_USA)
                        .Set("Importador", decex.Importador)
                        .Set("SR", decex.SR)
                        .Set("Exportador", decex.Exportador)
                        .Set("Produto", decex.Produto)
                        .Set("PortoDestino", decex.PortoDestino)
                        .Set("Ordem", decex.Ordem)
                        .Set("FLO", decex.FLO)
                        .Set("FreeTime", decex.FreeTime)
                        .Set("BL", decex.BL)
                        .Set("AgenteDeCarga", decex.AgenteDeCarga)

                        .Set("LI_LPCO", decex.LI_LPCO)
                        .Set("DataRegistroLILPCO", decex.DataRegistroLILPCO)
                        .Set("DataDeferimentoLILPCO", decex.DataDeferimentoLILPCO)
                        .Set("ParametrizacaoLILPCO", decex.ParametrizacaoLILPCO)

                        .Set("DI", decex.DI)
                        .Set("DataRegistroDI", decex.DataRegistroDI)
                        .Set("DataDesembaracoDI", decex.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", decex.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", decex.ParametrizacaoDI)

                        .Set("PossuiEmbarque", decex.PossuiEmbarque)
                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("DataEmbarque", decex.DataEmbarque)
                        .Set("Previsao", decex.Previsao)
                        .Set("RecebOriginais", decex.RecebOriginais)
                        .Set("FormaRecebERecebidos", decex.FormaRecebERecebidos)
                        .Set("Amostra", decex.Amostra)
                        .Set("Desovado", decex.Desovado)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapaUpdate, updateMapa);

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.Ref_USA, decex.Ref_USA);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                var updateAnvisa = Builders<Anvisa>.Update
                        .Set("Ref_USA", decex.Ref_USA)
                        .Set("Importador", decex.Importador)
                        .Set("SR", decex.SR)
                        .Set("Exportador", decex.Exportador)
                        .Set("Produto", decex.Produto)
                        .Set("PortoDestino", decex.PortoDestino)
                        .Set("Ordem", decex.Ordem)
                        .Set("FLO", decex.FLO)
                        .Set("FreeTime", decex.FreeTime)
                        .Set("BL", decex.BL)
                        .Set("AgenteDeCarga", decex.AgenteDeCarga)

                        .Set("LI_LPCO", decex.LI_LPCO)
                        .Set("DataRegistroLILPCO", decex.DataRegistroLILPCO)
                        .Set("DataDeferimentoLILPCO", decex.DataDeferimentoLILPCO)
                        .Set("ParametrizacaoLILPCO", decex.ParametrizacaoLILPCO)

                        .Set("DI", decex.DI)
                        .Set("DataRegistroDI", decex.DataRegistroDI)
                        .Set("DataDesembaracoDI", decex.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", decex.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", decex.ParametrizacaoDI)

                        .Set("PossuiEmbarque", decex.PossuiEmbarque)
                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("DataEmbarque", decex.DataEmbarque)
                        .Set("Previsao", decex.Previsao)
                        .Set("RecebOriginais", decex.RecebOriginais)
                        .Set("FormaRecebERecebidos", decex.FormaRecebERecebidos)
                        .Set("Amostra", decex.Amostra)
                        .Set("Desovado", decex.Desovado)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);
            });
        }
        public List<Decex> FindAll()
        {
            var filter = Builders<Decex>.Filter.Empty;
            return _Decex.Find<Decex>(filter).ToList<Decex>();
        }
        public List<Decex> Find(string filtro, string pesquisa)
        {
            var filter = Builders<Decex>.Filter.Empty;
            if (filtro == "NR")
            {
                filter = Builders<Decex>.Filter.Regex(g => g.Ref_USA, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Importador")
            {
                filter = Builders<Decex>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Previsao")
            {
                filter = Builders<Decex>.Filter.Regex(g => g.Previsao, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Pendencia")
            {
                filter = Builders<Decex>.Filter.Regex(g => g.Pendencia, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "StatusDoProcesso")
            {
                filter = Builders<Decex>.Filter.Regex(g => g.StatusDoProcesso, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            return _Decex.Find(filter).ToList();
        }

        public RepositorioDecex()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
        }
    }
}
