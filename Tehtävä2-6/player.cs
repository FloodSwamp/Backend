using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Tehtävä2
{
    public class Player
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsBanned { get; set; }
        public DateTime CreationTime { get; set; }
        public List <Item> items { get; set; }
    }
}