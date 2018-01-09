# OWLeagueLib - library for interacting with the Overwatch League web API


### License: MIT
----
### Basic usage:
```
// Create the root object
OWLApiDataProvider provider = new OWLApiDataProvider();

// Get the data that you need, in a nice deserialised object.
ScheduleResponse scheduleResponse = provider.FetchSchedule();
```

### Requirements
* RestSharp


### Changelog
* 09-Jan-2018: First release.


### Future
* Locale support.
* Pagination support.
