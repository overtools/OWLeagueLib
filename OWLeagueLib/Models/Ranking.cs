using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class Ranking {
        public Competitor Competitor { get; set; }
        public int Placement { get; set; }
        public List<Record> Records { get; set; }
    }
}