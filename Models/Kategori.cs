using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]]
        public string Id { get; set; }

        [BsonElement("Namn")]
        public string Namn { get; set; }

        public Kategori()
        {
            
        }

        public Kategori(string namn)
        {
            Namn = namn;
        }
    }
}
