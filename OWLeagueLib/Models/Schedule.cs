using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class Schedule {
        public string EndDate { get; set; }
        public string StartDate { get; set; }
        public List<Stage> Stages { get; set; }
    }
}