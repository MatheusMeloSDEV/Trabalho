using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLUSA
{
    public class RepositorioProcesso
    {
        private IMongoCollection<Processo> _Processo;
        private IMongoCollection<Anvisa> _Anvisa;
        private IMongoCollection<Decex> _Decex;
        private IMongoCollection<MAPA> _MAPA;

        public RepositorioProcesso()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Processo> ListaProcesso
        {
            get
            {
                var filter = Builders<Processo>.Filter.Empty;
                return _Processo.Find<Processo>(filter).ToList<Processo>();
            }
        }

        public async Task Create(Processo processo)
        {
            await Task.Run(() =>
            {
                if (processo.TAnvisa == true)
                {
                    Anvisa anvisa = new()
                    {
                        Ref_USA = processo.Ref_USA,
                        Importador = processo.Importador,
                        SR = processo.SR,
                        Exportador = processo.Exportador,
                        Produto = processo.Produto,

                        LI = processo.LI,
                        LPCO = processo.LPCO,
                        DataRegistroLPCO = processo.DataRegistroLPCO,
                        DataDeferimentoLPCO = processo.DataDeferimentoLPCO,
                        ParametrizacaoLPCO = processo.ParametrizacaoLPCO,

                        DataDeAtracacao = processo.DataDeAtracacao,
                        Inspecao = processo.Inspecao,
                        Amostra = processo.Amostra,
                        Pendencia = processo.Pendencia,
                        StatusDoProcesso = processo.StatusDoProcesso
                    };

                    _Anvisa.InsertOne(anvisa);
                }

                if (processo.TDecex == true)
                {
                    Decex decex = new()
                    {
                        Ref_USA = processo.Ref_USA,
                        Importador = processo.Importador,
                        SR = processo.SR,
                        Exportador = processo.Exportador,
                        Produto = processo.Produto,

                        LI = processo.LI,
                        LPCO = processo.LPCO,
                        DataRegistroLPCO = processo.DataRegistroLPCO,
                        DataDeferimentoLPCO = processo.DataDeferimentoLPCO,
                        ParametrizacaoLPCO = processo.ParametrizacaoLPCO,

                        DataDeAtracacao = processo.DataDeAtracacao,
                        Inspecao = processo.Inspecao,
                        Amostra = processo.Amostra,
                        Pendencia = processo.Pendencia,
                        StatusDoProcesso = processo.StatusDoProcesso
                    };

                    _Decex.InsertOne(decex);
                }

                if (processo.TMapa == true)
                {
                    MAPA mapa = new()
                    {
                        Ref_USA = processo.Ref_USA,
                        Importador = processo.Importador,
                        SR = processo.SR,
                        Exportador = processo.Exportador,
                        Produto = processo.Produto,

                        LI = processo.LI,
                        LPCO = processo.LPCO,
                        DataRegistroLPCO = processo.DataRegistroLPCO,
                        DataDeferimentoLPCO = processo.DataDeferimentoLPCO,
                        ParametrizacaoLPCO = processo.ParametrizacaoLPCO,

                        DataDeAtracacao = processo.DataDeAtracacao,
                        Inspecao = processo.Inspecao,
                        Amostra = processo.Amostra,
                        Pendencia = processo.Pendencia,
                        StatusDoProcesso = processo.StatusDoProcesso
                    };

                    _MAPA.InsertOne(mapa);
                }

                _Processo.InsertOne(processo);
            });
        }

        public async Task Delete(Processo processo)
        {
            await Task.Run(() =>
            {
                var filter = Builders<Processo>.Filter.Eq("Id", processo.Id);
                _Processo.DeleteOne(filter);

                var filterMapa = Builders<MAPA>.Filter.Eq(g => g.Ref_USA, processo.Ref_USA);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaR = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                _MAPA.DeleteOne(filterMapaR);

                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.Ref_USA, processo.Ref_USA);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaR = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                _Anvisa.DeleteOne(filterAnvisaR);

                var filterDecex = Builders<Decex>.Filter.Eq(g => g.Ref_USA, processo.Ref_USA);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexR = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                _Decex.DeleteOne(filterDecexR);
            });
        }

        public async Task Update(Processo processo)
        {
            await Task.Run(() =>
            {
                var filterProcesso = Builders<Processo>.Filter.Eq("Id", processo.Id);
                var updateProcesso = Builders<Processo>.Update
                        .Set("Ref_USA", processo.Ref_USA)
                        .Set("Importador", processo.Importador)
                        .Set("SR", processo.SR)
                        .Set("Exportador", processo.Exportador)
                        .Set("Produto", processo.Produto)
                        .Set("Navio", processo.Navio)
                        .Set("PortoDestino", processo.PortoDestino)
                        .Set("Ordem", processo.Ordem)
                        .Set("FLO", processo.FLO)
                        .Set("FreeTime", processo.FreeTime)
                        .Set("BL", processo.BL)
                        .Set("AgenteDeCarga", processo.AgenteDeCarga)

                        .Set("LPCO", processo.LPCO)
                        .Set("DataRegistroLPCO", processo.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", processo.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", processo.ParametrizacaoLPCO)

                        .Set("DI", processo.DI)
                        .Set("DataRegistroDI", processo.DataRegistroDI)
                        .Set("DataDesembaracoDI", processo.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", processo.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", processo.ParametrizacaoDI)

                        .Set("PossuiEmbarque", processo.PossuiEmbarque)
                        .Set("DataDeAtracacao", processo.DataDeAtracacao)
                        .Set("Inspecao", processo.Inspecao)
                        .Set("DataEmbarque", processo.DataEmbarque)
                        .Set("DataRecebOriginais", processo.DataRecebOriginais)
                        .Set("FormaRecOriginais", processo.FormaRecOriginais)
                        .Set("DocRecebidos", processo.DocRecebidos)
                        .Set("Amostra", processo.Amostra)
                        .Set("Desovado", processo.Desovado)
                        .Set("Pendencia", processo.Pendencia)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Processo.UpdateOne(filterProcesso, updateProcesso);

                MAPA mapa = new();
                var filterMapa = Builders<MAPA>.Filter.Eq(g => g.Ref_USA, processo.Ref_USA);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaUpdate = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                var updateMapa = Builders<MAPA>.Update
                        .Set("Ref_USA", processo.Ref_USA)
                        .Set("Importador", processo.Importador)
                        .Set("SR", processo.SR)
                        .Set("Exportador", processo.Exportador)
                        .Set("Produto", processo.Produto)
                        .Set("Navio", processo.Navio)
                        .Set("PortoDestino", processo.PortoDestino)
                        .Set("Ordem", processo.Ordem)
                        .Set("FLO", processo.FLO)
                        .Set("FreeTime", processo.FreeTime)
                        .Set("BL", processo.BL)
                        .Set("AgenteDeCarga", processo.AgenteDeCarga)

                        .Set("LPCO", processo.LPCO)
                        .Set("DataRegistroLPCO", processo.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", processo.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", processo.ParametrizacaoLPCO)

                        .Set("DI", processo.DI)
                        .Set("DataRegistroDI", processo.DataRegistroDI)
                        .Set("DataDesembaracoDI", processo.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", processo.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", processo.ParametrizacaoDI)

                        .Set("PossuiEmbarque", processo.PossuiEmbarque)
                        .Set("DataDeAtracacao", processo.DataDeAtracacao)
                        .Set("Inspecao", processo.Inspecao)
                        .Set("DataEmbarque", processo.DataEmbarque)
                        .Set("DataRecebOriginais", processo.DataRecebOriginais)
                        .Set("FormaRecOriginais", processo.FormaRecOriginais)
                        .Set("DocRecebidos", processo.DocRecebidos)
                        .Set("Amostra", processo.Amostra)
                        .Set("Desovado", processo.Desovado)
                        .Set("Pendencia", processo.Pendencia)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapaUpdate, updateMapa);

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.Ref_USA, processo.Ref_USA);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                var updateAnvisa = Builders<Anvisa>.Update
                         .Set("Ref_USA", processo.Ref_USA)
                        .Set("Importador", processo.Importador)
                        .Set("SR", processo.SR)
                        .Set("Exportador", processo.Exportador)
                        .Set("Produto", processo.Produto)
                        .Set("Navio", processo.Navio)
                        .Set("PortoDestino", processo.PortoDestino)
                        .Set("Ordem", processo.Ordem)
                        .Set("FLO", processo.FLO)
                        .Set("FreeTime", processo.FreeTime)
                        .Set("BL", processo.BL)
                        .Set("AgenteDeCarga", processo.AgenteDeCarga)

                        .Set("LPCO", processo.LPCO)
                        .Set("DataRegistroLPCO", processo.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", processo.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", processo.ParametrizacaoLPCO)

                        .Set("DI", processo.DI)
                        .Set("DataRegistroDI", processo.DataRegistroDI)
                        .Set("DataDesembaracoDI", processo.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", processo.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", processo.ParametrizacaoDI)

                        .Set("PossuiEmbarque", processo.PossuiEmbarque)
                        .Set("DataDeAtracacao", processo.DataDeAtracacao)
                        .Set("Inspecao", processo.Inspecao)
                        .Set("DataEmbarque", processo.DataEmbarque)
                        .Set("DataRecebOriginais", processo.DataRecebOriginais)
                        .Set("FormaRecOriginais", processo.FormaRecOriginais)
                        .Set("DocRecebidos", processo.DocRecebidos)
                        .Set("Amostra", processo.Amostra)
                        .Set("Desovado", processo.Desovado)
                        .Set("Pendencia", processo.Pendencia)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);

                Decex decex = new();
                var filterDecex = Builders<Decex>.Filter.Eq(g => g.Ref_USA, processo.Ref_USA);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexUpdate = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                var updateDecex = Builders<Decex>.Update
                        .Set("Ref_USA", processo.Ref_USA)
                        .Set("Importador", processo.Importador)
                        .Set("SR", processo.SR)
                        .Set("Exportador", processo.Exportador)
                        .Set("Produto", processo.Produto)
                        .Set("Navio", processo.Navio)
                        .Set("PortoDestino", processo.PortoDestino)
                        .Set("Ordem", processo.Ordem)
                        .Set("FLO", processo.FLO)
                        .Set("FreeTime", processo.FreeTime)
                        .Set("BL", processo.BL)
                        .Set("AgenteDeCarga", processo.AgenteDeCarga)

                        .Set("LPCO", processo.LPCO)
                        .Set("DataRegistroLPCO", processo.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", processo.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", processo.ParametrizacaoLPCO)

                        .Set("DI", processo.DI)
                        .Set("DataRegistroDI", processo.DataRegistroDI)
                        .Set("DataDesembaracoDI", processo.DataDesembaracoDI)
                        .Set("DataCarregamentoDI", processo.DataCarregamentoDI)
                        .Set("ParametrizacaoDI", processo.ParametrizacaoDI)

                        .Set("PossuiEmbarque", processo.PossuiEmbarque)
                        .Set("DataDeAtracacao", processo.DataDeAtracacao)
                        .Set("Inspecao", processo.Inspecao)
                        .Set("DataEmbarque", processo.DataEmbarque)
                        .Set("DataRecebOriginais", processo.DataRecebOriginais)
                        .Set("FormaRecOriginais", processo.FormaRecOriginais)
                        .Set("DocRecebidos", processo.DocRecebidos)
                        .Set("Amostra", processo.Amostra)
                        .Set("Desovado", processo.Desovado)
                        .Set("Pendencia", processo.Pendencia)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Decex.UpdateOne(filterDecexUpdate, updateDecex);
            });
        }
        public List<Processo> FindAll()
        {
            var filter = Builders<Processo>.Filter.Empty;
            return _Processo.Find<Processo>(filter).ToList<Processo>();
        }
        public List<Processo> Find(string filtro, string pesquisa)
        {
            var filter = Builders<Processo>.Filter.Empty;
            //if (filtro == "NR")
            //{
            //    filter = Builders<Processo>.Filter.Eq(g => g.NR, int.Parse(pesquisa));
            //}
            //if (filtro == "SR")
            //{
            //    filter = Builders<Processo>.Filter.Eq(g => g.SR, int.Parse(pesquisa));
            //}
            //if (filtro == "Importador")
            //{
            //    filter = Builders<Processo>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
            //}
            //if (filtro == "Previsao")
            //{
            //    filter = Builders<Processo>.Filter.Regex(g => g.Previsao, new Regex(pesquisa, RegexOptions.IgnoreCase));
            //}
            //if (filtro == "Terminal")
            //{
            //    filter = Builders<Processo>.Filter.Regex(g => g.Terminal, new Regex(pesquisa, RegexOptions.IgnoreCase));
            //}
            if (filtro == "StatusDoProcesso")
            {
                filter = Builders<Processo>.Filter.Regex(g => g.StatusDoProcesso, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            return _Processo.Find(filter).ToList();
        }
    }
}
