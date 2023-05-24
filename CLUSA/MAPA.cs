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
        public ObjectId Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Age")]
        public string Age { get; set; }
        [BsonElement("Mail")]
        public string Mail { get; set; }
        [BsonElement("Cachorro")]
        public string Cachorro { get; set; }

        public MAPA(string name, string age, string mail, string cachorro)
        {
            Name = name;
            Age = age;
            Mail = mail;
            Cachorro = cachorro;
        }
    }
}
