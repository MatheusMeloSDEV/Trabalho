using MongoDB.Bson;
using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioRecibo
    {
        private readonly IMongoCollection<Recibo> _colecao;
        public RepositorioRecibo(string connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/",
                                 string databaseName = "Trabalho",
                                 string collectionName = "Recibo")
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _colecao = database.GetCollection<Recibo>(collectionName);
        }
        public async Task UpdateAsync(Recibo recibo)
        {
            if (recibo is null) throw new ArgumentNullException(nameof(recibo));
            if (recibo.Id == ObjectId.Empty)
                throw new ArgumentException("Id inválido para atualização.", nameof(recibo.Id));

            var filter = Builders<Recibo>
                         .Filter
                         .Eq(f => f.Id, recibo.Id);

            var update = Builders<Recibo>.Update
                .Set(f => f.Ref_USA, recibo.Ref_USA)
                .Set(f => f.SR, recibo.SR)
                .Set(f => f.Importador, recibo.Importador)
                .Set(f => f.Exportador, recibo.Exportador)
                .Set(f => f.Endereco_Importador, recibo.Endereco_Importador)
                .Set(f => f.Veiculo, recibo.Veiculo)
                .Set(f => f.Mercadoria, recibo.Mercadoria)
                .Set(f => f.EmissaoLicenca, recibo.EmissaoLicenca)
                .Set(f => f.Expediente, recibo.Expediente)
                .Set(f => f.HonorariosDespachante, recibo.HonorariosDespachante)
                .Set(f => f.Total, recibo.Total)
                .Set(f => f.Datahoje, recibo.Datahoje);

            await _colecao.UpdateOneAsync(filter, update);
        }
        public List<Recibo> FindRef()
        {
            var filtro = Builders<Recibo>.Filter.And(
                Builders<Recibo>.Filter.Ne(f => f.Ref_USA, null),
                Builders<Recibo>.Filter.Ne(f => f.Importador, null)
            );

            return _colecao.Find(filtro).ToList();
        }
        public async Task<Recibo> ObterPorRefUSAAsync(string refUsa)
        {
            if (string.IsNullOrWhiteSpace(refUsa))
                throw new ArgumentException("Referência USA não pode ser nula ou vazia.", nameof(refUsa));

            var filtro = Builders<Recibo>.Filter.Eq(f => f.Ref_USA, refUsa);
            return await _colecao.Find(filtro).FirstOrDefaultAsync();
        }
    }
}
