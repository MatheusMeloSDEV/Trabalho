using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioAnvisa
    {
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioAnvisa()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Anvisa> ListaAnvisa => _Anvisa.Find(Builders<Anvisa>.Filter.Empty).ToList();

        public async Task CreateAsync(Anvisa anvisa)
        {
            await _Anvisa.InsertOneAsync(anvisa);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Anvisa>.Filter.Eq("_id", id);
            await _Anvisa.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(Anvisa anvisa)
        {
            var filter = Builders<Anvisa>.Filter.Eq("_id", anvisa.Id);
            var update = Builders<Anvisa>.Update
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

            await _Anvisa.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, anvisa.Ref_USA, anvisa);
            await AtualizarColecaoRelacionadoAsync(_Decex, anvisa.Ref_USA, anvisa);
            await AtualizarColecaoRelacionadoAsync(_MAPA, anvisa.Ref_USA, anvisa);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Anvisa anvisa) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", anvisa.Ref_USA)
                .Set("Importador", anvisa.Importador)
                .Set("SR", anvisa.SR)
                .Set("Exportador", anvisa.Exportador)
                .Set("Navio", anvisa.Navio)
                .Set("Terminal", anvisa.Terminal)
                .Set("Produto", anvisa.Produto)
                .Set("Origem", anvisa.Origem)
                .Set("NCM", anvisa.NCM)
                .Set("LI", anvisa.LI)
                .Set("LPCO", anvisa.LPCO)
                .Set("DataRegistroLPCO", anvisa.DataRegistroLPCO)
                .Set("DataDeferimentoLPCO", anvisa.DataDeferimentoLPCO)
                .Set("ParametrizacaoLPCO", anvisa.ParametrizacaoLPCO)
                .Set("DataDeAtracacao", anvisa.DataDeAtracacao)
                .Set("Inspecao", anvisa.Inspecao)
                .Set("Amostra", anvisa.Amostra)
                .Set("Pendencia", anvisa.Pendencia)
                .Set("StatusDoProcesso", anvisa.StatusDoProcesso);

            await colecao.UpdateOneAsync(filter, update);
        }

        public async Task<List<Anvisa>> FindAllAsync()
        {
            return await _Anvisa.Find(Builders<Anvisa>.Filter.Empty).ToListAsync();
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            return _Anvisa.Distinct<string>(campo, Builders<Anvisa>.Filter.Empty).ToList();
        }

        public List<Anvisa> FindAll()
        {
            return _Anvisa.Find(Builders<Anvisa>.Filter.Empty).ToList();
        }

        public List<Anvisa> Find(string campo, string pesquisa)
        {
            var filtro = Builders<Anvisa>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
            return _Anvisa.Find(filtro).ToList();
        }
    }
}
