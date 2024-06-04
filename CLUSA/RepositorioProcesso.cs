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
