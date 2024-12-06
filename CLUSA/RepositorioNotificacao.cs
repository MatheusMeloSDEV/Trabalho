using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class RepositorioNotificacao
    {
        private readonly IMongoCollection<Notificacao> _notificacaoCollection;

        public RepositorioNotificacao(IMongoDatabase database)
        {
            _notificacaoCollection = database.GetCollection<Notificacao>("Notificacoes");
        }

        // Adicionar ou atualizar notificações no banco
        public void SalvarNotificacao(Notificacao notificacao)
        {
            if (string.IsNullOrEmpty(notificacao.RefUsa) || string.IsNullOrEmpty(notificacao.Mensagem))
            {
                Console.WriteLine("Notificação inválida. Campos obrigatórios estão vazios.");
                return;
            }

            var filtro = Builders<Notificacao>.Filter.Eq(n => n.RefUsa, notificacao.RefUsa);

            var atualizacao = Builders<Notificacao>.Update
                .SetOnInsert(n => n.RefUsa, notificacao.RefUsa) // Apenas no Insert
                .Set(n => n.Mensagem, notificacao.Mensagem)
                .Set(n => n.DataCriacao, notificacao.DataCriacao)
                .Set(n => n.Visualizado, notificacao.Visualizado); // Define somente se especificado

            // Aplicar o Update com Upsert (Atualizar ou Inserir)
            var resultado = _notificacaoCollection.UpdateOne(
                filtro,
                atualizacao,
                new UpdateOptions { IsUpsert = true }
            );

            if (resultado.MatchedCount == 0 && resultado.UpsertedId != null)
            {
                Console.WriteLine($"Nova notificação adicionada com ID: {resultado.UpsertedId}");
            }
            else
            {
                Console.WriteLine("Notificação existente atualizada.");
            }
        }

        public Notificacao ObterNotificacaoPorRefUsa(string refUsa)
        {
            var filtro = Builders<Notificacao>.Filter.Eq(n => n.RefUsa, refUsa);
            return _notificacaoCollection.Find(filtro).FirstOrDefault();
        }

        // Obter notificações não visualizadas
        public List<Notificacao> ObterNotificacoesNaoVisualizadas()
        {
            var filtro = Builders<Notificacao>.Filter.Eq(n => n.Visualizado, false);
            return _notificacaoCollection.Find(filtro).ToList();
        }

        // Marcar uma notificação como visualizada
        public void MarcarComoVisualizado(string refUsa)
        {
            var filtro = Builders<Notificacao>.Filter.Eq(n => n.RefUsa, refUsa);
            var atualizacao = Builders<Notificacao>.Update.Set(n => n.Visualizado, true);

            var resultado = _notificacaoCollection.UpdateOne(filtro, atualizacao);

            if (resultado.ModifiedCount > 0)
            {
                Console.WriteLine($"Notificação do processo {refUsa} marcada como visualizada.");
            }
            else
            {
                Console.WriteLine($"Nenhuma notificação foi atualizada para o processo {refUsa}.");
            }
        }
    }
}
