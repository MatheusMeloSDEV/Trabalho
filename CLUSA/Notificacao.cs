using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CLUSA
{
    public class Notificacao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public BsonType Id { get; set; }

        public string RefUsa { get; set; } = String.Empty;
        public string Mensagem { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }
        public bool Visualizado { get; set; }
    }
}
