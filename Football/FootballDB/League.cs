namespace FootballDB
{
    public class League
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<Team> Teams { get; set; }

        //top scorers
    }
}
