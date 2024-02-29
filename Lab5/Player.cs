using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Player : IComparable
    {

        /*
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
}
        */
        public int PlayerID { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Followers { get; set; }
        public string Country {  get; set; }
        public string Last_online { get; set; }
        public string Joined { get; set; }
        public string Status { get; set; }
        public string Is_streamer { get; set; }
        public string Verified { get; set; }
        public string League { get; set; }

        public Player(int playerID, string id, string url, string name, string username, string followers, string country, string last_online, string joined, string status, string is_streamer, string verified, string league)
        {
            this.PlayerID = playerID;
            this.Id = id;
            this.Url = url;
            this.Name = name;
            this.Username = username;
            this.Followers = followers;
            this.Country = country;
            this.Last_online = last_online;
            this.Joined = joined;
            this.Status = status;
            this.Is_streamer = is_streamer;
            this.Verified = verified;
            this.League = league;
        }

        public int GetRating()
        {
            // URL pattern: https://api.chess.com/pub/player/{username}/stats
            // from here grab the 
            return 0;
        }


        public int CompareTo(object? obj)
        {
            if (((Player)obj).GetRating() < GetRating())
            {
                // assuming true means you would beat them
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
