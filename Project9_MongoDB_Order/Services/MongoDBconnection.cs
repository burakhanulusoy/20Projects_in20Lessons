using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDB_Order.Services
{
    public class MongoDBconnection
    {
        private IMongoDatabase _database;

        public MongoDBconnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("DB9projectOrder");
        }
        public IMongoCollection<BsonDocument> GetOrdersCollection()
        {

            return _database.GetCollection<BsonDocument>("Orders");
        }


    }
}
