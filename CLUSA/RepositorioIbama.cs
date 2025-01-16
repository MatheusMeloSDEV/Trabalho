using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioIbama
    {
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Imetro> _Imetro;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioIbama()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Imetro = mongoDatabase.GetCollection<Imetro>("IMETRO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Ibama> ListaIbama => _Ibama.Find(Builders<Ibama>.Filter.Empty).ToList();

        public async Task CreateAsync(Ibama anvisa)
        {
            await _Ibama.InsertOneAsync(anvisa);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Ibama>.Filter.Eq("_id", id);
            await _Ibama.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(Ibama anvisa)
        {
            var filter = Builders<Ibama>.Filter.Eq("_id", anvisa.Id);
            var update = Builders<Ibama>.Update
                .Set(a => a.Ref_USA, anvisa.Ref_USA)
                .Set(a => a.Importador, anvisa.Importador)
                .Set(a => a.SR, anvisa.SR)
                .Set(a => a.Exportador, anvisa.Exportador)
                .Set(a => a.Navio, anvisa.Navio)
                .Set(a => a.Terminal, anvisa.Terminal)
                .Set(a => a.Produto, anvisa.Produto)
                .Set(a => a.Origem, anvisa.Origem)
                .Set(a => a.NCM, anvisa.NCM)
                .Set(a => a.LI, anvisa.LI)
                .Set(a => a.LPCO, anvisa.LPCO)
                .Set(a => a.DataRegistroLPCO, anvisa.DataRegistroLPCO)
                .Set(a => a.DataDeferimentoLPCO, anvisa.DataDeferimentoLPCO)
                .Set(a => a.ParametrizacaoLPCO, anvisa.ParametrizacaoLPCO)
                .Set(a => a.DataDeAtracacao, anvisa.DataDeAtracacao)
                .Set(a => a.Inspecao, anvisa.Inspecao)
                .Set(a => a.Amostra, anvisa.Amostra)
                .Set(a => a.Pendencia, anvisa.Pendencia)
                .Set(a => a.StatusDoProcesso, anvisa.StatusDoProcesso);

            await _Ibama.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, anvisa.Ref_USA, anvisa);
            await AtualizarColecaoRelacionadoAsync(_Decex, anvisa.Ref_USA, anvisa);
            await AtualizarColecaoRelacionadoAsync(_Anvisa, anvisa.Ref_USA, anvisa);
            await AtualizarColecaoRelacionadoAsync(_Imetro, anvisa.Ref_USA, anvisa);
            await AtualizarColecaoRelacionadoAsync(_MAPA, anvisa.Ref_USA, anvisa);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Ibama ibama) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", ibama.Ref_USA)
                .Set("Importador", ibama.Importador)
                .Set("SR", ibama.SR)
                .Set("Exportador", ibama.Exportador)
                .Set("Navio", ibama.Navio)
                .Set("Terminal", ibama.Terminal)
                .Set("Produto", ibama.Produto)
                .Set("Origem", ibama.Origem)
                .Set("NCM", ibama.NCM)
                .Set("LI", ibama.LI)
                .Set("LPCO", ibama.LPCO)
                .Set("DataRegistroLPCO", ibama.DataRegistroLPCO)
                .Set("DataDeferimentoLPCO", ibama.DataDeferimentoLPCO)
                .Set("ParametrizacaoLPCO", ibama.ParametrizacaoLPCO)
                .Set("DataDeAtracacao", ibama.DataDeAtracacao)
                .Set("Inspecao", ibama.Inspecao)
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
