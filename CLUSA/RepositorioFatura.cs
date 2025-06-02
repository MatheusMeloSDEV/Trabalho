using MongoDB.Bson;
using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioFatura
    {
        private readonly IMongoCollection<Fatura> _colecao;

        public RepositorioFatura(string connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/",
                                 string databaseName = "Trabalho",
                                 string collectionName = "Fatura")
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _colecao = database.GetCollection<Fatura>(collectionName);
        }

        public List<Fatura> ListaFatura => _colecao.Find(FilterDefinition<Fatura>.Empty).ToList();

        /// <summary>Recupera todas as faturas.</summary>
        public async Task<List<Fatura>> FindAllAsync()
            => await _colecao.Find(FilterDefinition<Fatura>.Empty).ToListAsync();

        /// <summary>Recupera uma única fatura pela Ref_USA.</summary>
        public async Task<Fatura> FindByRefAsync(string refUsa)
        {
            var filtro = Builders<Fatura>
                         .Filter
                         .Eq(f => f.Ref_USA, refUsa);
            return await _colecao
                         .Find(filtro)
                         .FirstOrDefaultAsync();
        }

        /// <summary>Insere uma nova fatura.</summary>
        public async Task CreateAsync(Fatura fatura)
        {
            if (fatura is null) throw new ArgumentNullException(nameof(fatura));
            await _colecao.InsertOneAsync(fatura);
        }

        /// <summary>Atualiza uma fatura existente (por Id).</summary>
        public async Task UpdateAsync(Fatura fatura)
        {
            if (fatura is null) throw new ArgumentNullException(nameof(fatura));
            if (fatura.Id == ObjectId.Empty)
                throw new ArgumentException("Id inválido para atualização.", nameof(fatura.Id));

            var filter = Builders<Fatura>
                         .Filter
                         .Eq(f => f.Id, fatura.Id);

            var update = Builders<Fatura>.Update
                .Set(f => f.Ref_USA, fatura.Ref_USA)
                .Set(f => f.SR, fatura.SR)
                .Set(f => f.Importador, fatura.Importador)
                .Set(f => f.Endereco_Importador, fatura.Endereco_Importador)
                .Set(f => f.DataAtracacao, fatura.DataAtracacao)
                .Set(f => f.Veiculo, fatura.Veiculo)
                .Set(f => f.Marca, fatura.Marca)
                .Set(f => f.Quantidade, fatura.Quantidade)
                .Set(f => f.Mercadoria, fatura.Mercadoria)
                .Set(f => f.ValRecebidos, fatura.ValRecebidos)
                .Set(f => f.DataRecebimento, fatura.DataRecebimento)
                .Set(f => f.DI, fatura.DI)
                .Set(f => f.DataDesembaracoDI, fatura.DataDesembaracoDI)
                .Set(f => f.DAtaDI, fatura.DAtaDI)
                .Set(f => f.ImpostoImportacao, fatura.ImpostoImportacao)
                .Set(f => f.IPI, fatura.IPI)
                .Set(f => f.DI_ADICAO, fatura.DI_ADICAO)
                .Set(f => f.PIS_PASEP, fatura.PIS_PASEP)
                .Set(f => f.COFINS, fatura.COFINS)
                .Set(f => f.MULTA_LI, fatura.MULTA_LI)
                .Set(f => f.ICMS, fatura.ICMS)
                .Set(f => f.Agencias, fatura.Agencias)
                .Set(f => f.ArmazenagemN, fatura.ArmazenagemN)
                .Set(f => f.ArmazenagemP, fatura.ArmazenagemP)
                .Set(f => f.FreteMaritimoN, fatura.FreteMaritimoN)
                .Set(f => f.FreteMaritimoP, fatura.FreteMaritimoP)
                .Set(f => f.Marinha_MercanteN, fatura.Marinha_MercanteN)
                .Set(f => f.Marinha_MercanteP, fatura.Marinha_MercanteP)
                .Set(f => f.GRUANVISAN, fatura.GRUANVISAN)
                .Set(f => f.GRUANVISAP, fatura.GRUANVISAP)
                .Set(f => f.LiCancelada_IndeferidaN, fatura.LiCancelada_IndeferidaN)
                .Set(f => f.LiCancelada_IndeferidaP, fatura.LiCancelada_IndeferidaP)
                .Set(f => f.ExpedienteLiCanceladaN, fatura.ExpedienteLiCanceladaN)
                .Set(f => f.ExpedienteLiCanceladaP, fatura.ExpedienteLiCanceladaP)
                .Set(f => f.EncaminhamentoAmostrasN, fatura.EncaminhamentoAmostrasN)
                .Set(f => f.EncaminhamentoAmostrasP, fatura.EncaminhamentoAmostrasP)
                .Set(f => f.DarfAnvisaN, fatura.DarfAnvisaN)
                .Set(f => f.DarfAnvisaP, fatura.DarfAnvisaP)
                .Set(f => f.MotoboyN, fatura.MotoboyN)
                .Set(f => f.MotoboyP, fatura.MotoboyP)
                .Set(f => f.LiP, fatura.LiP)
                .Set(f => f.Expediente, fatura.Expediente)
                .Set(f => f.DespesasDesembaracoN, fatura.DespesasDesembaracoN)
                .Set(f => f.DespesasDesembaracoP, fatura.DespesasDesembaracoP)
                .Set(f => f.HD, fatura.HD)
                .Set(f => f.Cartorio, fatura.Cartorio)
                .Set(f => f.NomesDocumentosAnexos, fatura.NomesDocumentosAnexos)
                .Set(f => f.NumeroDocumentosAnexos, fatura.NumeroDocumentosAnexos)
                .Set(f => f.TotalDespesas, fatura.TotalDespesas)
                .Set(f => f.NComissao, fatura.NComissao)
                .Set(f => f.SubTotal, fatura.SubTotal)
                .Set(f => f.Adiantamento, fatura.Adiantamento)
                .Set(f => f.Saldo, fatura.Saldo)
                .Set(f => f.TipoFinalizacao, fatura.TipoFinalizacao)
                ;

            await _colecao.UpdateOneAsync(filter, update);
        }

        /// <summary>Remove uma fatura pelo seu Id.</summary>
        public async Task DeleteAsync(ObjectId id)
        {
            var filtro = Builders<Fatura>
                         .Filter
                         .Eq(f => f.Id, id);
            await _colecao.DeleteOneAsync(filtro);
        }
        public async Task<Fatura> ObterPorRefUSAAsync(string refUsa)
        {
            if (string.IsNullOrWhiteSpace(refUsa))
                throw new ArgumentException("Referência USA não pode ser nula ou vazia.", nameof(refUsa));

            var filtro = Builders<Fatura>.Filter.Eq(f => f.Ref_USA, refUsa);
            return await _colecao.Find(filtro).FirstOrDefaultAsync();
        }
        public List<Fatura> FindRef()
        {
            var filtro = Builders<Fatura>.Filter.And(
                Builders<Fatura>.Filter.Ne(f => f.Ref_USA, null),
                Builders<Fatura>.Filter.Ne(f => f.Importador, null)
            );

            return _colecao.Find(filtro).ToList();
        }
    }
}
