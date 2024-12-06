using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioMAPA
    {
        private IMongoCollection<Processo> _Processo;
        private IMongoCollection<Anvisa> _Anvisa;
        private IMongoCollection<Decex> _Decex;
        private IMongoCollection<MAPA> _MAPA;

        public List<MAPA> ListaMapa
        {
            get
            {
                var filter = Builders<MAPA>.Filter.Empty;
                return _MAPA.Find<MAPA>(filter).ToList<MAPA>();
            }
        }
        public List<string> ObterValoresUnicos(string campo)
        {
            // Filtrar os valores únicos no MongoDB
            var valoresUnicos = _MAPA.Distinct<string>(campo, FilterDefinition<MAPA>.Empty).ToList();
            return valoresUnicos;
        }
        public async Task Delete(MAPA mapa)
        {
            await Task.Run(() =>
            {
                var filter = Builders<MAPA>.Filter.Eq("Id", mapa.Id);
                _MAPA.DeleteOne(filter);
            });
        }

        public async Task Update(MAPA mapa)
        {
            await Task.Run(() =>
            {
                var filterMapa = Builders<MAPA>.Filter.Eq("Id", mapa.Id);
                var updateMapa = Builders<MAPA>.Update
                         .Set("Ref_USA", mapa.Ref_USA)
                        .Set("Importador", mapa.Importador)
                        .Set("SR", mapa.SR)
                        .Set("Exportador", mapa.Exportador)
                        .Set("Navio", mapa.Navio)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Produto", mapa.Produto)
                        .Set("Origem", mapa.Origem)
                        .Set("NCM", mapa.NCM)

                        .Set("LI", mapa.LI)
                        .Set("LPCO", mapa.LPCO)
                        .Set("DataRegistroLPCO", mapa.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", mapa.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", mapa.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", mapa.DataDeAtracacao)
                        .Set("Inspecao", mapa.Inspecao)
                        .Set("Amostra", mapa.Amostra)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapa, updateMapa);

                Processo processo = new();
                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.Ref_USA, mapa.Ref_USA);
                var resultIDProcesso = _Processo.Find(filterProcesso).FirstOrDefaultAsync<Processo>().Result?.Id;
                var filterProcessoUpdate = Builders<Processo>.Filter.Eq("Id", resultIDProcesso);
                var updateProcesso = Builders<Processo>.Update
                         .Set("Ref_USA", mapa.Ref_USA)
                        .Set("Importador", mapa.Importador)
                        .Set("SR", mapa.SR)
                        .Set("Exportador", mapa.Exportador)
                        .Set("Navio", mapa.Navio)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Produto", mapa.Produto)
                        .Set("Origem", mapa.Origem)
                        .Set("NCM", mapa.NCM)

                        .Set("LI", mapa.LI)
                        .Set("LPCO", mapa.LPCO)
                        .Set("DataRegistroLPCO", mapa.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", mapa.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", mapa.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", mapa.DataDeAtracacao)
                        .Set("Inspecao", mapa.Inspecao)
                        .Set("Amostra", mapa.Amostra)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _Processo.UpdateOne(filterProcessoUpdate, updateProcesso);

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.Ref_USA, mapa.Ref_USA);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                var updateAnvisa = Builders<Anvisa>.Update
                         .Set("Ref_USA", mapa.Ref_USA)
                        .Set("Importador", mapa.Importador)
                        .Set("SR", mapa.SR)
                        .Set("Exportador", mapa.Exportador)
                        .Set("Navio", mapa.Navio)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Produto", mapa.Produto)
                        .Set("Origem", mapa.Origem)
                        .Set("NCM", mapa.NCM)

                        .Set("LI", mapa.LI)
                        .Set("LPCO", mapa.LPCO)
                        .Set("DataRegistroLPCO", mapa.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", mapa.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", mapa.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", mapa.DataDeAtracacao)
                        .Set("Inspecao", mapa.Inspecao)
                        .Set("Amostra", mapa.Amostra)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);

                Decex decex = new();
                var filterDecex = Builders<Decex>.Filter.Eq(g => g.Ref_USA, mapa.Ref_USA);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexUpdate = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                var updateDecex = Builders<Decex>.Update
                         .Set("Ref_USA", mapa.Ref_USA)
                        .Set("Importador", mapa.Importador)
                        .Set("SR", mapa.SR)
                        .Set("Exportador", mapa.Exportador)
                        .Set("Navio", mapa.Navio)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Produto", mapa.Produto)
                        .Set("Origem", mapa.Origem)
                        .Set("NCM", mapa.NCM)

                        .Set("LI", mapa.LI)
                        .Set("LPCO", mapa.LPCO)
                        .Set("DataRegistroLPCO", mapa.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", mapa.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", mapa.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", mapa.DataDeAtracacao)
                        .Set("Inspecao", mapa.Inspecao)
                        .Set("Amostra", mapa.Amostra)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _Decex.UpdateOne(filterDecexUpdate, updateDecex);
            });
        }

        public List<MAPA> Find(string filtro, string pesquisa)
        {
            var filter = Builders<MAPA>.Filter.Empty;
            if (filtro == "NR")
            {
                filter = Builders<MAPA>.Filter.Eq(g => g.Ref_USA, pesquisa);
            }
            if (filtro == "Importador")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "StatusDoProcesso")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.StatusDoProcesso, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            return _MAPA.Find(filter).ToList();
        }

        public List<MAPA> FindAll()
        {
            var filter = Builders<MAPA>.Filter.Empty;
            return _MAPA.Find<MAPA>(filter).ToList<MAPA>();
        }

        public RepositorioMAPA()
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
