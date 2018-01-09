namespace OWLeagueLib.Models {
    public class TeamStanding {
        public string AbbreviatedDivision { get; set; }
        public string AbbreviatedName { get; set; }
        public string Icon { get; set; }
        public string ID { get; set; }
        public bool IsDivisionLeader { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int OwlDivision { get; set; }
        public int Rank { get; set; }
        public StandingScores Standings { get; set; }
    }

    public class StandingScores {
        public int Gb { get; set; }
        public int Losses { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
    }
}