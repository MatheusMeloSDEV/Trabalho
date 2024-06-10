using MongoDB.Driver;


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
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
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
                        .Set("NR", anvisa.NR)
                        .Set("SR", anvisa.SR)
                        .Set("Importador", anvisa.Importador)
                        .Set("Previsao", anvisa.Previsao)
                        .Set("Terminal", anvisa.Terminal)
                        .Set("Pendencia", anvisa.Pendencia)
                        .Set("LI", anvisa.LI)
                        .Set("LPCO", anvisa.LPCO)
                        .Set("DataDeEntrada", anvisa.DataDeEntrada)
                        .Set("DataDeInspeção", anvisa.DataDeInspeção)
                        .Set("StatusDoProcesso", anvisa.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisa, updateAnvisa);

                Processo processo = new();
                Decex decex = new();
                MAPA mapa = new();

                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.NR, anvisa.NR);
                var resultIDProcesso = _Processo.Find(filterProcesso).FirstOrDefaultAsync<Processo>().Result?.Id;
                var filterProcessoUpdate = Builders<Processo>.Filter.Eq("Id", resultIDProcesso);
                var updateProcesso = Builders<Processo>.Update
                        .Set("NR", processo.NR)
                        .Set("SR", processo.SR)
                        .Set("Importador", processo.Importador)
                        .Set("Previsao", processo.Previsao)
                        .Set("Terminal", processo.Terminal)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Processo.UpdateOne(filterProcessoUpdate, updateProcesso);

                var filterDecex = Builders<Decex>.Filter.Eq(g => g.NR, anvisa.NR);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexUpdate = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                var updateDecex = Builders<Decex>.Update
                        .Set("NR", decex.NR)
                        .Set("SR", decex.SR)
                        .Set("Importador", decex.Importador)
                        .Set("Previsao", decex.Previsao)
                        .Set("Terminal", decex.Terminal)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("LI", decex.LI)
                        .Set("DataDeEntrada", decex.DataDeEntrada)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Decex.UpdateOne(filterDecex, updateDecex);

                var filterMapa = Builders<MAPA>.Filter.Eq(g => g.NR, anvisa.NR);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaUpdate = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                var updateMapa = Builders<MAPA>.Update
                        .Set("NR", mapa.NR)
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
                _MAPA.UpdateOne(filterMapa, updateMapa);
            });
        }
    }
}
