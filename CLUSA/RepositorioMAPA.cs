using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CLUSA
{
    public class RepositorioMAPA
    {
        private readonly IMongoCollection<Processo> _Processo;
        private readonly IMongoCollection<Anvisa> _Anvisa;
        private readonly IMongoCollection<Decex> _Decex;
        private readonly IMongoCollection<MAPA> _MAPA;

        public List<MAPA> ListaMapa
        {
            get
            {
                return _MAPA.Find(FilterDefinition<MAPA>.Empty).ToList();
            }
        }

        public List<string> ObterValoresUnicos(string campo)
        {
            // Filtrar os valores únicos no MongoDB
            var valoresUnicos = _MAPA.Distinct<string>(campo, FilterDefinition<MAPA>.Empty).ToList();
            return valoresUnicos;
        }

        public async Task Update(MAPA mapa)
        {
            // Atualizar o documento principal de MAPA
            await AtualizarDocumento(_MAPA, mapa.Id, mapa);

            // Atualizar documentos relacionados
            await AtualizarDocumentoRelacionado(_Processo, mapa.Ref_USA, mapa);
            await AtualizarDocumentoRelacionado(_Anvisa, mapa.Ref_USA, mapa);
            await AtualizarDocumentoRelacionado(_Decex, mapa.Ref_USA, mapa);
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
        private async Task AtualizarDocumento<T>(IMongoCollection<T> colecao, ObjectId id, T documento) where T : class
        {
            var filtro = Builders<T>.Filter.Eq("_id", id);
            var updateDef = CriarAtualizacao(documento);
            await colecao.UpdateOneAsync(filtro, updateDef);
        }
        private async Task AtualizarDocumentoRelacionado<T>(IMongoCollection<T> colecao, string refUsa, MAPA mapa) where T : class, new()
        {
            var filtro = Builders<T>.Filter.Eq("Ref_USA", refUsa);

            // Obter o documento atual
            var documentoAtual = await colecao.Find(filtro).FirstOrDefaultAsync();

            if (documentoAtual != null)
            {
                // Mapear propriedades de MAPA para T
                var documentoAtualizado = MapearPropriedades(mapa, documentoAtual);

                var updateDef = CriarAtualizacao(documentoAtualizado);
                await colecao.UpdateOneAsync(filtro, updateDef);
            }
        }
        private UpdateDefinition<T> CriarAtualizacao<T>(T documento)
        {
            var updateDef = Builders<T>.Update;
            var updates = new List<UpdateDefinition<T>>();

            foreach (var prop in typeof(T).GetProperties())
            {
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
        private TDestino MapearPropriedades<TDestino>(MAPA origem, TDestino destino) where TDestino : class, new()
        {
            foreach (var propDestino in typeof(TDestino).GetProperties())
            {
                var propOrigem = typeof(MAPA).GetProperty(propDestino.Name);
                if (propOrigem != null && propOrigem.CanRead && propDestino.CanWrite)
                {
                    var valorOrigem = propOrigem.GetValue(origem);
                    propDestino.SetValue(destino, valorOrigem);
                }
            }
            return destino;
        }

        public List<MAPA> Find(string filtro, string pesquisa)
        {
            try
            {
                // Verificar se o campo existe na classe
                var property = typeof(MAPA).GetProperty(filtro);
                if (property == null)
                {
                    throw new KeyNotFoundException($"O campo '{filtro}' não existe no modelo MAPA.");
                }

                // Construir o filtro Regex
                var filter = Builders<MAPA>.Filter.Regex(filtro, new BsonRegularExpression(new Regex(pesquisa, RegexOptions.IgnoreCase)));

                // Buscar os resultados no MongoDB
                var resultados = _MAPA.Find(filter).ToList();

                Console.WriteLine($"Filtro aplicado no MongoDB: {filtro} com pesquisa '{pesquisa}'. Itens encontrados: {resultados.Count}");
                return resultados;
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
                Console.WriteLine($"Erro ao buscar todos os processos: {ex.Message}");
                return new List<MAPA>();
            }
        }

        public async Task<List<MAPA>> FindAllAsync()
        {
            try
            {
                return await _MAPA.Find(FilterDefinition<MAPA>.Empty).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os processos: {ex.Message}");
                return new List<MAPA>();
            }
        }

        public RepositorioMAPA()
        {
            // Recomenda-se mover a string de conexão para um arquivo de configuração ou variável de ambiente
            var connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/";
            var mongoClient = new MongoClient(connectionString);
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _MAPA = mongoDatabase.GetCollection<MAPA>("MAPA");
            _Anvisa = mongoDatabase.GetCollection<Anvisa>("ANVISA");
            _Decex = mongoDatabase.GetCollection<Decex>("DECEX");
            _Processo = mongoDatabase.GetCollection<Processo>("PROCESSO");
        }
    }
}
