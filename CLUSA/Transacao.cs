using CLUSA;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUSA
{
    public class Transacao
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public TipoTransacao Tipo { get; set; }

        public string Categoria { get; set; } = string.Empty;

        public DateTime Data { get; set; } = DateTime.Now;
    }
}