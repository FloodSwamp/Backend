namespace Tehtävä2
{
    public class NewItem
    {
        public string Name { get; set; }

        [Range(1, 99)]
        public int Level {get;set;}

        [TypeValidator]
        public string Type {get;set;}


        [DateValidator]
        [DataType(DataType.Date)]
        public DateTime CreationDate {get;set;}
    }
}