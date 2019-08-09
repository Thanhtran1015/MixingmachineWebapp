using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT.Web.Models
{
    public class RPMDisplayData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string CoreID { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public int Duration { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public int sumRPM { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public int Count { get; set; }

        [BsonRepresentation(BsonType.Double)]
        public double Average { get; set; }
        public IEnumerable<string> RPMCollection { get; set; }

        public IEnumerable<string> CreatedTimeCollection { get; set; }
        [BsonRepresentation(BsonType.String)]
        public string CreatedDay { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string FirstCreatedTime { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public int Sequence { get; set; }

    }
    public class RPMCollections
    {

        [BsonElement("0")]
        public string Index0 { get; set; }
        [BsonElement("1")]
        public string Index1 { get; set; }
        [BsonElement("2")]
        public string Index2 { get; set; }
        [BsonElement("3")]
        public string Index3 { get; set; }
        [BsonElement("4")]
        public string Index4 { get; set; }
        [BsonElement("5")]
        public string Index5 { get; set; }
        [BsonElement("6")]
        public string Index6 { get; set; }
        [BsonElement("7")]
        public string Index7 { get; set; }
        [BsonElement("8")]
        public string Index8 { get; set; }
        [BsonElement("9")]
        public string Index9 { get; set; }
        [BsonElement("10")]
        public string Index10 { get; set; }
        [BsonElement("11")]
        public string Index11
        {
            get; set;
        }
        [BsonElement("12")]
        public string Index12 { get; set; }
        [BsonElement("13")]
        public string Index13 { get; set; }
        [BsonElement("14")]
        public string Index14 { get; set; }
        [BsonElement("15")]
        public string Index15 { get; set; }
        [BsonElement("16")]
        public string Index16 { get; set; }
        [BsonElement("17")]
        public string Index17 { get; set; }
        [BsonElement("18")]
        public string Index18 { get; set; }
        [BsonElement("19")]
        public string Index19 { get; set; }
        [BsonElement("20")]
        public string Index20 { get; set; }
        [BsonElement("21")]
        public string Index21 { get; set; }
        [BsonElement("22")]
        public string Index22 { get; set; }
        [BsonElement("23")]
        public string Index23 { get; set; }
        [BsonElement("24")]
        public string Index24 { get; set; }
        [BsonElement("25")]
        public string Index25 { get; set; }
        [BsonElement("26")]
        public string Index26 { get; set; }
        [BsonElement("27")]
        public string Index27 { get; set; }
        [BsonElement("28")]
        public string Index28 { get; set; }
        [BsonElement("29")]
        public string Index29 { get; set; }

    }
    public class CreatedTimeCollections
    {
        [BsonElement("0")]
        public string Index0 { get; set; }
        [BsonElement("1")]
        public string Index1 { get; set; }
        [BsonElement("2")]
        public string Index2 { get; set; }
        [BsonElement("3")]
        public string Index3 { get; set; }
        [BsonElement("4")]
        public string Index4 { get; set; }
        [BsonElement("5")]
        public string Index5 { get; set; }
        [BsonElement("6")]
        public string Index6 { get; set; }
        [BsonElement("7")]
        public string Index7 { get; set; }
        [BsonElement("8")]
        public string Index8 { get; set; }
        [BsonElement("9")]
        public string Index9 { get; set; }
        [BsonElement("10")]
        public string Index10 { get; set; }
        [BsonElement("11")]
        public string Index11
        {
            get; set;
        }
        [BsonElement("12")]
        public string Index12 { get; set; }
        [BsonElement("13")]
        public string Index13 { get; set; }
        [BsonElement("14")]
        public string Index14 { get; set; }
        [BsonElement("15")]
        public string Index15 { get; set; }
        [BsonElement("16")]
        public string Index16 { get; set; }
        [BsonElement("17")]
        public string Index17 { get; set; }
        [BsonElement("18")]
        public string Index18 { get; set; }
        [BsonElement("19")]
        public string Index19 { get; set; }
        [BsonElement("20")]
        public string Index20 { get; set; }
        [BsonElement("21")]
        public string Index21 { get; set; }
        [BsonElement("22")]
        public string Index22 { get; set; }
        [BsonElement("23")]
        public string Index23 { get; set; }
        [BsonElement("24")]
        public string Index24 { get; set; }
        [BsonElement("25")]
        public string Index25 { get; set; }
        [BsonElement("26")]
        public string Index26 { get; set; }
        [BsonElement("27")]
        public string Index27 { get; set; }
        [BsonElement("28")]
        public string Index28 { get; set; }
        [BsonElement("29")]
        public string Index29 { get; set; }

    }
}