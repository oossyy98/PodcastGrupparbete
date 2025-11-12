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
        //La till en för _klient
        private readonly IMongoClient _klient;

        public MongoDBConnection()
        {
            // Tog bort < > runt lösenordet!, det ska ej vara med och var på klient och databas
            _klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:OruPassword@orumongodb.nzapwps.mongodb.net/?appName=OruMongoDB");
            _databas = _klient.GetDatabase("OruMongoDB");
        }

        public IMongoCollection<T> HamtaKollektion<T>(string kollektionsNamn)
        {
            return _databas.GetCollection<T>(kollektionsNamn);
        }

        public IMongoClient HamtaKlient()
        {
            //ändrade denna från _databas.Client till _klient
            return _klient;
        }
    }
}
