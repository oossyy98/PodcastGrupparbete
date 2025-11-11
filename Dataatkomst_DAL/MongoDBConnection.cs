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

        public MongoDBConnection()
        {
            var klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:<OruPassword@orumongodb.nzapwps.mongodb.net/?appName=OruMongoDB");
            var databas = klient.GetDatabase("OruMongoDB");
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
