namespace Tehtävä2
{
    public class newplayer
    {
        public string Name { get; set; }

        public newplayer(string playerName) {
            Name = playerName;
        }

        public static implicit operator newplayer(string player) {
            return new newplayer(player);
        }

        public string Tag {get;set;}
    }
}