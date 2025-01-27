using MongoDB.Bson;
using MongoDB.Driver;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioDecex
    {
        private readonly IMongoCollection<Decex> _Decex;

        public RepositorioDecex()
        {
            var connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/";
            var mongoClient = new MongoClient(connectionString);
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
        }

        [DataMember]
        public List<Decex> ListaDecex => _Decex.Find(FilterDefinition<Decex>.Empty).ToList();

        public List<string> ObterValoresUnicos(string campo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                throw new ArgumentException("O parâmetro 'campo' não pode ser nulo ou vazio.", nameof(campo));
            }

            return _Decex.Distinct<string>(campo, FilterDefinition<Decex>.Empty).ToList();
        }

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
            await AtualizarDocumento(_Decex, decex.Id, decex);
        }

        private static async Task AtualizarDocumento<T>(IMongoCollection<T> colecao, ObjectId id, T documento) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("_id", id);
            var updateDef = CriarAtualizacao(documento);
            await colecao.UpdateOneAsync(filtro, updateDef);
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

        public List<Decex> Find(string campo, string pesquisa)
        {
            try
            {
                var property = typeof(Decex).GetProperty(campo) ?? throw new KeyNotFoundException($"O campo '{campo}' não existe no modelo Decex.");
                var filter = Builders<Decex>.Filter.Regex(campo, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));
                return _Decex.Find(filter).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados no MongoDB: {ex.Message}");
                return new List<Decex>();
            }
        }

        public List<Decex> FindAll()
        {
            try
            {
                return _Decex.Find(FilterDefinition<Decex>.Empty).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os documentos: {ex.Message}");
                return new List<Decex>();
            }
        }

        public async Task<List<Decex>> FindAllAsync()
        {
            return await _Decex.Find(FilterDefinition<Decex>.Empty).ToListAsync();
        }
    }
}
