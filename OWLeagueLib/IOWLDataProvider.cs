using System.Threading.Tasks;
using OWLeagueLib.Models;

namespace OWLeagueLib {
    public interface IOWLDataProvider {
        AppData FetchAppData();
        ScheduleResponse FetchSchedule();
        LiveStream FetchLiveStream();
        Match FetchMatch(long id);
        TeamDetail FetchTeam(long id);
        News FetchNews();
        PlaylistVideosResponse FetchPlaylistVideos(string name);
        RankingResponse FetchRanking();
        StandingsResponse FetchStandings();
        VideosResponse FetchVideos();
    }

    public interface IOWLAsyncDataProvider {
        Task<AppData> FetchAppData();
        Task<ScheduleResponse> FetchSchedule();
        Task<LiveStream> FetchLiveStream();
        Task<Match> FetchMatch(long id);
        Task<TeamDetail> FetchTeam(long id);
        Task<News> FetchNews();
        Task<PlaylistVideosResponse> FetchPlaylistVideos(string name);
        Task<RankingResponse> FetchRanking();
        Task<StandingsResponse> FetchStandings();
        Task<VideosResponse> FetchVideos();
    }
}
