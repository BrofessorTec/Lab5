README - Using this as a tracker for difficulties during this project <br>
Originally planned on using a Lost Ark api, after doing a lot of planning I learned that the API was no longer being hosted so I was not able to use any of the GETs.. <br>
Redireted my attention to the Chess.com API<br>
On first attempts to GET data from the Chess API I am getting "forbidden" error responses<br>
Tried to create an async task to perform this GET because it looked like it was having an issue running it from Main, but this was also not working<br>
Moved this code to an async task and called it from main, and this looks like the code is organized better, but still getting forbidden response :(<br>
I think some of this issue is caused from me trying to use a trycatch incorrectly. Will refactor this.<br>
Made some progress, but the output is still not in the format that I expected so I am not getting managable data returned.<br>
Having an issue where the "await" is needed but my main is not an async task, might need to break this into a class?<br>
It looks like the main issue is that I am getting JSON response when I enter it in a browser, but getting HTML response data when I try it from the program and not sure how to reformat this.<br>
Trying a different API GET call for players with a certain title looks like it is returning JSON data correctly, but the main call I wanted to use is still causing an Exception that I do not understand. <br>
