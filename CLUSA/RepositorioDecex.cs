using MongoDB.Driver;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task Create(Decex decex)
        {
            await Task.Run(() =>
            {
                _Decex.InsertOne(decex);
            });
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
                var filter = Builders<Decex>.Filter.Eq("Id", decex.Id);
                var update = Builders<Decex>.Update
                        .Set("NR", decex.NR)
                        .Set("SR", decex.SR)
                        .Set("Importador", decex.Importador)
                        .Set("Previsao", decex.Previsao)
                        .Set("Terminal", decex.Terminal)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("LI", decex.LI)
                        .Set("DataDeEntrada", decex.DataDeEntrada)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Decex.UpdateOne(filter, update);
            });
        }
        public RepositorioDecex()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
        }
    }
}
