using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioInmetro
    {
        private readonly IMongoCollection<Inmetro> _Inmetro;
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioInmetro()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Inmetro = mongoDatabase.GetCollection<Inmetro>("INMETRO");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Inmetro> ListaInmetro => _Inmetro.Find(Builders<Inmetro>.Filter.Empty).ToList();

        public async Task CreateAsync(Inmetro inmetro)
        {
            await _Inmetro.InsertOneAsync(inmetro);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<Inmetro>.Filter.Eq("_id", id);
            await _Inmetro.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(Inmetro inmetro)
        {
            var filter = Builders<Inmetro>.Filter.Eq("_id", inmetro.Id);
            var update = Builders<Inmetro>.Update
                .Set(a => a.Ref_USA, inmetro.Ref_USA)
                .Set(a => a.Importador, inmetro.Importador)
                .Set(a => a.SR, inmetro.SR)
                .Set(a => a.Exportador, inmetro.Exportador)
                .Set(a => a.Navio, inmetro.Navio)
                .Set(a => a.Produto, inmetro.Produto)
                .Set(a => a.Origem, inmetro.Origem)
                .Set(a => a.NCM, inmetro.NCM)
                .Set(a => a.LI, inmetro.LI)
                .Set(a => a.LPCO, inmetro.LPCO)
                .Set(a => a.DataRegistroLPCO, inmetro.DataRegistroLPCO)
                .Set(a => a.CheckDataRegistroLPCO, inmetro.CheckDataRegistroLPCO)
                .Set(a => a.DataDeferimentoLPCO, inmetro.DataDeferimentoLPCO)
                .Set(a => a.CheckDataDeferimentoLPCO, inmetro.CheckDataDeferimentoLPCO)
                .Set(a => a.ParametrizacaoLPCO, inmetro.ParametrizacaoLPCO)
                .Set(a => a.InspecaoInmetro, inmetro.InspecaoInmetro)
                .Set(a => a.CheckInspecaoInmetro, inmetro.CheckInspecaoInmetro)
                .Set(a => a.DataDeAtracacao, inmetro.DataDeAtracacao)
                .Set(a => a.CheckDataDeAtracacao, inmetro.CheckDataDeAtracacao)
                .Set(a => a.DataEmbarque, inmetro.DataEmbarque)
                .Set(a => a.CheckDataEmbarque, inmetro.CheckDataEmbarque)
                .Set(a => a.Amostra, inmetro.Amostra)
                .Set(a => a.Pendencia, inmetro.Pendencia)
                .Set(a => a.StatusDoProcesso, inmetro.StatusDoProcesso);

            await _Inmetro.UpdateOneAsync(filter, update);

            // Atualizar coleções relacionadas
            await AtualizarColecaoRelacionadoAsync(_Processo, inmetro.Ref_USA, inmetro);
            await AtualizarColecaoRelacionadoAsync(_Decex, inmetro.Ref_USA, inmetro);
            await AtualizarColecaoRelacionadoAsync(_Anvisa, inmetro.Ref_USA, inmetro);
            await AtualizarColecaoRelacionadoAsync(_Ibama, inmetro.Ref_USA, inmetro);
            await AtualizarColecaoRelacionadoAsync(_MAPA, inmetro.Ref_USA, inmetro);
        }

        private static async Task AtualizarColecaoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Inmetro inmetro) where T : class
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var update = Builders<T>.Update
                .Set("Ref_USA", inmetro.Ref_USA)
                .Set("Importador", inmetro.Importador)
                .Set("SR", inmetro.SR)
                .Set("Exportador", inmetro.Exportador)
                .Set("Navio", inmetro.Navio)
                .Set("Produto", inmetro.Produto)
                .Set("Origem", inmetro.Origem)
                .Set("NCM", inmetro.NCM)
                .Set("LI", inmetro.LI)
                .Set("LPCO", inmetro.LPCO)
                .Set("DataRegistroLPCO", inmetro.DataRegistroLPCO)
                .Set("CheckDataRegistroLPCO", inmetro.CheckDataRegistroLPCO)
                .Set("DataDeferimentoLPCO", inmetro.DataDeferimentoLPCO)
                .Set("CheckDataDeferimentoLPCO", inmetro.CheckDataDeferimentoLPCO)
                .Set("ParametrizacaoLPCO", inmetro.ParametrizacaoLPCO)
                .Set("DataDeAtracacao", inmetro.DataDeAtracacao)
                .Set("CheckDataDeAtracacao", inmetro.CheckDataDeAtracacao)
                .Set("DataEmbarque", inmetro.DataEmbarque)
                .Set("CheckDataEmbarque", inmetro.CheckDataEmbarque)
                .Set("Amostra", inmetro.Amostra)
                .Set("Pendencia", inmetro.Pendencia)
                .Set("StatusDoProcesso", inmetro.StatusDoProcesso);

            await colecao.UpdateOneAsync(filter, update);
        }

        public async Task<List<Inmetro>> FindAllAsync()
        {
            return await _Inmetro.Find(Builders<Inmetro>.Filter.Empty).ToListAsync();
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            return _Inmetro.Distinct<string>(campo, Builders<Inmetro>.Filter.Empty).ToList();
        }

        public List<Inmetro> FindAll()
        {
            return _Inmetro.Find(Builders<Inmetro>.Filter.Empty).ToList();
        }

        public List<Inmetro> Find(string campo, string pesquisa)
        {
            var filtro = Builders<Inmetro>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
            return _Inmetro.Find(filtro).ToList();
        }
    }
}
