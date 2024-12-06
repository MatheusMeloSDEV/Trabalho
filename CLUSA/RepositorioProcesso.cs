using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

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

        public List<string> ObterValoresUnicos(string campo)
        {
            // Filtrar os valores únicos no MongoDB
            var valoresUnicos = _Processo.Distinct<string>(campo, FilterDefinition<Processo>.Empty).ToList();
            return valoresUnicos;
        }

        public List<string> ObterImportadoresUnicos()
        {
            var distinctImportadores = _Processo.Distinct<string>("Importador", new BsonDocument()).ToList();
            return distinctImportadores;
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
            try
            {
                // Busca todos os documentos da coleção
                return _Processo.Find(FilterDefinition<Processo>.Empty).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os processos: {ex.Message}");
                return new List<Processo>();
            }
        }

        public List<Processo> Find(string filtro, string pesquisa)
        {
            try
            {
                // Verificar se o campo existe na classe
                var property = typeof(Processo).GetProperty(filtro);
                if (property == null)
                {
                    throw new KeyNotFoundException($"O campo '{filtro}' não existe no modelo Processo.");
                }

                // Construir o filtro Regex
                var filter = Builders<Processo>.Filter.Regex(filtro, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));

                // Buscar os resultados no MongoDB
                var resultados = _Processo.Find(filter).ToList();

                Console.WriteLine($"Filtro aplicado no MongoDB: {filtro} com pesquisa '{pesquisa}'. Itens encontrados: {resultados.Count}");
                return resultados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados no MongoDB: {ex.Message}");
                return new List<Processo>();
            }
        }

    }
}
