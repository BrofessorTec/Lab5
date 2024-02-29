using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class BestStat
    {
        public int Rating { get; set; }
        public int Date { get; set; }
        public string Game { get; set; } //really this is a url

        public BestStat(int rating, int date, string game)
        {
            this.Rating = rating;
            this.Date = date;
            this.Game = game;
        }
    }
}
