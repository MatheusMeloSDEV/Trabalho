using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioMAPA
    {
        private IMongoCollection<MAPA> _MAPA;

        public List<MAPA> ListaMapa
        {
            get
            {
                var filter = Builders<MAPA>.Filter.Empty;
                return _MAPA.Find<MAPA>(filter).ToList<MAPA>();
            }
        }

        public void Create(MAPA mapa)
        {
            _MAPA.InsertOne(mapa);
        }

        public void Delete(MAPA mapa)
        {
            var filter = Builders<MAPA>.Filter.Eq("Id", mapa.Id);
            _MAPA.DeleteOne(filter);
        }

        public void Udpate(MAPA mapa)
        {
            var filter = Builders<MAPA>.Filter.Eq("Id", mapa.Id);
            var update = Builders<MAPA>.Update.Set("Importador", mapa.Importador).Set("Navio", mapa.Navio).Set("Terminal", mapa.Terminal);
            _MAPA.UpdateOne(filter, update);
        }

        public RepositorioMAPA()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }
    }
}
