using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Server.Models
{
    public class RoomModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public int Beds { get; set; }

        public int DoubleBeds { get; set; }

        public bool IsCondo { get; set; }

        public bool IsSuite { get; set; }

        public bool Smoking { get; set; }

        public bool Pets { get; set; }
    }
}
