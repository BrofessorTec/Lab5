using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab5
{
    internal class APICalls
    {


        
        public async Task<Player> GetPlayerProfile(string apiUrl)
        {
            HttpClient httpClient = new HttpClient();
            // Make a GET request using the url
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            // Check response as a string
            string responseData = await response.Content.ReadAsStringAsync();

            //await Console.Out.WriteLineAsync(responseData);  //this is a debugging check

            // Process the data but a string[] does not seem to be working
            string[] info = JsonSerializer.Deserialize<string[]>(responseData);

            Player playerInfo = new Player(int.Parse(info[0]), info[1], info[2], info[3], info[4], info[5], info[6], info[7], info[8], info[9], info[10], info[11], info[12]);

            return playerInfo;
        }
    

        public async Task<String[]> GetTitledPlayers(string apiUrl)
        {
            HttpClient httpClient = new HttpClient();
            // Make a GET request using the url
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            // Check response as a string
            
            string responseData = await response.Content.ReadAsStringAsync();

            //await Console.Out.WriteLineAsync(responseData);  //this is a debugging check

            // Process the data but a string[] does not seem to be working
            //string[] titledPlayers = JsonSerializer.Deserialize<string[]>(responseData);
            string[] players;
            using (JsonDocument doc = JsonDocument.Parse(responseData))
            {
                JsonElement root = doc.RootElement;

                // Access the string[] directly
                JsonElement playersElement = root.GetProperty("players");
                players = playersElement.EnumerateArray().Select(e => e.GetString()).ToArray();

                // Display the result
                /*foreach (string player in players)
                {
                    Console.WriteLine(player);
                }*/
            }




            //string[] splitString = responseData.Split(',');

            return players;
        }

    }

    
}
