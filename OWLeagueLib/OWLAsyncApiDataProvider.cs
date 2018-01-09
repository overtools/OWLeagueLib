using System.Threading.Tasks;
using OWLeagueLib.Models;
using RestSharp;

namespace OWLeagueLib {
    /// <summary>
    /// Main class for accessing the Overwatch League web API
    /// </summary>
    public class OWLAsyncApiDataProvider : IOWLAsyncDataProvider {
        protected RestClient Client;
        
        // todo: locale, pagination

        /// <param name="uri">The API's URI</param>
        public OWLAsyncApiDataProvider(string uri="https://api.overwatchleague.com/") {
            Client = new RestClient(uri);
        }

        // RestClient helper
        /// <summary>
        /// Wrapper around ExecuteAsync to use C# spec
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        protected Task<IRestResponse<T>> ExecuteAsync<T>(IRestRequest request) where T : new() {
            TaskCompletionSource<IRestResponse<T>> tcs = new TaskCompletionSource<IRestResponse<T>>();

            Client.ExecuteAsync<T>(request, response => { tcs.SetResult(response); });

            return tcs.Task;
        }
        
        // Internal helpers
        /// <summary>
        /// Fetches the request and returns a deserialized class.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        protected async Task<T> ExecuteRequest<T>(string endpoint, Method method = Method.GET) where T : new() {
            RestRequest request = new RestRequest(endpoint, method);
            IRestResponse<T> response = await ExecuteAsync<T>(request);
            return response.Data;
        }
        
        // Public calls
        /// <summary>
        /// Fetches the web app info
        /// </summary>
        public async Task<AppData> FetchAppData() {
            return await ExecuteRequest<AppData>("about");
        }

        /// <summary>
        /// Fetches the current schedule
        /// </summary>
        public async Task<ScheduleResponse> FetchSchedule() {
            return await ExecuteRequest<ScheduleResponse>("schedule");
        }

        /// <summary>
        /// Fetches current live stream
        /// </summary>
        public async Task<LiveStream> FetchLiveStream() {
            return await ExecuteRequest<LiveStream>("streams");
        }
        
        /// <summary>
        /// Fetches the match with the id of <paramref name="id"/>
        /// </summary>
        /// <param name="id">The match id.</param>
        public async Task<Match> FetchMatch(long id) {
            return await ExecuteRequest<Match>($"match/{id}");
        }

        /// <summary>
        /// Fetches the team with the id of <paramref name="id"/>
        /// </summary>
        /// <param name="id">The team id.</param>
        public async Task<TeamDetail> FetchTeam(long id) {
            return await ExecuteRequest<TeamDetail>($"team/{id}");
        }

        /// <summary>
        /// Fetches the latest site news
        /// </summary>
        public async Task<News> FetchNews() {
            return await ExecuteRequest<News>("news");
        }

        /// <summary>
        /// Fetches the playlist with the name of <paramref name="name"/>
        /// </summary>
        public async Task<PlaylistVideosResponse> FetchPlaylistVideos(string name="owl-app-playlist") {  // todo: are we the app?
            return await ExecuteRequest<PlaylistVideosResponse>($"playlist/{name}");
        }

        /// <summary>
        /// Fetches team rankings (games won, games lost, etc)
        /// </summary>
        public async Task<RankingResponse> FetchRanking() {
            return await ExecuteRequest<RankingResponse>("ranking");
        }

        /// <summary>
        /// Fetches team standings (division info, player info, etc)
        /// </summary>
        public async Task<StandingsResponse> FetchStandings() {
            return await ExecuteRequest<StandingsResponse>("standings");
        }

        /// <summary>
        /// Fetches VODs
        /// </summary>
        public async Task<VideosResponse> FetchVideos() {
            return await ExecuteRequest<VideosResponse>("vods");
        }
    }
}
