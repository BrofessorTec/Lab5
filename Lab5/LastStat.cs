using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class LastStat
    {
        public int Rating {  get; set; }
        public int Date { get; set; }
        public int Rd { get; set; }

        public LastStat(int rating, int date, int rd)
        {
            this.Rating = rating;
            this.Date = date;
            this.Rd = rd;
        }
    }
}
