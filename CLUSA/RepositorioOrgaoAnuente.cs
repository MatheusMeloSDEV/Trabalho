using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CLUSA
{
    public class RepositorioOrgaoAnuente<T> where T : class
    {
        private readonly IMongoCollection<T> _colecao;

        public RepositorioOrgaoAnuente(string collectionName)
        {
            var client = new MongoClient(ConfigDatabase.MongoConnectionString);
            var database = client.GetDatabase(ConfigDatabase.MongoDatabaseName);
            _colecao = database.GetCollection<T>(collectionName);
        }

        // Síncronos
        public List<T> ListarTodos()
        {
            return _colecao.Find(FilterDefinition<T>.Empty).ToList();
        }

        public void Adicionar(T entidade)
        {
            _colecao.InsertOne(entidade);
        }

        public void Atualizar(string refUsa, T entidade)
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa)
            _colecao.ReplaceOne(filter, entidade, new ReplaceOptions { IsUpsert = true });
        }

        public void Remover(string refUsa)
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            _colecao.DeleteMany(filter);
        }

        public T? ObterPorRefUsa(string refUsa)
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            return _colecao.Find(filter).FirstOrDefault();
        }

        // Assíncronos
        public async Task<List<T>> ListarTodosAsync()
        {
            return await _colecao.Find(FilterDefinition<T>.Empty).ToListAsync();
        }

        public async Task AdicionarAsync(T entidade)
        {
            await _colecao.InsertOneAsync(entidade);
        }

        public async Task AtualizarAsync(string refUsa, T entidade)
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            await _colecao.ReplaceOneAsync(filter, entidade, new ReplaceOptions { IsUpsert = true });
        }

        public async Task RemoverAsync(string refUsa)
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            await _colecao.DeleteManyAsync(filter);
        }

        public async Task<T?> ObterPorRefUsaAsync(string refUsa)
        {
            var filter = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            return await _colecao.Find(filter).FirstOrDefaultAsync();
        }
    }
}