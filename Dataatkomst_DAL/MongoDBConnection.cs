using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccess
{
    public class MongoDBConnection
    {
        private readonly IMongoDatabase _databas;

        public MongoDBConnection(string anslutningsStrang, string databasNamn)
        {
            var klient = new MongoClient(anslutningsStrang);
            _databas = klient.GetDatabase(databasNamn);
        }

        public IMongoCollection<T> HamtaKollektion<T>(string kollektionsNamn)
        {
            return _databas.GetCollection<T>(kollektionsNamn);
        }

        public IMongoClient HamtaKlient()
        {
            return _databas.Client;
        }
    }
}
