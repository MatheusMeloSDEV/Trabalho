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
                var filterDecex = Builders<Decex>.Filter.Eq("Id", decex.Id);
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

                Processo processo = new();
                var filterProcesso = Builders<Processo>.Filter.Eq(g => g.NR, decex.NR);
                var resultIDProcesso = _Processo.Find(filterProcesso).FirstOrDefaultAsync<Processo>().Result?.Id;
                var filterProcessoUpdate = Builders<Processo>.Filter.Eq("Id", resultIDProcesso);
                var updateProcesso = Builders<Processo>.Update
                        .Set("NR", decex.NR)
                        .Set("SR", decex.SR)
                        .Set("Importador", decex.Importador)
                        .Set("Previsao", decex.Previsao)
                        .Set("Terminal", decex.Terminal)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Processo.UpdateOne(filterProcessoUpdate, updateProcesso);

                MAPA mapa = new();
                var filterMapa = Builders<MAPA>.Filter.Eq("NR", mapa.NR);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaUpdate = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                var updateMapa = Builders<MAPA>.Update
                        .Set("NR", decex.NR)
                        .Set("SR", decex.SR)
                        .Set("Importador", decex.Importador)
                        .Set("Previsao", decex.Previsao)
                        .Set("Terminal", decex.Terminal)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("LI", decex.LI)
                        .Set("DataDeEntrada", decex.DataDeEntrada)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapaUpdate, updateMapa);

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.NR, decex.NR);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                var updateAnvisa = Builders<Anvisa>.Update
                        .Set("NR", decex.NR)
                        .Set("SR", decex.SR)
                        .Set("Importador", decex.Importador)
                        .Set("Previsao", decex.Previsao)
                        .Set("Terminal", decex.Terminal)
                        .Set("Pendencia", decex.Pendencia)
                        .Set("LI", decex.LI)
                        .Set("DataDeEntrada", decex.DataDeEntrada)
                        .Set("StatusDoProcesso", decex.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);
            });
        }
        public List<Decex> FindAll()
        {
            var filter = Builders<Decex>.Filter.Empty;
            return _Decex.Find<Decex>(filter).ToList<Decex>();
        }

        public RepositorioDecex()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
        }
    }
}
