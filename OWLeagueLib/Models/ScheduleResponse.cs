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