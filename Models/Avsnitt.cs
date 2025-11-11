using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        [BsonElement("titel")]
        public string Titel { get; set; }
        [BsonElement("beskrivning")]
        public string Beskrivning { get; set; }

        [BsonElement("publiceringsdatum")]
        public DateTime Publiceringsdatum { get; set; }
        
    }
}
