﻿using MongoDB.Driver;


namespace CLUSA
{
    public class RepositorioAnvisa
    {
        private IMongoCollection<Anvisa> _Anvisa;
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
                var filter = Builders<Anvisa>.Filter.Eq("Id", anvisa.Id);
                var update = Builders<Anvisa>.Update
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
                _Anvisa.UpdateOne(filter, update);
            });
        }
    }
}