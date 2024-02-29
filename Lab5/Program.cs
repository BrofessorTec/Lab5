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
        static async Task Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Chess Battler!" +
                    "\nPlease enter a title and let two players battle for victory." + 
                    "\nGM" +
                    "\nWGM" +
                    "\nIM" +
                    "\nWIM" +
                    "\nFM" +
                    "\nWFM" +
                    "\nNM" +
                    "\nWNM" +
                     "\nCM" +
                     "\nWCM" +
                    "\nq) Quit." +
                    "\n Please enter your choice here: ");
                //string choice = Console.ReadLine().ToLower();
                string choice = Console.ReadLine();
                try
                {
                    if (choice == "q")
                    {
                        exit = true;
                    }
                    else if (choice != "q")
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


                        APICalls apiCall = new APICalls();

                        Console.Clear();

                        /* this code is not working as of now
    Console.WriteLine("What is your profile name?");
    string choiceProfile = Console.ReadLine().ToLower();
    Console.WriteLine($"Your profile name is {choiceProfile}");


    // url code here
    string apiUrl1 = $"https://api.chess.com/pub/player/{choiceProfile}";
    Console.WriteLine("Your url is: " + apiUrl1);


    Task<Player> playerInfo= apiCall.GetPlayerProfile(apiUrl1);

    Player player = await playerInfo;
    await Console.Out.WriteLineAsync($"Player username is {player.Name}");
    */

                        // another example url for player profile is 
                        // https://api.chess.com/pub/player/hikaru


                        //GetTask(apiUrl);
                        //string[] info = await GetTask(apiUrl);

                        //Console.ReadLine();


                        // testing with a new API call for all players with a certain title i.e. GM
                        //GetTask("https://api.chess.com/pub/titled/GM");
                        //Console.ReadLine();

            

                        Task<string[]> callResult = apiCall.GetTitledPlayers($"https://api.chess.com/pub/titled/{choice}");
                        string[] titledPlayers = await callResult;
                        //Player playerInfo = apiCall.GetPlayerProfile(apiUrl);
                        // cannot access the async task in this class..?

                        //apiCall

                        /*foreach (string s in titledPlayers)
                        {
                            Console.WriteLine(s);
                        }

                        Console.ReadLine();
                        */

                        // pick 2 titled players and display their rating

                        Random random = new Random();
                        int player1 = random.Next(0, titledPlayers.Length);
                        int player2 = random.Next(0, titledPlayers.Length);
                        while (player1 == player2)
                        {
                            player2 = random.Next(0, titledPlayers.Length);
                        }

                        string player1Spot = titledPlayers[player1];
                        string player2Spot = titledPlayers[player2];

                        Console.Clear();
                        Console.WriteLine($"There are {titledPlayers.Length} {choice.ToUpper()} players!");
                        Console.WriteLine($"The match will be between {player1Spot} and {player2Spot}!");
                        Thread.Sleep(1000);
                        Console.WriteLine("\nAnd the winner is.....");
                        Thread.Sleep(1500);
                        if (choice.ToUpper() == "GM")
                        {
                            if(player1Spot == "magnuscarlsen")
                        {
                                Console.WriteLine($"{player1Spot}!!!!");
                            }
                            else if (player1Spot == "magnuscarlsen")
                            {
                                Console.WriteLine($"{player2Spot}!!!!");
                            }
                            else if (random.Next(2) == 0)
                            {
                                Console.WriteLine($"{player1Spot}!!!!");
                            }
                            else
                            {
                                Console.WriteLine($"{player2Spot}!!!!");
                            }
                        }
                        else if (random.Next(2) == 0)
                        {
                            Console.WriteLine($"{player1Spot}!!!!");
                        }
                        else
                        {
                            Console.WriteLine($"{player2Spot}!!!!");
                        }

                        Console.WriteLine("\nEnter any key to play again.");
                        Console.ReadLine();


                        /*  This request was also forbidden. Included an error picture into the github files now :(
                        Task<int> callPlayer1Rating = apiCall.GetPlayerRating($"https://api.chess.com/pub/player/{player1Spot}/stats");
                        int player1Rating = await callPlayer1Rating;
                        Task<int> callPlayer2Rating = apiCall.GetPlayerRating($"https://api.chess.com/pub/player/{player2Spot}/stats");
                        int player2Rating = await callPlayer2Rating;
                        Console.WriteLine($"The match will be between {player1Spot} rated {player1Rating}and {player2Spot} rated {player2Rating}!");
                        */


                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("This was not a valid entry. Enter any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
            Console.WriteLine("End of program. Thanks for using!");
            Console.ReadLine();
        }
    }
}
