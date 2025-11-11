using System;
using Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccess
{
    public class KategoriRepository : IRepository<Kategori>
    {
        private readonly IMongoCollection<Kategori> _kollektion; //MongoDB collection for Kategori
        private readonly MongoDBConnection _connection;

        public KategoriRepository(MongoDBConnection anslutning)
        {
            _connection = anslutning;
            _kollektion = anslutning.HamtaKollektion<Kategori>("kategorier");
        }
        public async Task Create(Kategori item)
        {
            await _kollektion.InsertOneAsync(item);
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Kategori>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Kategori> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(string id, Kategori item)
        {
            throw new NotImplementedException();
        }
    }
}
