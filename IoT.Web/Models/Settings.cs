using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT.Web.Models
{
    public class Settings
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CoreID { get; set; }
        public double StandardRPM { get; set; }
        public int Allowance { get; set; }
        public int TimeOut { get; set; }
        public int StartAfter { get; set; }
    }
}