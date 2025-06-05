using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioIbama
    {
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Inmetro> _Inmetro;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<TiposOrgaoAnuente> _MAPA;

        public RepositorioIbama()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Inmetro = mongoDatabase.GetCollection<Inmetro>("IMETRO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<TiposOrgaoAnuente>("MAPA");
        }

        public List<Ibama> ListaIbama => _Ibama.Find(Builders<Ibama>.Filter.Empty).ToList();

        public async Task CreateAsync(Ibama ibama)
        {
            await _Ibama.InsertOneAsync(ibama);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Ibama>.Filter.Eq("_id", id);
            await _Ibama.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(Ibama ibama)
        {
            var filter = Builders<Ibama>.Filter.Eq("_id", ibama.Id);
            var update = Builders<Ibama>.Update
                .Set(a => a.Ref_USA, ibama.Ref_USA)
                .Set(a => a.Importador, ibama.Importador)
                .Set(a => a.SR, ibama.SR)
                .Set(a => a.Exportador, ibama.Exportador)
                .Set(a => a.Veiculo, ibama.Veiculo)
                .Set(a => a.Produto, ibama.Produto)
                .Set(a => a.Origem, ibama.Origem)
                .Set(a => a.InspecaoIbama, ibama.InspecaoIbama)
                .Set(a => a.CheckInspecaoIbama, ibama.CheckInspecaoIbama)
                .Set(a => a.DataDeAtracacao, ibama.DataDeAtracacao)
                .Set(a => a.CheckDataDeAtracacao, ibama.CheckDataDeAtracacao)
                .Set(a => a.DataEmbarque, ibama.DataEmbarque)
                .Set(a => a.CheckDataEmbarque, ibama.CheckDataEmbarque)
                .Set(a => a.Amostra, ibama.Amostra)
                .Set(a => a.Pendencia, ibama.Pendencia)
                .Set(a => a.StatusDoProcesso, ibama.StatusDoProcesso);

            await _Ibama.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, ibama.Ref_USA, ibama);
            await AtualizarColecaoRelacionadoAsync(_Decex, ibama.Ref_USA, ibama);
            await AtualizarColecaoRelacionadoAsync(_Anvisa, ibama.Ref_USA, ibama);
            await AtualizarColecaoRelacionadoAsync(_Inmetro, ibama.Ref_USA, ibama);
            await AtualizarColecaoRelacionadoAsync(_MAPA, ibama.Ref_USA, ibama);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Ibama ibama) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", ibama.Ref_USA)
                .Set("Importador", ibama.Importador)
                .Set("SR", ibama.SR)
                .Set("Exportador", ibama.Exportador)
                .Set("Veiculo", ibama.Veiculo)
                .Set("Produto", ibama.Produto)
                .Set("Origem", ibama.Origem)
                .Set("Li", ibama.Li)
                .Set("DataDeAtracacao", ibama.DataDeAtracacao)
                .Set("CheckDataDeAtracacao", ibama.CheckDataDeAtracacao)
                .Set("DataEmbarque", ibama.DataEmbarque)
                .Set("CheckDataEmbarque", ibama.CheckDataEmbarque)
                .Set("Amostra", ibama.Amostra)
                .Set("Pendencia", ibama.Pendencia)
                .Set("StatusDoProcesso", ibama.StatusDoProcesso);

            await colecao.UpdateOneAsync(filter, update);
        }

        public async Task<List<Ibama>> FindAllAsync()
        {
            return await _Ibama.Find(Builders<Ibama>.Filter.Empty).ToListAsync();
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            return _Ibama.Distinct<string>(campo, Builders<Ibama>.Filter.Empty).ToList();
        }

        public List<Ibama> FindAll()
        {
            return _Ibama.Find(Builders<Ibama>.Filter.Empty).ToList();
        }

        public List<Ibama> Find(string campo, string pesquisa)
        {
            var filtro = Builders<Ibama>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
            return _Ibama.Find(filtro).ToList();
        }
    }
}
