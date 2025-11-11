using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccess
{
    public class PodcastRepository : IRepository<Podcast>
    {
        private readonly IMongoCollection<Podcast> _kollektion; //MongoDB collection for Podcast
        private readonly MongoDBConnection _connection;

        public PodcastRepository(MongoDBConnection anslutning)
        {
            _connection = anslutning;
            _kollektion = anslutning.HamtaKollektion<Podcast>("podcasts");
        }

        public async Task Create(Podcast item)
        {
            await _kollektion.InsertOneAsync(item);
        }

        public string hej()
        {
            return "hej";
        }

    }
}
