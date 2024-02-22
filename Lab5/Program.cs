using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

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


                    Console.Clear();
                    Console.WriteLine("What is your profile name?");
                    string choiceProfile = Console.ReadLine();
                    Console.WriteLine($"Your profile name is {choiceProfile}");


                    // url code here
                    string apiUrl = $"https://api.chess.com/pub/player/{choiceProfile}";

                    GetTask(apiUrl);
                    Console.ReadLine();


                    APICalls apiCall = new APICalls();

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
