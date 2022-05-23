using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBot.Match
{
    public class MatchProgressModel
    {
        public bool isfieldingvalid { get; set; }
        public bool isballvalid { get; set; }
        public bool isshotvalid { get; set; }

        public bool iswicketlost { get; set; }

        public bool isMissed { get; set; }


        public int runonlastball { get; set; }

        public int totalruns { get; set; }

        public int totalwicketremaining { get; set; }

        public int totalballremaining { get; set; }

        public string OutReason { get; set; }
    }

    public static class outReasons
    {
        public static readonly string Catchout = "catch out";
        public static readonly string LBW = "LBW";
        public static readonly string bold = "Bold";
    }
}
