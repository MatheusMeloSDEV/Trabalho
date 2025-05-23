using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioDecex
    {
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Inmetro> _Imetro;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioDecex()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Imetro = mongoDatabase.GetCollection<Inmetro>("IMETRO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Decex> ListaDecex => _Decex.Find(Builders<Decex>.Filter.Empty).ToList();

        public async Task CreateAsync(Decex decex)
        {
            await _Decex.InsertOneAsync(decex);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Decex>.Filter.Eq("_id", id);
            await _Decex.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(Decex decex)
        {
            var filter = Builders<Decex>.Filter.Eq("_id", decex.Id);
            var update = Builders<Decex>.Update
                .Set(a => a.Ref_USA, decex.Ref_USA)
                .Set(a => a.Importador, decex.Importador)
                .Set(a => a.SR, decex.SR)
                .Set(a => a.Exportador, decex.Exportador)
                .Set(a => a.Navio, decex.Navio)
                .Set(a => a.Produto, decex.Produto)
                .Set(a => a.Origem, decex.Origem)
                .Set(a => a.NCM, decex.NCM)
                .Set(a => a.Li, decex.Li)
                .Set(a => a.InspecaoDecex, decex.InspecaoDecex)
                .Set(a => a.CheckInspecaoDecex, decex.CheckInspecaoDecex)
                .Set(a => a.DataDeAtracacao, decex.DataDeAtracacao)
                .Set(a => a.CheckDataDeAtracacao, decex.CheckDataDeAtracacao)
                .Set(a => a.DataEmbarque, decex.DataEmbarque)
                .Set(a => a.CheckDataEmbarque, decex.CheckDataEmbarque)
                .Set(a => a.Amostra, decex.Amostra)
                .Set(a => a.Pendencia, decex.Pendencia)
                .Set(a => a.StatusDoProcesso, decex.StatusDoProcesso);

            await _Decex.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, decex.Ref_USA, decex);
            await AtualizarColecaoRelacionadoAsync(_Anvisa, decex.Ref_USA, decex);
            await AtualizarColecaoRelacionadoAsync(_MAPA, decex.Ref_USA, decex);
            await AtualizarColecaoRelacionadoAsync(_Ibama, decex.Ref_USA, decex);
            await AtualizarColecaoRelacionadoAsync(_Imetro, decex.Ref_USA, decex);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Decex decex) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", decex.Ref_USA)
                .Set("Importador", decex.Importador)
                .Set("SR", decex.SR)
                .Set("Exportador", decex.Exportador)
                .Set("Navio", decex.Navio)
                .Set("Produto", decex.Produto)
                .Set("Origem", decex.Origem)
                .Set("NCM", decex.NCM)
                .Set("Li", decex.Li)
                .Set("DataDeAtracacao", decex.DataDeAtracacao)
                .Set("CheckDataDeAtracacao", decex.CheckDataDeAtracacao)
                .Set("DataEmbarque", decex.DataEmbarque)
                .Set("CheckDataEmbarque", decex.CheckDataEmbarque)
                .Set("Amostra", decex.Amostra)
                .Set("Pendencia", decex.Pendencia)
                .Set("StatusDoProcesso", decex.StatusDoProcesso);

            await colecao.UpdateOneAsync(filter, update);
        }

        public async Task<List<Decex>> FindAllAsync()
        {
            return await _Decex.Find(Builders<Decex>.Filter.Empty).ToListAsync();
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            return _Decex.Distinct<string>(campo, Builders<Decex>.Filter.Empty).ToList();
        }

        public List<Decex> FindAll()
        {
            return _Decex.Find(Builders<Decex>.Filter.Empty).ToList();
        }

        public List<Decex> Find(string campo, string pesquisa)
        {
            var filtro = Builders<Decex>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
            return _Decex.Find(filtro).ToList();
        }
    }
}
