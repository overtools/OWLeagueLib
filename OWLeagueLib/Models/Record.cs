namespace OWLeagueLib.Models {
    public class Record {
        public int GameLoss { get; set; }
        public int GamePointsAgainst { get; set; }
        public int GamePointsFor { get; set; }
        public int GameTie { get; set; }
        public int GameWin { get; set; }
        public int MatchDraw { get; set; }
        public int MatchLoss { get; set; }
        public int MatchWin { get; set; }
        public string Streak { get; set; }
    }
}