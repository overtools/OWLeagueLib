using OWLeagueLib.Models;
using RestSharp;

namespace OWLeagueLib {
    /// <summary>
    /// Main class for accessing the Overwatch League web API
    /// </summary>
    public class OWLApiDataProvider : IOWLDataProvider {
        protected RestClient Client;
        
        // todo: locale, pagination

        /// <param name="uri">The API's URI</param>
        public OWLApiDataProvider(string uri="https://api.overwatchleague.com/") {
            Client = new RestClient(uri);
        }
        
        // Internal helpers
        /// <summary>
        /// Fetches the request and returns a deserialized class.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        protected T ExecuteRequest<T>(string endpoint, Method method = Method.GET) where T : new() {
            RestRequest request = new RestRequest(endpoint, method);
            IRestResponse<T> response = Client.Execute<T>(request);
            return response.Data;
        }
        
        // Public calls
        /// <summary>
        /// Fetches the web app info
        /// </summary>
        public AppData FetchAppData() {
            return ExecuteRequest<AppData>("about");
        }

        /// <summary>
        /// Fetches the current schedule
        /// </summary>
        public ScheduleResponse FetchSchedule() {
            return ExecuteRequest<ScheduleResponse>("schedule");
        }

        /// <summary>
        /// Fetches current live stream
        /// </summary>
        public LiveStream FetchLiveStream() {
            return ExecuteRequest<LiveStream>("streams");
        }
        
        /// <summary>
        /// Fetches the match with the id of <paramref name="id"/>
        /// </summary>
        /// <param name="id">The match id.</param>
        public Match FetchMatch(long id) {
            return ExecuteRequest<Match>($"match/{id}");
        }

        /// <summary>
        /// Fetches the team with the id of <paramref name="id"/>
        /// </summary>
        /// <param name="id">The team id.</param>
        public TeamDetail FetchTeam(long id) {
            return ExecuteRequest<TeamDetail>($"team/{id}");
        }

        /// <summary>
        /// Fetches the latest site news
        /// </summary>
        public News FetchNews() {
            return ExecuteRequest<News>("news");
        }

        /// <summary>
        /// Fetches the playlist with the name of <paramref name="name"/>
        /// </summary>
        public PlaylistVideosResponse FetchPlaylistVideos(string name="owl-app-playlist") {  // todo: are we the app?
            return ExecuteRequest<PlaylistVideosResponse>($"playlist/{name}");
        }

        /// <summary>
        /// Fetches team rankings (games won, games lost, etc)
        /// </summary>
        public RankingResponse FetchRanking() {
            return ExecuteRequest<RankingResponse>("ranking");
        }

        /// <summary>
        /// Fetches team standings (division info, player info, etc)
        /// </summary>
        public StandingsResponse FetchStandings() {
            return ExecuteRequest<StandingsResponse>("standings");
        }

        /// <summary>
        /// Fetches VODs
        /// </summary>
        public VideosResponse FetchVideos() {
            return ExecuteRequest<VideosResponse>("vods");
        }
    }
}