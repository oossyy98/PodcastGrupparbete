using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RssUrl { get; set; }
        public string Category { get; set; }
    }
}
