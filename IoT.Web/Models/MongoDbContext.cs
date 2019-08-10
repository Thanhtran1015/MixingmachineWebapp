using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace IoT.Web.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();
            var dbName = ConfigurationManager.AppSettings["dbName"].ToString();
            var client = new MongoClient(connectionString);
            _mongoDb = client.GetDatabase(dbName);
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