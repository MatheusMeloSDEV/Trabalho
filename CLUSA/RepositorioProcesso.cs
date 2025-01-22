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
        private readonly IMongoCollection<Ibama> _Ibama;
        private readonly IMongoCollection<Imetro> _Imetro;
        private readonly IMongoCollection<MAPA> _MAPA;

        public RepositorioProcesso()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _Ibama = mongoDatabase.GetCollection<Ibama>("IBAMA");
            _Imetro = mongoDatabase.GetCollection<Imetro>("IMETRO");
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
                    case "IBAMA":
                        _Ibama.InsertOne(new Ibama(processo));
                        break;
                    case "IMETRO":
                        _Imetro.InsertOne(new Imetro(processo));
                        break;
                    default:
                        _Processo.InsertOne(processo);
                        break;
                }
            });
        }
        public bool VerificarExistencia(Processo processo)
        {
            bool existeMapa = ExisteNaColecao(_MAPA, "TMapa", processo.TMapa);
            bool existeAnvisa = ExisteNaColecao(_Anvisa, "TAnvisa", processo.TAnvisa);
            bool existeDecex = ExisteNaColecao(_Decex, "TDecex", processo.TDecex);
            bool existeImetro = ExisteNaColecao(_Imetro, "TImetro", processo.TImetro);
            bool existeIbama = ExisteNaColecao(_Ibama, "TIbama", processo.TIbama);

            return existeMapa || existeAnvisa || existeDecex || existeImetro || existeIbama;
        }

        public static bool ExisteNaColecao<T>(IMongoCollection<T> colecao, string campo, bool valor) where T : class
        {
            var filtro = Builders<T>.Filter.Eq(campo, valor);
            return colecao.Find(filtro).Any();
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
                ExcluirDocumentoRelacionado(_Ibama, processo.Ref_USA);
                ExcluirDocumentoRelacionado(_Imetro, processo.Ref_USA);
            });
        }

        private static void ExcluirDocumentoRelacionado<T>(IMongoCollection<T> colecao, string refUsa) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            colecao.DeleteMany(filtro);
        }

        public async Task Update(Processo processo)
        {
            // Atualizar o documento principal
            await AtualizarDocumento(_Processo, processo.Id, processo);

            // Gerenciar a atualização ou exclusão de documentos relacionados
            await GerenciarRelacoes(processo);
        }

        private async Task GerenciarRelacoes(Processo processo)
        {
            // MAPA
            if (!processo.TMapa)
            {
                await RemoverDocumentoRelacionado(_MAPA, processo.Ref_USA);
            }
            else
            {
                await AtualizarDocumentoRelacionado(_MAPA, processo.Ref_USA, processo);
            }

            // Anvisa
            if (!processo.TAnvisa)
            {
                await RemoverDocumentoRelacionado(_Anvisa, processo.Ref_USA);
            }
            else
            {
                await AtualizarDocumentoRelacionado(_Anvisa, processo.Ref_USA, processo);
            }

            // Decex
            if (!processo.TDecex)
            {
                await RemoverDocumentoRelacionado(_Decex, processo.Ref_USA);
            }
            else
            {
                await AtualizarDocumentoRelacionado(_Decex, processo.Ref_USA, processo);
            }

            // Ibama
            if (!processo.TIbama)
            {
                await RemoverDocumentoRelacionado(_Ibama, processo.Ref_USA);
            }
            else
            {
                await AtualizarDocumentoRelacionado(_Ibama, processo.Ref_USA, processo);
            }

            // Imetro
            if (!processo.TImetro)
            {
                await RemoverDocumentoRelacionado(_Imetro, processo.Ref_USA);
            }
            else
            {
                await AtualizarDocumentoRelacionado(_Imetro, processo.Ref_USA, processo);
            }
        }

        private static async Task RemoverDocumentoRelacionado<T>(IMongoCollection<T> colecao, string refUsa) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);
            await colecao.DeleteOneAsync(filtro);
        }

        private static async Task AtualizarDocumento<T>(IMongoCollection<T> colecao, ObjectId id, T documento) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("_id", id);
            var updateDef = CriarAtualizacaoSemId(documento);
            await colecao.UpdateOneAsync(filtro, updateDef, new UpdateOptions { IsUpsert = true });
        }

        private static async Task AtualizarDocumentoRelacionado<T>(IMongoCollection<T> colecao, string refUsa, Processo processo) where T : class, new()
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);

            // Tentar buscar o documento existente
            var documentoAtual = await colecao.Find(filtro).FirstOrDefaultAsync();

            if (documentoAtual != null)
            {
                Console.WriteLine($"Atualizando documento existente em {typeof(T).Name} com Ref_USA = {refUsa}");
                // Atualizar o documento existente
                var documentoAtualizado = MapearPropriedades(processo, documentoAtual);
                var updateDef = CriarAtualizacaoSemId(documentoAtualizado);
                await colecao.UpdateOneAsync(filtro, updateDef);
            }
            else
            {
                Console.WriteLine($"Inserindo novo documento em {typeof(T).Name} com Ref_USA = {refUsa}");
                // Inserir novo documento se não existir
                var novoDocumento = MapearPropriedades(processo, new T());
                await colecao.InsertOneAsync(novoDocumento);
            }
        }

        private static UpdateDefinition<T> CriarAtualizacaoSemId<T>(T documento)
        {
            var updateDef = Builders<T>.Update;
            var updates = new List<UpdateDefinition<T>>();

            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.Name == "_id") continue; // Ignora o campo _id
                var valor = prop.GetValue(documento);
                if (valor != null)
                {
                    updates.Add(updateDef.Set(prop.Name, valor));
                }
                else
                {
                    updates.Add(updateDef.Unset(prop.Name)); // Remove a propriedade se for nula
                }
            }

            return updateDef.Combine(updates);
        }

        private static T MapearPropriedades<T>(Processo origem, T destino) where T : class, new()
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
                var property = typeof(Processo).GetProperty(filtro) ?? throw new KeyNotFoundException($"O campo '{filtro}' não existe no modelo Processo.");
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
