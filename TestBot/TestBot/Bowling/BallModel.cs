using System;
using System.Collections.Generic;
using System.Text;

namespace TestBot.Bowling
{
    public class BallModel
    {
        public BallPitchZone zone { get; set; }
        public BowlingType bowingType { get; set; }
        public BowlerTypes bowlerType { get; set; }

        public int speed { get; set; }

        public string bowlerName { get; set; }
    }
}
