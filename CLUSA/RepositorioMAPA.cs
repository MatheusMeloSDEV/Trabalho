using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace CLUSA
{
    public class RepositorioMAPA
    {
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioMAPA()
        {
            var connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/";
            var mongoClient = new MongoClient(connectionString);
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
        }
        [DataMember]
        public List<MAPA> ListaMapa => _MAPA.Find(FilterDefinition<MAPA>.Empty).ToList();

        public List<string> ObterValoresUnicos(string campo)
        {
            return _MAPA.Distinct<string>(campo, FilterDefinition<MAPA>.Empty).ToList();
        }

        public async Task CreateAsync(MAPA mapa)
        {
            await _MAPA.InsertOneAsync(mapa);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<MAPA>.Filter.Eq("_id", id);
            await _MAPA.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(MAPA mapa)
        {
            await Task.WhenAll(
                AtualizarDocumento(_MAPA, mapa.Id, mapa),
                AtualizarDocumentoRelacionado(_Processo, mapa.Ref_USA, mapa),
                AtualizarDocumentoRelacionado(_Anvisa, mapa.Ref_USA, mapa),
                AtualizarDocumentoRelacionado(_Decex, mapa.Ref_USA, mapa)
            );
        }

        private static async Task AtualizarDocumento<T>(IMongoCollection<T> colecao, ObjectId id, T documento) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("_id", id);
            var updateDef = CriarAtualizacao(documento);
            await colecao.UpdateOneAsync(filtro, updateDef);
        }

        private static async Task AtualizarDocumentoRelacionado<T>(IMongoCollection<T> colecao, string refUsa, MAPA mapa) where T : class, new()
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            var documentoAtual = await colecao.Find(filtro).FirstOrDefaultAsync();

            if (documentoAtual != null)
            {
                var documentoAtualizado = MapearPropriedades(mapa, documentoAtual);
                var updateDef = CriarAtualizacao(documentoAtualizado);
                await colecao.UpdateOneAsync(filtro, updateDef);
            }
        }

        private static UpdateDefinition<T> CriarAtualizacao<T>(T documento) where T : class
        {
            var updates = typeof(T).GetProperties()
                .Where(prop => prop.CanRead)
                .Select(prop => new { prop.Name, Value = prop.GetValue(documento) })
                .Select(pair => pair.Value != null
                    ? Builders<T>.Update.Set(pair.Name, pair.Value)
                    : Builders<T>.Update.Unset(pair.Name))
                .ToList();

            return Builders<T>.Update.Combine(updates);
        }

        private static TDestino MapearPropriedades<TDestino>(MAPA origem, TDestino destino) where TDestino : class, new()
        {
            foreach (var propDestino in typeof(TDestino).GetProperties().Where(p => p.CanWrite))
            {
                var propOrigem = typeof(MAPA).GetProperty(propDestino.Name);
                if (propOrigem != null && propOrigem.CanRead)
                {
                    var valorOrigem = propOrigem.GetValue(origem);
                    propDestino.SetValue(destino, valorOrigem);
                }
            }
            return destino;
        }

        public List<MAPA> Find(string campo, string pesquisa)
        {
            try
            {
                var property = typeof(MAPA).GetProperty(campo) ?? throw new KeyNotFoundException($"O campo '{campo}' não existe no modelo MAPA.");
                var filter = Builders<MAPA>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
                return _MAPA.Find(filter).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados no MongoDB: {ex.Message}");
                return new List<MAPA>();
            }
        }

        public List<MAPA> FindAll()
        {
            try
            {
                return _MAPA.Find(FilterDefinition<MAPA>.Empty).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os documentos: {ex.Message}");
                return new List<MAPA>(); // Retorna uma lista vazia em vez de null
            }
        }

        public async Task<List<MAPA>> FindAllAsync()
        {
            return await _MAPA.Find(FilterDefinition<MAPA>.Empty).ToListAsync();
        }
    }
}
