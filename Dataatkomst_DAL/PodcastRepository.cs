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

        public PodcastRepository()
        {
            _connection = new MongoDBConnection();
            _kollektion = _connection.HamtaKollektion<Podcast>("podcasts");
        }

        public async Task Create(Podcast item)
        {
           await _kollektion.InsertOneAsync(item);
        }

        public async Task<Podcast> GetById(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            return await _kollektion.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Podcast>> GetAllAsync()
        {
            var filter = Builders<Podcast>.Filter.Empty;
            return await _kollektion.Find(filter).ToListAsync();
        }

        public async Task Update(string id, Podcast item)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            await _kollektion.ReplaceOneAsync(filter, item);
        }

        public async Task Delete(string id)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, id);
            await _kollektion.DeleteOneAsync(filter);

        }
    }
}
