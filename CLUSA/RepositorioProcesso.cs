using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class RepositorioProcesso
    {
        private IMongoCollection<Processo> _Processo;
        private IMongoCollection<Anvisa> _Anvisa;

        public RepositorioProcesso()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
        }

        public List<Processo> ListaProcesso
        {
            get
            {
                var filter = Builders<Processo>.Filter.Empty;
                return _Processo.Find<Processo>(filter).ToList<Processo>();
            }
        }

        public async Task Create(Processo processo)
        {
            await Task.Run(() =>
            {
                Anvisa anvisa = new Anvisa();
                anvisa.Importador = processo.Importador;
                _Anvisa.InsertOne(anvisa);
                _Processo.InsertOne(processo);
            });
        }

        public async Task Delete(Processo processo)
        {
            await Task.Run(() =>
            {
                var filter = Builders<Processo>.Filter.Eq("Id", processo.Id);
                _Processo.DeleteOne(filter);
            });
        }

        public async Task Update(Processo processo)
        {
            await Task.Run(() =>
            {
                var filter = Builders<Processo>.Filter.Eq("Id", processo.Id);
                var update = Builders<Processo>.Update
                        .Set("NR", processo.NR)
                        .Set("SR", processo.SR)
                        .Set("Importador", processo.Importador)
                        .Set("Previsao", processo.Previsao)
                        .Set("Terminal", processo.Terminal)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Processo.UpdateOne(filter, update);
            });
        }
    }
}
