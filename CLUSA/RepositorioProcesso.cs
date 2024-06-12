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
        private IMongoCollection<Decex> _Decex;
        private IMongoCollection<MAPA> _MAPA;

        public RepositorioProcesso()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
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
                anvisa.NR = processo.NR;
                anvisa.SR = processo.SR;
                anvisa.Importador = processo.Importador;
                anvisa.Previsao = processo.Previsao;
                anvisa.Terminal = processo.Terminal;
                anvisa.StatusDoProcesso = processo.StatusDoProcesso;

                Decex decex = new Decex();
                decex.NR = processo.NR;
                decex.SR = processo.SR;
                decex.Importador = processo.Importador;
                decex.Previsao = processo.Previsao;
                decex.Terminal = processo.Terminal;
                decex.StatusDoProcesso = processo.StatusDoProcesso;

                MAPA mapa = new MAPA();
                mapa.NR = processo.NR;
                mapa.SR = processo.SR;
                mapa.Importador = processo.Importador;
                mapa.Previsao = processo.Previsao;
                mapa.Terminal = processo.Terminal;
                mapa.StatusDoProcesso = processo.StatusDoProcesso;

                _Processo.InsertOne(processo);
                _Anvisa.InsertOne(anvisa);
                _Decex.InsertOne(decex);
                _MAPA.InsertOne(mapa);
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
                var filterProcesso = Builders<Processo>.Filter.Eq("Id", processo.Id);
                var updateProcesso = Builders<Processo>.Update
                        .Set("NR", processo.NR)
                        .Set("SR", processo.SR)
                        .Set("Importador", processo.Importador)
                        .Set("Previsao", processo.Previsao)
                        .Set("Terminal", processo.Terminal)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Processo.UpdateOne(filterProcesso, updateProcesso);

                MAPA mapa = new();
                var filterMapa = Builders<MAPA>.Filter.Eq(g => g.NR, processo.NR);
                var resultIDMapa = _MAPA.Find(filterMapa).FirstOrDefaultAsync<MAPA>().Result?.Id;
                var filterMapaUpdate = Builders<MAPA>.Filter.Eq("Id", resultIDMapa);
                var updateMapa = Builders<MAPA>.Update
                        .Set("NR", processo.NR)
                        .Set("SR", processo.SR)
                        .Set("Importador", processo.Importador)
                        .Set("Previsao", processo.Previsao)
                        .Set("Terminal", processo.Terminal)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _MAPA.UpdateOne(filterMapaUpdate, updateMapa);

                Anvisa anvisa = new();
                var filterAnvisa = Builders<Anvisa>.Filter.Eq(g => g.NR, processo.NR);
                var resultIDAnvisa = _Anvisa.Find(filterAnvisa).FirstOrDefaultAsync<Anvisa>().Result?.Id;
                var filterAnvisaUpdate = Builders<Anvisa>.Filter.Eq("Id", resultIDAnvisa);
                var updateAnvisa = Builders<Anvisa>.Update
                        .Set("NR", processo.NR)
                        .Set("SR", processo.SR)
                        .Set("Importador", processo.Importador)
                        .Set("Previsao", processo.Previsao)
                        .Set("Terminal", processo.Terminal)
                        .Set("StatusDoProcesso", mapa.StatusDoProcesso);
                _Anvisa.UpdateOne(filterAnvisaUpdate, updateAnvisa);

                Decex decex = new();
                var filterDecex = Builders<Decex>.Filter.Eq(g => g.NR, processo.NR);
                var resultIDDecex = _Decex.Find(filterDecex).FirstOrDefaultAsync<Decex>().Result?.Id;
                var filterDecexUpdate = Builders<Decex>.Filter.Eq("Id", resultIDDecex);
                var updateDecex = Builders<Decex>.Update
                        .Set("NR", processo.NR)
                        .Set("SR", processo.SR)
                        .Set("Importador", processo.Importador)
                        .Set("Previsao", processo.Previsao)
                        .Set("Terminal", processo.Terminal)
                        .Set("StatusDoProcesso", processo.StatusDoProcesso);
                _Decex.UpdateOne(filterDecexUpdate, updateDecex);
            });
        }
        public List<Processo> FindAll()
        {
            var filter = Builders<Processo>.Filter.Empty;
            return _Processo.Find<Processo>(filter).ToList<Processo>();
        }
    }
}
