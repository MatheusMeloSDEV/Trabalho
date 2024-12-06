using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CLUSA
{
    public class Notificacao
    {
        [BsonId] // Indica que esta é a propriedade de ID do MongoDB
        [BsonRepresentation(BsonType.ObjectId)] // Permite que o ID seja tratado como string em vez de ObjectId
        public string Id { get; set; }

        public string RefUsa { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Visualizado { get; set; }
    }
}
