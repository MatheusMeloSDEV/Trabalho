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
        public string Previsao { get; set; } = string.Empty;
        public string Terminal { get; set; } = string.Empty;
        public string Pendencia { get; set; } = string.Empty;
        public string CSI_Original { get; set; } = string.Empty;
        public string LI { get; set; } = string.Empty;
        public string LPCO { get; set; } = string.Empty;
        public string DataDeEntrada { get; set; } = string.Empty;
        public string Parametrizacao { get; set; } = string.Empty;
        public string SEI { get; set; } = string.Empty;
        public string DataDeInspeção { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;
    }
}
