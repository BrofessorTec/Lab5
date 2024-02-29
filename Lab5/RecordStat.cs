﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class RecordStat
    {
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Draw { get; set; }

        public RecordStat(int win, int loss, int draw)
        {
            this.Win = win;
            this.Loss = loss;
            this.Draw = draw;
        }

    }
}
