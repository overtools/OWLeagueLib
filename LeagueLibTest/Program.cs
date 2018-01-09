using System;
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
            
            // OWLAsyncApiDataProvider asyncProvider = new OWLAsyncApiDataProvider();
            // ScheduleResponse scheduleResponseAsync = await asyncProvider.FetchSchedule();
            
            // await DemoGetMatch();
            await DemoGetStage();
        }

        public static async Task DemoGetStage() {
            // create provider
            OWLAsyncApiDataProvider asyncProvider = new OWLAsyncApiDataProvider();
            
            // get schedule object
            ScheduleResponse schedule = await asyncProvider.FetchSchedule();

            // get next stage
            Stage stage = schedule.GetNextStage();
            
            Console.Out.WriteLine($"The next stage of the current OWL season is: {stage.Name}");
        }

        public static async Task DemoGetMatch() {
            // create provider
            OWLAsyncApiDataProvider asyncProvider = new OWLAsyncApiDataProvider();
            
            // get schedule object
            ScheduleResponse schedule = await asyncProvider.FetchSchedule();

            // get the stage using the name, index/id can also be used
            Stage stage = schedule.GetStage("Stage 1");
            
            // get the next match in this stage
            StageMatch nextMatch = stage.GetNextMatch();
            
            Console.Out.WriteLine($"Next match is: {nextMatch.Team1.Name} vs {nextMatch.Team2.Name} at {nextMatch.StartDateTimeOffset()}");
        }
    }
}