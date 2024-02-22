README - Using this as a tracker for difficulties during this project <br>
Originally planned on using a Lost Ark api, after doing a lot of planning I learned that the API was no longer being hosted so I was not able to use any of the GETs.. <br>
Redireted my attention to the Chess.com API
On first attempts to GET data from the Chess API I am getting "forbidden" error responses
Tried to create an async task to perform this GET because it looked like it was having an issue running it from Main, but this was also not working
Moved this code to an async task and called it from main, and this looks like the code is organized better, but still getting forbidden response :(
I think some of this issue is caused from me trying to use a trycatch incorrectly. Will refactor this.
