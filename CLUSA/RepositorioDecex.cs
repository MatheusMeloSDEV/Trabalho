using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

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
        public List<string> ObterValoresUnicos(string campo)
        {
            // Filtrar os valores únicos no MongoDB
            var valoresUnicos = _Decex.Distinct<string>(campo, FilterDefinition<Decex>.Empty).ToList();
            return valoresUnicos;
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
                        .Set("Navio", decex.Navio)
                        .Set("Terminal", decex.Terminal)
                        .Set("Produto", decex.Produto)
                        .Set("Origem", decex.Origem)
                        .Set("NCM", decex.NCM)

                        .Set("LI", decex.LI)
                        .Set("LPCO", decex.LPCO)
                        .Set("DataRegistroLPCO", decex.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", decex.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", decex.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("Amostra", decex.Amostra)
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
                        .Set("Navio", decex.Navio)
                        .Set("Terminal", decex.Terminal)
                        .Set("Produto", decex.Produto)
                        .Set("Origem", decex.Origem)
                        .Set("NCM", decex.NCM)

                        .Set("LI", decex.LI)
                        .Set("LPCO", decex.LPCO)
                        .Set("DataRegistroLPCO", decex.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", decex.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", decex.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("Amostra", decex.Amostra)
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
                        .Set("Navio", decex.Navio)
                        .Set("Terminal", decex.Terminal)
                        .Set("Produto", decex.Produto)
                        .Set("Origem", decex.Origem)
                        .Set("NCM", decex.NCM)

                        .Set("LI", decex.LI)
                        .Set("LPCO", decex.LPCO)
                        .Set("DataRegistroLPCO", decex.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", decex.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", decex.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("Amostra", decex.Amostra)
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
                        .Set("Navio", decex.Navio)
                        .Set("Terminal", decex.Terminal)
                        .Set("Produto", decex.Produto)
                        .Set("Origem", decex.Origem)
                        .Set("NCM", decex.NCM)

                        .Set("LI", decex.LI)
                        .Set("LPCO", decex.LPCO)
                        .Set("DataRegistroLPCO", decex.DataRegistroLPCO)
                        .Set("DataDeferimentoLPCO", decex.DataDeferimentoLPCO)
                        .Set("ParametrizacaoLPCO", decex.ParametrizacaoLPCO)

                        .Set("DataDeAtracacao", decex.DataDeAtracacao)
                        .Set("Inspecao", decex.Inspecao)
                        .Set("Amostra", decex.Amostra)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);
            });
        }
        public List<Decex> FindAll()
        {
            try
            {
                // Busca todos os documentos da coleção
                return _Decex.Find(FilterDefinition<Decex>.Empty).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os processos: {ex.Message}");
                return new List<Decex>();
            }
        }
        public List<Decex> Find(string filtro, string pesquisa)
        {
            try
            {
                // Verificar se o campo existe na classe
                var property = typeof(Decex).GetProperty(filtro);
                if (property == null)
                {
                    throw new KeyNotFoundException($"O campo '{filtro}' não existe no modelo Processo.");
                }

                // Construir o filtro Regex
                var filter = Builders<Decex>.Filter.Regex(filtro, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));

                // Buscar os resultados no MongoDB
                var resultados = _Decex.Find(filter).ToList();

                Console.WriteLine($"Filtro aplicado no MongoDB: {filtro} com pesquisa '{pesquisa}'. Itens encontrados: {resultados.Count}");
                return resultados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados no MongoDB: {ex.Message}");
                return new List<Decex>();
            }
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
