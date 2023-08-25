using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class MAPA
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string NR { get; set; } = string.Empty;
        public string SR { get; set; } = string.Empty;
        public string Importador { get; set; } = string.Empty;
        public string Navio { get; set; } = string.Empty;
        public string Previsao { get; set; } = string.Empty;
        public string Terminal { get; set; } = string.Empty;
        public string Armazem { get; set; } = string.Empty;
        public string Container { get; set; } = string.Empty;
        public string Anuete { get; set; } = string.Empty;
        public string CE { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public bool Capa { get; set; } = false;

    }
}
