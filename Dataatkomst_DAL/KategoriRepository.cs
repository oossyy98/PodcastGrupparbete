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
            try
            {
                await _kollektion.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid skapande: {ex.Message}");
                throw;
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
                await _kollektion.DeleteOneAsync(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid borttagning av kategori {id}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<Kategori>> GetAllAsync()
        {
            try
            {
                return await _kollektion.Find(FilterDefinition<Kategori>.Empty).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av alla kategorier: {ex.Message}");
                throw;
            }
        }

        public async Task<Kategori> GetById(string id)
        {
            try
            {
                var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
                return await _kollektion.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av kategori {id}: {ex.Message}");
                throw;
            }
        }

        public async Task Update(string id, Kategori item)
        {
            try
            {
                var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
                await _kollektion.ReplaceOneAsync(filter, item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid uppdatering av kategori {id}: {ex.Message}");
                throw;
            }
        }
    }
}
