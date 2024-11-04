using MongoDB.Driver;
using System.Text.RegularExpressions;


namespace CLUSA
{
    public class RepositorioAnvisa
    {
        private IMongoCollection<Processo> _Processo;
        private IMongoCollection<Anvisa> _Anvisa;
        private IMongoCollection<Decex> _Decex;
        private IMongoCollection<MAPA> _MAPA;
        public RepositorioAnvisa()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
        }

        public List<Anvisa> ListaAnvisa
        {
            get
            {
                var filter = Builders<Anvisa>.Filter.Empty;
                return _Anvisa.Find<Anvisa>(filter).ToList<Anvisa>();
            }
        }

        public async Task Create(Anvisa anvisa)
        {
            await Task.Run(() =>
            {
                _Anvisa.InsertOne(anvisa);
            });
        }

        public async Task Delete(Anvisa anvisa)
        {
            await Task.Run(() =>
            {
                var filter = Builders<Anvisa>.Filter.Eq("Id", anvisa.Id);
                _Anvisa.DeleteOne(filter);
            });
        }

        public async Task Udpate(Anvisa anvisa)
        {
            await Task.Run(() =>
            {
                var filterAnvisa = Builders<Anvisa>.Filter.Eq("Id", anvisa.Id);
                var updateAnvisa = Builders<Anvisa>.Update
                        .Set("NR", anvisa.Ref_USA)
                        .Set("SR", anvisa.SR)
                        .Set("SR", anvisa.DI)
                        .Set("Importador", anvisa.Importador)
                        .Set("Previsao", anvisa.Previsao)
                        .Set("StatusDoProcesso", anvisa.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisa, updateAnvisa);

                Processo processo = new();
                Decex decex = new();
                MAPA mapa = new();

                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.Ref_USA, anvisa.Ref_USA);
                var resultIDProcesso = _Processo.Find(filterProcesso).FirstOrDefaultAsync<Processo>().Result?.Id;
                var filterProcessoUpdate = Builders<Processo>.Filter.Eq("Id", resultIDProcesso);
                var updateProcesso = Builders<Processo>.Update
                        .Set("NR", anvisa.Ref_USA)
                        .Set("Importador", anvisa.Importador)
                        .Set("Previsao", anvisa.Previsao)
                        .Set("StatusDoProcesso", anvisa.StatusDoProcesso);
                _Processo.UpdateOne(filterProcessoUpdate, updateProcesso);

                var filterDecex = Builders<Decex>.Filter.Eq(g => g.Ref_USA, anvisa.Ref_USA);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexUpdate = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                var updateDecex = Builders<Decex>.Update
                        .Set("NR", anvisa.Ref_USA)
                        .Set("Importador", anvisa.Importador)
                        .Set("Previsao", anvisa.Previsao)
                        .Set("Pendencia", anvisa.Pendencia)
                        .Set("StatusDoProcesso", anvisa.StatusDoProcesso);
                _Decex.UpdateOne(filterDecex, updateDecex);

                var filterMapa = Builders<MAPA>.Filter.Eq(g => g.Ref_USA, anvisa.Ref_USA);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaUpdate = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                var updateMapa = Builders<MAPA>.Update
                        .Set("NR", anvisa.Ref_USA)
                        .Set("Importador", anvisa.Importador)
                        .Set("Previsao", anvisa.Previsao)
                        .Set("Pendencia", anvisa.Pendencia)
                        .Set("StatusDoProcesso", anvisa.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapa, updateMapa);
            });
        }
        public List<Anvisa> FindAll()
        {
            var filter = Builders<Anvisa>.Filter.Empty;
            return _Anvisa.Find<Anvisa>(filter).ToList<Anvisa>();
        }
        public List<Anvisa> Find(string filtro, string pesquisa)
        {
            var filter = Builders<Anvisa>.Filter.Empty;
            if (filtro == "NR")
            {
                filter = Builders<Anvisa>.Filter.Regex(g => g.Ref_USA, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Importador")
            {
                filter = Builders<Anvisa>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Previsao")
            {
                filter = Builders<Anvisa>.Filter.Regex(g => g.Previsao, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "Pendencia")
            {
                filter = Builders<Anvisa>.Filter.Regex(g => g.Pendencia, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if (filtro == "StatusDoProcesso")
            {
                filter = Builders<Anvisa>.Filter.Regex(g => g.StatusDoProcesso, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            return _Anvisa.Find(filter).ToList();
        }
    }
}
