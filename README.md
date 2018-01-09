# OWLeagueLib - a library for interacting with the Overwatch League web API


### License: MIT
----
### Providers:
There are currently two data providers that you can switch out based on your needs. One for async, and one for synchronous code.
```
OWLApiDataProvider
OWLAsyncApiDataProvider
```
### Basic usage:
```
// Create the provider
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
