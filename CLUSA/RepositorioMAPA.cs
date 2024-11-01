using MongoDB.Driver;
using System.Diagnostics;
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

        public async Task Create(MAPA mapa)
        {
            await Task.Run(() =>
            {
                _MAPA.InsertOne(mapa);
            });
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
                        .Set("NR", mapa.Ref_USA)
                        .Set("SR", mapa.SR)
                        .Set("Importador", mapa.Importador)
                        .Set("Previsao", mapa.Previsao)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("CSIOriginal", mapa.CSIOriginal)
                        .Set("LI", mapa.LI)
                        .Set("LPCO", mapa.LPCO)
                        .Set("DataDeEntrada", mapa.DataDeEntrada)
                        .Set("Parametrizacao", mapa.Parametrizacao)
                        .Set("SEI", mapa.SEI)
                        .Set("DataDeInspeção", mapa.DataDeInspeção)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapa, updateMapa);

                Processo processo = new();
                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.Ref_USA, mapa.Ref_USA);
                var resultIDProcesso = _Processo.Find(filterProcesso).FirstOrDefaultAsync<Processo>().Result?.Id;
                var filterProcessoUpdate = Builders<Processo>.Filter.Eq("Id", resultIDProcesso);
                var updateProcesso = Builders<Processo>.Update
                        .Set("NR", mapa.Ref_USA)
                        .Set("SR", mapa.SR)
                        .Set("Importador", mapa.Importador)
                        .Set("Previsao", mapa.Previsao)
                        .Set("Terminal", mapa.Terminal)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _Processo.UpdateOne(filterProcessoUpdate, updateProcesso);

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.Ref_USA, mapa.Ref_USA);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                var updateAnvisa = Builders<Anvisa>.Update
                        .Set("NR", mapa.Ref_USA)
                        .Set("SR", mapa.SR)
                        .Set("Importador", mapa.Importador)
                        .Set("Previsao", mapa.Previsao)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("LI", mapa.LI)
                        .Set("LPCO", mapa.LPCO)
                        .Set("DataDeEntrada", mapa.DataDeEntrada)
                        .Set("DataDeInspeção", mapa.DataDeInspeção)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);

                Decex decex = new();
                var filterDecex = Builders<Decex>.Filter.Eq(g => g.Ref_USA, mapa.Ref_USA);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexUpdate = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                var updateDecex = Builders<Decex>.Update
                        .Set("NR", mapa.Ref_USA)
                        .Set("SR", mapa.SR)
                        .Set("Importador", mapa.Importador)
                        .Set("Previsao", mapa.Previsao)
                        .Set("Terminal", mapa.Terminal)
                        .Set("Pendencia", mapa.Pendencia)
                        .Set("LI", mapa.LI)
                        .Set("DataDeEntrada", mapa.DataDeEntrada)
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
            if (filtro == "SR")
            {
                filter = Builders<MAPA>.Filter.Eq(g => g.SR, int.Parse(pesquisa));
            }
            if (filtro == "Importador")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Previsao")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Previsao, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Terminal")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Terminal, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Pendencia")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Pendencia, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "CSIOriginal")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.CSIOriginal, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "LI")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.LI, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "LPCO")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.LPCO, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "DataDeEntrada")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.DataDeEntrada, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Parametrizacao")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Parametrizacao, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "SEI")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.SEI, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "DataDeInspeção")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.DataDeInspeção, new Regex(pesquisa, RegexOptions.IgnoreCase));
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
