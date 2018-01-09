using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class Competitor {
        public string AbbreviatedName { get; set; }
        public string Game { get; set; }
        public long ID { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public string Handle { get; set; }
        public string AttributesVersion { get; set; }
        public string Icon { get; set; }
        public string AddressCountry { get; set; }
        public string SecondaryPhoto { get; set; }
        public string Type { get; set; }
        public List<CompetitorPlayerTeamPair> Players { get; set; }
        public TeamAttributes Attributes { get; set; }
    }

    public class TeamAttributes {
        public string City { get; set; }
        public string HeroImage { get; set; }
        public string Manager { get; set; }
        public string TeamGUID { get; set; }
    }

    public class CompetitorPlayerTeamInfo {
        public string Type { get; set; }
        public long ID { get; set; }
    }

    public class CompetitorPlayerTeamPair {
        public CompetitorPlayerTeamInfo Team { get; set; }
        public CompetitorTeamPlayer Player { get; set; }
    }

    public class CompetitorTeamPlayer {
        public long ID { get; set; }
        public List<string> AvailableLanguages { get; set; }
        public string Handle { get; set; }
        public string Name { get; set; }
        public string HomeLocation { get; set; }
        public string Game { get; set; }
        public string AttributesVersion { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string Nationality { get; set; }
        public string Headshot { get; set; }
        public string Type { get; set; }
        public CompetitorTeamPlayerAttributes Attributes { get; set; }
    }

    public class CompetitorTeamPlayerAttributes {
        public string HeroImage { get; set; }
        public string Hometown { get; set; }
        public long PlayerNumber { get; set; }
        public string PreferredSlot { get; set; }
        public string Role { get; set; }
        public List<string> Heroes { get; set; }
    }
}