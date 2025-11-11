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
        private readonly IMongoCollection<Avsnitt> _kollektion; // MongoDB collection for Avsnitt
        private readonly MongoDBConnection _connection;

        public AvsnittRepository(MongoDBConnection anslutning)
        {
            _connection = anslutning;
            _kollektion = anslutning.HamtaKollektion<Avsnitt>("avsnitt");
        }

        public async Task Create(Avsnitt item)
        {
            try
            {
                await _kollektion.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid skapande av avsnitt: {ex.Message}");
                throw;
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, id);
                await _kollektion.DeleteOneAsync(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid borttagning av avsnitt {id}: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<Avsnitt>> GetAllAsync()
        {
            try
            {
                return await _kollektion.Find(FilterDefinition<Avsnitt>.Empty).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av alla avsnitt: {ex.Message}");
                throw;
            }
        }

        public async Task<Avsnitt> GetById(string id)
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, id);
                return await _kollektion.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid hämtning av avsnitt {id}: {ex.Message}");
                throw;
            }
        }

        public async Task Update(string id, Avsnitt item)
        {
            try
            {
                var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, id);
                await _kollektion.ReplaceOneAsync(filter, item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid uppdatering av avsnitt {id}: {ex.Message}");
                throw;
            }
        }
        }
    }