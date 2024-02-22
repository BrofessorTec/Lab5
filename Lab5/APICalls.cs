using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab5
{
    internal class APICalls
    {



        public static async Task GetPlayerProfile(string apiUrl)
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

    }

    
}
