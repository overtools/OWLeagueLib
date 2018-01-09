using System;
using System.Linq;

namespace OWLeagueLib.Models {
    public class ScheduleResponse {
        public Schedule Data { get; set; }

        /// <summary>
        /// Get stage by name
        /// </summary>
        public Stage GetStage(string name) {
            foreach (Stage stage in Data.Stages) {
                if (stage.Name == name) return stage;
            }
            return null;
        }
        
        /// <summary>
        /// Get the next stage
        /// </summary>
        public Stage GetNextStage() {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            foreach (Stage stage in Data.Stages) {
                if (stage.Matches.Count == 0) continue;
                long stageLowerBound = stage.GetAllMatches().Select(x => x.StartDateTS).Min();
                if (now < stageLowerBound) return stage;
            }
            return null;
        }
        
        /// <summary>
        /// Get the current stage
        /// </summary>
        public Stage GetCurrentStage() {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            foreach (Stage stage in Data.Stages) {
                if (stage.Matches.Count == 0) continue;
                long stageLowerBound = stage.GetAllMatches().Select(x => x.StartDateTS).Min();
                long stageUpperBound = stage.GetAllMatches().Select(x => x.EndDateTS).Max();
                if (now >= stageLowerBound && stageUpperBound > now) return stage;
            }
            return null;
        }
        
        /// <summary>
        /// Get stage by id
        /// </summary>
        public Stage GetStage(long id) {
            foreach (Stage stage in Data.Stages) {
                if (stage.ID == id) return stage;
            }
            return null;
        }
    }
}