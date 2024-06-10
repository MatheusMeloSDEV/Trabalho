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

        public async Task Udpate(MAPA mapa)
        {
            await Task.Run(() =>
            {
                var filterMapa = Builders<MAPA>.Filter.Eq("Id", mapa.Id);
                var updateMapa = Builders<MAPA>.Update
                        .Set("NR", mapa.NR)
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
                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.NR, mapa.NR);
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

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.NR, mapa.NR);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
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
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);

                Decex decex = new();
                var filterDecex = Builders<Decex>.Filter.Eq(g => g.NR, mapa.NR);
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
                _Decex.UpdateOne(filterDecexUpdate, updateDecex);
            });
        }

        public List<MAPA> Find(string filtro, string pesquisa)
        {
            var filter = Builders<MAPA>.Filter.Empty;
            if (filtro == "Importador")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
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
        }
    }
}
