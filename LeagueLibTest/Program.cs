using System.Threading.Tasks;
using OWLeagueLib;
using OWLeagueLib.Models;

namespace LeagueLibTest {
    internal class Program {
        public static async Task Main(string[] args) {
            // OWLApiDataProvider provider = new OWLApiDataProvider();

            // AppData appData = provider.FetchAppData();
            // ScheduleResponse scheduleResponse = provider.FetchSchedule();
            // LiveStream liveStream = provider.FetchLiveStream();
            // Match match = provider.FetchMatch(10525);
            // TeamDetail team = provider.FetchTeam(4402);
            // News news = provider.FetchNews();
            // PlaylistVideosResponse playlistVideosResponse = provider.FetchPlaylistVideos();
            // RankingResponse rankingResponse = provider.FetchRanking();
            // StandingsResponse standingsResponse = provider.FetchStandings();
            // VideosResponse videosResponse = provider.FetchVideos();
            
            OWLAsyncApiDataProvider asyncProvider = new OWLAsyncApiDataProvider();
            ScheduleResponse scheduleResponseAsync = await asyncProvider.FetchSchedule();
        }
    }
}