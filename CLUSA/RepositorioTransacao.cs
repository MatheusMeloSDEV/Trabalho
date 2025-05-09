using MongoDB.Bson;
using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioTransacao
    {
        private readonly IMongoCollection<Transacao> _transacoes;

        public RepositorioTransacao(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _transacoes = database.GetCollection<Transacao>(collectionName);
        }

        public List<Transacao> ListarTodos()
        {
            // Se não houver registros, retornará uma lista vazia, o que é normal.
            // Se a conexão falhar, lançará exceção que será capturada no form.
            return _transacoes.Find(_ => true).ToList();
        }

        /// <summary>
        /// Adiciona nova transação ao MongoDB
        /// </summary>
        public void Adicionar(Transacao transacao)
        {
            _transacoes.InsertOne(transacao);
        }

        /// <summary>
        /// Obtém uma transação pelo Id
        /// </summary>
        public Transacao? ObterPorId(ObjectId id)
        {
            return _transacoes.Find(t => t.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Atualiza transação existente (procura pelo Id da transação).
        /// </summary>
        public void Atualizar(Transacao transacao)
        {
            _transacoes.ReplaceOne(t => t.Id == transacao.Id, transacao);
        }

        /// <summary>
        /// Remove transação pelo Id
        /// </summary>
        public void Remover(ObjectId id)
        {
            _transacoes.DeleteOne(t => t.Id == id);
        }

        /// <summary>
        /// Filtra por categoria exata
        /// </summary>
        public List<Transacao> FiltrarPorCategoria(string categoria)
        {
            return _transacoes.Find(t => t.Categoria == categoria).ToList();
        }

        /// <summary>
        /// Filtra por período de Data
        /// </summary>
        public List<Transacao> FiltrarPorPeriodo(DateTime inicio, DateTime fim)
        {
            return _transacoes.Find(t => t.Data >= inicio && t.Data <= fim).ToList();
        }

        /// <summary>
        /// Filtra por tipo de transação (Entrada ou Saída)
        /// </summary>
        public List<Transacao> FiltrarPorTipo(TipoTransacao tipo)
        {
            return _transacoes.Find(t => t.Tipo == tipo).ToList();
        }
    }
}
