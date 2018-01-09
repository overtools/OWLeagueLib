using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class StandingsResponse {
        public List<OwlDivision> OwlDivisions { get; set; }
        public Dictionary<string, int> PlayoffSeparators { get; set; }
        public Season Season { get; set; }
        public List<StandingsStage> Stages { get; set; }
        public Dictionary<string, string> Strings { get; set; }
    }

    public class Season {
        public Dictionary<string, List<TeamStanding>> Division { get; set; }
        public Dictionary<string, List<TeamStanding>> Wildcard { get; set; }
    }

    public class OwlDivision {
        public string Abbrev { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string String { get; set; }
    }
}