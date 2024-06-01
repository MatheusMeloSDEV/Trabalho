using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class Processo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int NR { get; set; } = 0;
        public int SR { get; set; } = 0;
        public string Importador { get; set; } = string.Empty;
        public string Previsao { get; set; } = string.Empty;
        public string Terminal { get; set; } = string.Empty;
        

        public string StatusDoProcesso { get; set; } = string.Empty;
    }
}
