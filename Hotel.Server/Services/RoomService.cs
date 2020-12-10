using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Hotel.Server.Interfaces;
using Hotel.Server.Models;
using MongoDB.Bson;

namespace Hotel.Server.Services
{
    public class RoomService
    {
        private readonly IMongoCollection<RoomModel> _room;

        public RoomService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.Connectionstring);
            var database = client.GetDatabase(settings.DatabaseName);
            _room = database.GetCollection<RoomModel>("Rooms");
        }

        public List<RoomModel> Find() => _room.Find(new BsonDocument()).ToList();
    }
}
