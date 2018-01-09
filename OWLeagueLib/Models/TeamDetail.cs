using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class TeamDetail {
        public string AboutUrl { get; set; }
        public TeamAttributes Attributes { get; set; }
        public int Placement { get; set; }
        public List<TeamDetailPlayer> Players { get; set; }
        public Record Ranking { get; set; }
        public List<Match> Schedule { get; set; }
    }

    public class TeamDetailPlayer {
        public long ID { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public string Handle { get; set; }
        public string Name { get; set; }
        public string Homelocation { get; set; }
        public string Game { get; set; }
        public TeamDetailPlayerAttributes Attributes { get; set; }
        public string AttributesVersion { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string Nationality { get; set; }
        public string Headshot { get; set; } // (mugshot)
        public string Type { get; set; }
        public string AboutUrl { get; set; }
    }

    public class TeamDetailPlayerAttributes {
        public string Hometown { get; set; }
        public long PlayerNumber { get; set; }
        public string PreferredSlot { get; set; }
        public string Role { get; set; }
        public string HeroImage { get; set; }
        public List<TeamDetailPlayerHero> Heroes { get; set; }
    }

    public class TeamDetailPlayerHero {
        public string Name { get; set; }
        public Dictionary<string, string> Icons { get; set; }
    }
}