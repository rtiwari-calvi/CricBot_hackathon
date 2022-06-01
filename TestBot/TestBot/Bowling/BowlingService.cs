using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBot.Bowling
{
    public class BowlingService
    {
        public static BallModel getBowlingData()
        {
            return getRandomBowling();
        }

        private static BallModel getRandomBowling()
        {
            IDictionary<BowlingConfig, BallModel> allBowlingConfig= new Dictionary<BowlingConfig, BallModel>();
            allBowlingConfig.Add(BowlingConfig.RAF_Inswinger, getBallData(BowlerTypes.RAF, BowlingType.Inswingers, 160, BallPitchZone.zone2));
            allBowlingConfig.Add(BowlingConfig.RAF_Bouncer, getBallData(BowlerTypes.RAF, BowlingType.Bouncer, 140, BallPitchZone.zone1));
            allBowlingConfig.Add(BowlingConfig.RAF_Outswinger, getBallData(BowlerTypes.RAF, BowlingType.Outswinger, 150, BallPitchZone.zone2));
            allBowlingConfig.Add(BowlingConfig.RAS_LegBreak, getBallData(BowlerTypes.RAS, BowlingType.LegBreak, 90, BallPitchZone.zone2));
            allBowlingConfig.Add(BowlingConfig.RAS_Googly, getBallData(BowlerTypes.RAS, BowlingType.Googly, 90, BallPitchZone.zone1));
            allBowlingConfig.Add(BowlingConfig.RAS_OffBreak, getBallData(BowlerTypes.RAS, BowlingType.OffBreak, 150, BallPitchZone.zone2));

            return allBowlingConfig[getRandom()];

        }

        private static BowlingConfig getRandom()
        {
            Array values = Enum.GetValues(typeof(BowlingConfig));
            Random random = new Random();
            return (BowlingConfig)values.GetValue(random.Next(values.Length));
        }

        private static BallModel getBallData(BowlerTypes bowlerType, BowlingType bowlingType,int speed, BallPitchZone pitchZone)
        {
            return new BallModel
            {
                bowlerType = bowlerType,
                bowingType = bowlingType,
                bowlerName = "Sachin",              
                speed = speed,
                zone = pitchZone
            };
        }
    }
}
