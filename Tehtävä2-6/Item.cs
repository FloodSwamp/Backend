namespace Tehtävä2
{
    public class Item
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        [Range(1, 99)]
        public int Level {get; set;}

        [TypeValidator] 
        public string type {get;set;}

        [DateValidator]
        public DateTime CreationDate { get; set; }
    }
}