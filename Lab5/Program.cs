using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab5
{
    internal class Program
    {

        public static async Task GetTask(string apiUrl)
        {
            HttpClient httpClient = new HttpClient();
                try
                {
                    // Make a GET request using the url
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    // Check response as a string
                string responseData = await response.Content.ReadAsStringAsync();

                await Console.Out.WriteLineAsync(responseData);  //this is a debugging check

                // Process the data but a string[] does not seem to be working
                string[] info = JsonSerializer.Deserialize<string[]>(responseData);

                    /*foreach (string s in info)
                    {
                    await Console.Out.WriteLineAsync(s);
                    }*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
        }

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Chess Battler!" +
                    "\n1) If you have a Chess.com profile you can enter your user name here." +
                    "\n2) Otherwise, you can enter your chess rating here." +
                    "\n Please enter your choice of 1 or 2: ");
                //string choice = Console.ReadLine().ToLower();
                string choiceNum = Console.ReadLine();


                // if a rating is entered:
                if (choiceNum == "1")
                {
                    Console.Clear();
                    Console.WriteLine("What rating would you like to use?");
                    int choiceRating = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your rating is {choiceRating}.");
                }
                else if (choiceNum == "2")
                {
                    // if a profile string is entered
                    // use player profile here
                    // GET playerprofile/{choice}
                    /*string choiceString = choice[0].ToString().ToUpper();
                    for (int i = 1; i < choice.Length; i++)
                    {
                        choiceString += choice[i];
                    }*/



                    // example url with player name "erik"
                    // https://api.chess.com/pub/player/erik
                    /*
                    URL pattern: https://api.chess.com/pub/player/{username}
                    Data format:

                    {
                        "@id": "URL", // the location of this profile (always self-referencing)
                        "url": "URL", // the chess.com user's profile page (the username is displayed with the original letter case)
                        "username": "string", // the username of this player
                        "player_id": 41, // the non-changing Chess.com ID of this player
                         "title": "string", // (optional) abbreviation of chess title, if any
                         "status": "string", // account status: closed, closed:fair_play_violations, basic, premium, mod, staff
                          "name": "string", // (optional) the personal first and last name
                        "avatar": "URL", // (optional) URL of a 200x200 image
                         "location": "string", // (optional) the city or location
                         "country": "URL", // API location of this player's country's profile
                         "joined": 1178556600, // timestamp of registration on Chess.com
                         "last_online": 1500661803, // timestamp of the most recent login
                         "followers": 17 // the number of players tracking this player's activity
                         "is_streamer": "boolean", //if the member is a Chess.com streamer
                         "twitch_url": "Twitch.tv URL",
                         "fide": "integer" // FIDE rating 
                    } */


                    Console.Clear();
                    Console.WriteLine("What is your profile name?");
                    string choiceProfile = Console.ReadLine();
                    Console.WriteLine($"Your profile name is {choiceProfile}");


                    // url code here
                    string apiUrl = $"https://api.chess.com/pub/player/{choiceProfile}";
                    Console.WriteLine("Your url is: " + apiUrl);

                    GetTask(apiUrl);
                    Console.ReadLine();


                    // testing with a new API call for all players with a certain title i.e. GM
                    GetTask("https://api.chess.com/pub/titled/GM");
                    Console.ReadLine();

                    //APICalls apiCall = new APICalls();

                    // cannot access the async task in this class..?

                    //apiCall



                    // get the player's rating here


                }
                else
                {
                    break;
                }


                // get a list of players that are within a range of the players rating

                // pick a random player in this list to be the opponent




            }
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
