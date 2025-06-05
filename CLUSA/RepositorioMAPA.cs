using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioMAPA
    {
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Inmetro> _Imetro;
        private readonly IMongoCollection<TiposOrgaoAnuente> _MAPA;

        public RepositorioMAPA()
        {
            var connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/";
            var mongoClient = new MongoClient(connectionString);
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Imetro = mongoDatabase.GetCollection<Inmetro>("IMETRO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<TiposOrgaoAnuente>("MAPA");
        }
        public List<TiposOrgaoAnuente> ListaMapa => _MAPA.Find(Builders<TiposOrgaoAnuente>.Filter.Empty).ToList();

        public async Task CreateAsync(TiposOrgaoAnuente mapa)
        {
            await _MAPA.InsertOneAsync(mapa);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<TiposOrgaoAnuente>.Filter.Eq("_id", id);
            await _MAPA.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(TiposOrgaoAnuente mapa)
        {
            var filter = Builders<TiposOrgaoAnuente>.Filter.Eq("_id", mapa.Id);
            var update = Builders<TiposOrgaoAnuente>.Update
                .Set(a => a.Ref_USA, mapa.Ref_USA)
                .Set(a => a.Importador, mapa.Importador)
                .Set(a => a.SR, mapa.SR)
                .Set(a => a.Exportador, mapa.Exportador)
                .Set(a => a.Veiculo, mapa.Veiculo)
                .Set(a => a.Produto, mapa.Produto)
                .Set(a => a.Origem, mapa.Origem)
                .Set(a => a.Li, mapa.Li)
                .Set(a => a.InspecaoMapa, mapa.InspecaoMapa)
                .Set(a => a.CheckInspecaoMapa, mapa.CheckInspecaoMapa)
                .Set(a => a.DataDeAtracacao, mapa.DataDeAtracacao)
                .Set(a => a.CheckDataDeAtracacao, mapa.CheckDataDeAtracacao)
                .Set(a => a.DataEmbarque, mapa.DataEmbarque)
                .Set(a => a.CheckDataEmbarque, mapa.CheckDataEmbarque)
                .Set(a => a.Amostra, mapa.Amostra)
                .Set(a => a.Pendencia, mapa.Pendencia)
                .Set(a => a.StatusDoProcesso, mapa.StatusDoProcesso);

            await _MAPA.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, mapa.Ref_USA, mapa);
            await AtualizarColecaoRelacionadoAsync(_Anvisa, mapa.Ref_USA, mapa);
            await AtualizarColecaoRelacionadoAsync(_Decex, mapa.Ref_USA, mapa);
            await AtualizarColecaoRelacionadoAsync(_Ibama, mapa.Ref_USA, mapa);
            await AtualizarColecaoRelacionadoAsync(_Imetro, mapa.Ref_USA, mapa);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, TiposOrgaoAnuente mapa) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", mapa.Ref_USA)
                .Set("Importador", mapa.Importador)
                .Set("SR", mapa.SR)
                .Set("Exportador", mapa.Exportador)
                .Set("Veiculo", mapa.Veiculo)
                .Set("Produto", mapa.Produto)
                .Set("Origem", mapa.Origem)
                .Set("Li", mapa.Li)
                .Set("DataDeAtracacao", mapa.DataDeAtracacao)
                .Set("CheckDataDeAtracacao", mapa.CheckDataDeAtracacao)
                .Set("DataEmbarque", mapa.DataEmbarque)
                .Set("CheckDataEmbarque", mapa.CheckDataEmbarque)
                .Set("Amostra", mapa.Amostra)
                .Set("Pendencia", mapa.Pendencia)
                .Set("StatusDoProcesso", mapa.StatusDoProcesso);

            await colecao.UpdateOneAsync(filter, update);
        }

        public async Task<List<TiposOrgaoAnuente>> FindAllAsync()
        {
            return await _MAPA.Find(Builders<TiposOrgaoAnuente>.Filter.Empty).ToListAsync();
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            return _MAPA.Distinct<string>(campo, Builders<TiposOrgaoAnuente>.Filter.Empty).ToList();
        }

        public List<TiposOrgaoAnuente> FindAll()
        {
            return _MAPA.Find(Builders<TiposOrgaoAnuente>.Filter.Empty).ToList();
        }

        public List<TiposOrgaoAnuente> Find(string campo, string pesquisa)
        {
            var filtro = Builders<TiposOrgaoAnuente>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
            return _MAPA.Find(filtro).ToList();
        }
    }
}
