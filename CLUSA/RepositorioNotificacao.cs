using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioNotificacao
    {

        private readonly IMongoCollection<Notificacao> _colecao;

        public RepositorioNotificacao(IMongoDatabase database)
        {
            _colecao = database.GetCollection<Notificacao>("Notificacao");
        }

        /// <summary>
        /// Verifica se já existe alguma notificação (visível ou não)
        /// para esta referência e mensagem.
        /// </summary>
        public bool ExisteNotificacao(string refUsa, string mensagem)
        {
            var filtro = Builders<Notificacao>.Filter.And(
                Builders<Notificacao>.Filter.Eq(n => n.RefUsa, refUsa),
                Builders<Notificacao>.Filter.Eq(n => n.Mensagem, mensagem)
            );
            return _colecao.Find(filtro).Any();
        }

        public void ExcluirPorRefUsa(string refUsa)
        {
            var filtro = Builders<Notificacao>.Filter.Eq(n => n.RefUsa, refUsa);
            _colecao.DeleteMany(filtro);
        }

        public void SalvarNotificacao(Notificacao notif)
        {
            _colecao.InsertOne(notif);
        }

        public Notificacao ObterNotificacaoPorRefUsa(string refUsa)
        {
            var filtro = Builders<Notificacao>.Filter.Eq(n => n.RefUsa, refUsa);
            return _colecao.Find(filtro).FirstOrDefault();
        }

        // Obter notificações não visualizadas
        public List<Notificacao> ObterNotificacoesNaoVisualizadas()
        {
            var filtro = Builders<Notificacao>.Filter.Eq(n => n.Visualizado, false);
            return _colecao.Find(filtro).ToList();
        }

        // Marcar uma notificação como visualizada
        public void MarcarComoVisualizado(string refUsa, string mensagem)
        {
            var filtro = Builders<Notificacao>.Filter.And(
                            Builders<Notificacao>.Filter.Eq(n => n.RefUsa, refUsa),
                            Builders<Notificacao>.Filter.Eq(n => n.Mensagem, mensagem)
                        );
            var update = Builders<Notificacao>.Update.Set(n => n.Visualizado, true);
            var resultado = _colecao.UpdateMany(filtro, update);

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
