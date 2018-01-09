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
}