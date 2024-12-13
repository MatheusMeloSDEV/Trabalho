using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace CLUSA
{
    public class RepositorioProcesso
    {
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioProcesso()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
        }

        public List<Processo> ListaProcesso => _Processo.Find(Builders<Processo>.Filter.Empty).ToList();

        public List<string> ObterValoresUnicos(string campo)
        {
            return _Processo.Distinct<string>(campo, FilterDefinition<Processo>.Empty).ToList();
        }

        public List<string> ObterImportadoresUnicos()
        {
            return _Processo.Distinct<string>("Importador", FilterDefinition<Processo>.Empty).ToList();
        }

        public async Task Create(Processo processo, string colecao)
        {
            await Task.Run(() =>
            {
                switch (colecao)
                {
                    case "MAPA":
                        _MAPA.InsertOne(new MAPA(processo));
                        break;
                    case "Anvisa":
                        _Anvisa.InsertOne(new Anvisa(processo));
                        break;
                    case "Decex":
                        _Decex.InsertOne(new Decex(processo));
                        break;
                    default:
                        _Processo.InsertOne(processo);
                        break;
                }
            });
        }

        public async Task Delete(Processo processo)
        {
            await Task.Run(() =>
            {
                // Excluir o processo principal
                var filter = Builders<Processo>.Filter.Eq(p => p.Id, processo.Id);
                _Processo.DeleteOne(filter);

                // Excluir documentos relacionados nas coleções específicas
                ExcluirDocumentoRelacionado(_MAPA, processo.Ref_USA);
                ExcluirDocumentoRelacionado(_Anvisa, processo.Ref_USA);
                ExcluirDocumentoRelacionado(_Decex, processo.Ref_USA);
            });
        }

        private void ExcluirDocumentoRelacionado<T>(IMongoCollection<T> colecao, string refUsa) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            colecao.DeleteMany(filtro);
        }

        public async Task Update(Processo processo)
        {
            await Task.WhenAll(
                AtualizarDocumentoAsync(_Processo, processo.Id, processo),
                AtualizarDocumentoRelacionadoAsync(_MAPA, processo.Ref_USA, processo),
                AtualizarDocumentoRelacionadoAsync(_Anvisa, processo.Ref_USA, processo),
                AtualizarDocumentoRelacionadoAsync(_Decex, processo.Ref_USA, processo)
            );
        }

        private async Task AtualizarDocumentoAsync<T>(IMongoCollection<T> colecao, ObjectId id, T documento) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("_id", id);
            var updateDef = CriarAtualizacao(documento);
            await colecao.UpdateOneAsync(filtro, updateDef);
        }

        private async Task AtualizarDocumentoRelacionadoAsync<T>(IMongoCollection<T> colecao, string refUsa, Processo processo) where T : class, new()
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);

            // Obter o documento atual
            var documentoAtual = await colecao.Find(filtro).FirstOrDefaultAsync();

            if (documentoAtual != null)
            {
                // Mapear as propriedades do objeto Processo para o tipo T
                var documentoAtualizado = MapearPropriedades(processo, documentoAtual);

                var updateDef = CriarAtualizacao(documentoAtualizado);
                await colecao.UpdateOneAsync(filtro, updateDef);
            }
        }

        private UpdateDefinition<T> CriarAtualizacao<T>(T documento) where T : class
        {
            var updateDef = Builders<T>.Update;
            var updates = new List<UpdateDefinition<T>>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var value = prop.GetValue(documento);
                if (value != null)
                {
                    updates.Add(updateDef.Set(prop.Name, value));
                }
                else
                {
                    updates.Add(updateDef.Unset(prop.Name)); // Remove a propriedade se for nula
                }
            }

            return updateDef.Combine(updates);
        }

        private T MapearPropriedades<T>(Processo origem, T destino) where T : class, new()
        {
            foreach (var propDestino in typeof(T).GetProperties())
            {
                var propOrigem = typeof(Processo).GetProperty(propDestino.Name);
                if (propOrigem != null && propOrigem.CanRead && propDestino.CanWrite)
                {
                    var valorOrigem = propOrigem.GetValue(origem);
                    propDestino.SetValue(destino, valorOrigem);
                }
            }
            return destino;
        }

        public List<Processo> FindAll()
        {
            try
            {
                return _Processo.Find(FilterDefinition<Processo>.Empty).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os processos: {ex.Message}");
                return new List<Processo>();
            }
        }
        public async Task<List<Processo>> FindAllAsync()
        {
            try
            {
                // Busca todos os documentos da coleção 'Processo' de forma assíncrona
                var processos = await _Processo.Find(FilterDefinition<Processo>.Empty).ToListAsync();

                Console.WriteLine($"Total de processos encontrados: {processos.Count}");
                return processos;
            }
            catch (MongoException ex)
            {
                Console.WriteLine($"Erro no MongoDB ao buscar todos os processos: {ex.Message}");
                return new List<Processo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao buscar todos os processos: {ex.Message}");
                return new List<Processo>();
            }
        }
        public List<Processo> Find(string filtro, string pesquisa)
        {
            try
            {
                var property = typeof(Processo).GetProperty(filtro);
                if (property == null)
                {
                    throw new KeyNotFoundException($"O campo '{filtro}' não existe no modelo Processo.");
                }

                var filter = Builders<Processo>.Filter.Regex(filtro, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));

                var resultados = _Processo.Find(filter).ToList();

                Console.WriteLine($"Filtro aplicado no MongoDB: {filtro} com pesquisa '{pesquisa}'. Itens encontrados: {resultados.Count}");
                return resultados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados no MongoDB: {ex.Message}");
                return new List<Processo>();
            }
        }
    }

}
