using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioImetro
    {
        private readonly IMongoCollection<Imetro> _Imetro;
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioImetro()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Imetro = mongoDatabase.GetCollection<Imetro>("IMETRO");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Imetro> ListaImetro => _Imetro.Find(Builders<Imetro>.Filter.Empty).ToList();

        public async Task CreateAsync(Imetro imetro)
        {
            await _Imetro.InsertOneAsync(imetro);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Imetro>.Filter.Eq("_id", id);
            await _Imetro.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(Imetro imetro)
        {
            var filter = Builders<Imetro>.Filter.Eq("_id", imetro.Id);
            var update = Builders<Imetro>.Update
                .Set(a => a.Ref_USA, imetro.Ref_USA)
                .Set(a => a.Importador, imetro.Importador)
                .Set(a => a.SR, imetro.SR)
                .Set(a => a.Exportador, imetro.Exportador)
                .Set(a => a.Navio, imetro.Navio)
                .Set(a => a.Terminal, imetro.Terminal)
                .Set(a => a.Produto, imetro.Produto)
                .Set(a => a.Origem, imetro.Origem)
                .Set(a => a.NCM, imetro.NCM)
                .Set(a => a.LI, imetro.LI)
                .Set(a => a.LPCO, imetro.LPCO)
                .Set(a => a.DataRegistroLPCO, imetro.DataRegistroLPCO)
                .Set(a => a.DataDeferimentoLPCO, imetro.DataDeferimentoLPCO)
                .Set(a => a.ParametrizacaoLPCO, imetro.ParametrizacaoLPCO)
                .Set(a => a.DataDeAtracacao, imetro.DataDeAtracacao)
                .Set(a => a.Inspecao, imetro.Inspecao)
                .Set(a => a.Amostra, imetro.Amostra)
                .Set(a => a.Pendencia, imetro.Pendencia)
                .Set(a => a.StatusDoProcesso, imetro.StatusDoProcesso);

            await _Imetro.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, imetro.Ref_USA, imetro);
            await AtualizarColecaoRelacionadoAsync(_Decex, imetro.Ref_USA, imetro);
            await AtualizarColecaoRelacionadoAsync(_Anvisa, imetro.Ref_USA, imetro);
            await AtualizarColecaoRelacionadoAsync(_Ibama, imetro.Ref_USA, imetro);
            await AtualizarColecaoRelacionadoAsync(_MAPA, imetro.Ref_USA, imetro);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Imetro imetro) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", imetro.Ref_USA)
                .Set("Importador", imetro.Importador)
                .Set("SR", imetro.SR)
                .Set("Exportador", imetro.Exportador)
                .Set("Navio", imetro.Navio)
                .Set("Terminal", imetro.Terminal)
                .Set("Produto", imetro.Produto)
                .Set("Origem", imetro.Origem)
                .Set("NCM", imetro.NCM)
                .Set("LI", imetro.LI)
                .Set("LPCO", imetro.LPCO)
                .Set("DataRegistroLPCO", imetro.DataRegistroLPCO)
                .Set("DataDeferimentoLPCO", imetro.DataDeferimentoLPCO)
                .Set("ParametrizacaoLPCO", imetro.ParametrizacaoLPCO)
                .Set("DataDeAtracacao", imetro.DataDeAtracacao)
                .Set("Inspecao", imetro.Inspecao)
                .Set("Amostra", imetro.Amostra)
                .Set("Pendencia", imetro.Pendencia)
                .Set("StatusDoProcesso", imetro.StatusDoProcesso);

            await colecao.UpdateOneAsync(filter, update);
        }

        public async Task<List<Imetro>> FindAllAsync()
        {
            return await _Imetro.Find(Builders<Imetro>.Filter.Empty).ToListAsync();
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            return _Imetro.Distinct<string>(campo, Builders<Imetro>.Filter.Empty).ToList();
        }

        public List<Imetro> FindAll()
        {
            return _Imetro.Find(Builders<Imetro>.Filter.Empty).ToList();
        }

        public List<Imetro> Find(string campo, string pesquisa)
        {
            var filtro = Builders<Imetro>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
            return _Imetro.Find(filtro).ToList();
        }
    }
}
