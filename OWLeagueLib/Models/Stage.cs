using System;
using System.Collections.Generic;
using System.Linq;

namespace OWLeagueLib.Models {
    public class Stage {
        public bool Enabled { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public List<StageMatch> Matches { get; set; }

        /// <summary>
        /// Get all matches
        /// </summary>
        public IEnumerable<StageMatch> GetAllMatches() {
            foreach (StageMatch match in Matches.OrderBy(x => x.StartDateTS)) {
                if (match.StartDateTS == 0) continue;
                yield return match;
            }
        }
        
        /// <summary>
        /// Get the next match to start
        /// </summary>
        public StageMatch GetNextMatch() {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            return Matches.OrderBy(x => x.StartDateTS).FirstOrDefault(match => now < match.StartDateTS && match.StartDateTS != 0);
        }
        
        /// <summary>
        /// Get the currently running match
        /// </summary>
        public StageMatch GetCurrentMatch() {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            return Matches.OrderBy(x => x.StartDateTS).FirstOrDefault(match => now >= match.StartDateTS && now < match.EndDateTS);
        }
    }
}