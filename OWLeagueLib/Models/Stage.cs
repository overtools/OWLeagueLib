using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class Stage {
        public bool Enabled { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public List<StageMatch> Matches { get; set; }
    }
}