using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CabinBookingApp
{
    public class Cabin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string address { get; set; }
        public int size { get; set; }
        public string owner { get; set; }
        public bool sauna { get; set; }
        public bool beach { get; set; }
        public int __v { get; set; }
    }
}
