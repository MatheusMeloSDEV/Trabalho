﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUSA
{
    public class Anvisa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int NR { get; set; } = 0;
        public int SR { get; set; } = 0;
        public string Importador { get; set; } = string.Empty;
        public DateTime Previsao { get; set; } = DateTime.Now;
        public string Terminal { get; set; } = string.Empty;
        public string Pendencia { get; set; } = string.Empty;
        public int LI { get; set; } = 0;
        public int LPCO { get; set; } = 0;
        public DateTime DataDeEntrada { get; set; } = DateTime.Now;
        public string DataDeInspeção { get; set; } = string.Empty;
        public string StatusDoProcesso { get; set; } = string.Empty;
    }
}