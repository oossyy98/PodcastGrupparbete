using System;
using Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;


namespace DAL_DataAccess
{
    public class AvsnittRepository : IRepository<Avsnitt>
    {
        private readonly IMongoCollection<Avsnitt> _kollektion; //MongoDB collection for Avsnitt
        private readonly MongoDBConnection _connection;
        public AvsnittRepository(MongoDBConnection anslutning)
        {
            _connection = anslutning;
            _kollektion = anslutning.HamtaKollektion<Avsnitt>("avsnitt");
        }
        public async Task Create(Avsnitt item)
        {
            await _kollektion.InsertOneAsync(item);
        }
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Avsnitt>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Avsnitt> GetById(string id)
        {
            throw new NotImplementedException();
        }
        public Task Update(string id, Avsnitt item)
        {
            throw new NotImplementedException();
        }
    }
}