using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class StandingsStage {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<TeamStanding> Teams { get; set; }
    }
}