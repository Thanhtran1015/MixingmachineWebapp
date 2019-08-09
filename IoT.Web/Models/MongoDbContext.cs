using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT.Web.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDb = client.GetDatabase("IoTMixing");
        }
        public IMongoCollection<Employee> Employee
        {
            get
            {
                return _mongoDb.GetCollection<Employee>("Employee");
            }
        }
        public IMongoCollection<RPMDisplayData> RPMDisplayData
        {
            get
            {
                return _mongoDb.GetCollection<RPMDisplayData>("RPMDisplayData");
            }
        }
        public IMongoCollection<Settings> Settings
        {
            get
            {
                return _mongoDb.GetCollection<Settings>("Settings");
            }
        }
    }
}