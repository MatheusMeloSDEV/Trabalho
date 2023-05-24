using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var update = Builders<MAPA>.Update.Set("Nome", mapa.Nome).Set("Telefone", mapa.Telefone).Set("Endereco", mapa.Endereco);
            _MAPA.UpdateOne(filter, update);
        }
        
        public RepositorioMAPA()
        {
            var mongoClient = new MongoClient("mongodb+srv://guilherme218614:coxinha123@todoapp.d1y3kvy.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("CRUD");
            _MAPA = mongoDatabase.GetCollection<MAPA>("agendaDB");

        }
    }
}
