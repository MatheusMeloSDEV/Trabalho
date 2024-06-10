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
                var filter = Builders<MAPA>.Filter.Eq("Id", mapa.Id);
                var update = Builders<MAPA>.Update
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
                _MAPA.UpdateOne(filter, update);
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
