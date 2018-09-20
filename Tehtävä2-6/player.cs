using System;

namespace Tehtävä2
{
    public class player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsBanned { get; set; }
        public DateTime CreationTime { get; set; }
        public List <Item> items { get; set; }
    }
}