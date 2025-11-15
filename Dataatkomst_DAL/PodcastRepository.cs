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
        private readonly IMongoCollection<Podcast> kollektion; //MongoDB collection for Podcast
        private readonly MongoDBConnection connection;

        public PodcastRepository(MongoDBConnection connection)
        {
            this.connection = connection;
            kollektion = connection.HamtaKollektion<Podcast>("podcasts");
        }

        public async Task Create(Podcast item)
        {
           await kollektion.InsertOneAsync(item);
        }

        public async Task<Podcast> GetById(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            return await kollektion.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Podcast>> GetAllAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;
            return await kollektion.Find(filter).ToListAsync();
        }

        public async Task Update(string id, Podcast item)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            await kollektion.ReplaceOneAsync(filter, item);
        }

        public async Task Delete(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            await kollektion.DeleteOneAsync(filter);

        }
    }
}
