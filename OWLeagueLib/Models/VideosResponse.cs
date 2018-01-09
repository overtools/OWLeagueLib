using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class VideosResponse {
        public PlaylistVideosResponse.VideosMetadata Metadata { get; set; } =
            new PlaylistVideosResponse.VideosMetadata();

        public int Code { get; set; }
        public List<Vod> Data { get; set; }
        public string Status { get; set; }
    }
}