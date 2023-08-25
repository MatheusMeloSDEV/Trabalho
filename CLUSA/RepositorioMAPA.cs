using Amazon.Runtime.EventStreams.Internal;
using Amazon.Runtime.Internal;
using MongoDB.Driver;
using System.Text.RegularExpressions;

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
            var update = Builders<MAPA>.Update
                    .Set("NR", mapa.NR)
                    .Set("SR",mapa.SR)
                    .Set("Importador", mapa.Importador)
                    .Set("Navio", mapa.Navio)
                    .Set("Previsao", mapa.Previsao)
                    .Set("Terminal", mapa.Terminal)
                    .Set("Armazem", mapa.Armazem)
                    .Set("Container", mapa.Container)
                    .Set("Anuete",mapa.Anuete)
                    .Set("CE", mapa.CE)
                    .Set("Descricao", mapa.Descricao)
                    .Set("Capa", mapa.Capa);
            _MAPA.UpdateOne(filter, update);
        }

        public List<MAPA> Find(string filtro, string pesquisa)
        {
            var filter = Builders<MAPA>.Filter.Empty;
            if(filtro == "Importador")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Importador, new Regex(pesquisa, RegexOptions.IgnoreCase));
            }
            if(filtro == "Navio")
            {
                filter = Builders<MAPA>.Filter.Regex(g => g.Navio, new Regex(pesquisa, RegexOptions.IgnoreCase));
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
