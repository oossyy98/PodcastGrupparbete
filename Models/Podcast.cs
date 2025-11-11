using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("namn")]
        public string Namn { get; set; }

        [BsonElement("url")]
        public string Url { get; set; }

        [BsonElement("kategoriId")]
        public string KategoriId { get; set; }

        [BsonElement("avsnitt")]
        public List<Avsnitt> Avsnitt { get; set; }

        public Podcast()
        {
            Avsnitt = new List<Avsnitt>();
        }


    }
}
