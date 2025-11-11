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

        [BsonElement("Namn")]
        public string Name { get; set; }

        [BsonElement("URL")]
        public string RssUrl { get; set; }

        //referens till kategori
        [BsonElement("kategoriId")]
        public string KategoriId { get; set; }

        [BsonElement("Avsnitt")]
        public List<Avsnitt> AvsnittLista { get; set; }

        public Podcast()
        {
            Avsnitt = new List<Avsnitt>();
        }

        public Podcast(string namn, string url)
        {
            Namn = namn;
            RssUrl = url;
            Avsnitt
        }
    }
}
