# OWLeagueLib - a library for interacting with the Overwatch League web API


### License: MIT
----
### Providers:
There are currently two data providers that you can switch out based on your needs. One for async, and one for synchronous code.
```
OWLApiDataProvider
OWLAsyncApiDataProvider
```
### Usage:
#### Basic
```
// Create the provider
OWLApiDataProvider provider = new OWLApiDataProvider();

// Get the data that you need, in a nice deserialised object.
ScheduleResponse scheduleResponse = provider.FetchSchedule();
```

#### Getting next match (using async)
```
// create provider
OWLAsyncApiDataProvider asyncProvider = new OWLAsyncApiDataProvider();
            
// get schedule object
ScheduleResponse schedule = await asyncProvider.FetchSchedule();

// get the stage using the name, index/id can also be used
Stage stage = schedule.GetStage("Stage 1");
            
// get the next match in this stage
StageMatch nextMatch = stage.GetNextMatch();
            
Console.Out.WriteLine($"Next match is: {nextMatch.Team1.Name} vs {nextMatch.Team2.Name} at {nextMatch.StartDateTimeOffset()}");
```

### Requirements
* RestSharp


### Changelog
* 09-Jan-2018: First release.


### Future
* Locale support.
* Pagination support.
