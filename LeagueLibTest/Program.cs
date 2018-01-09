using OWLeagueLib;
using OWLeagueLib.Models;

namespace LeagueLibTest {
    internal class Program {
        public static void Main(string[] args) {
            OWLApiDataProvider provider = new OWLApiDataProvider();

            // AppData appData = provider.FetchAppData();
            ScheduleResponse scheduleResponse = provider.FetchSchedule();
            // LiveStream liveStream = provider.FetchLiveStream();
            // Match match = provider.FetchMatch(10525);
            // TeamDetail team = provider.FetchTeam(4402);
            // News news = provider.FetchNews();
            // PlaylistVideosResponse playlistVideosResponse = provider.FetchPlaylistVideos();
            // RankingResponse rankingResponse = provider.FetchRanking();
            // StandingsResponse standingsResponse = provider.FetchStandings();
            // VideosResponse videosResponse = provider.FetchVideos();
        }
    }
}