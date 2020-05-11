using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Challenger : Character
    {

        public string ChallengeDescription { get; set; }
        public int PointsToScore { get; set; }
        public int PointsToLose { get; set; }
        public bool WasBeaten { get; set; }

        public Challenger(){}

        public Challenger(string name, int hitChance, int block, int pointsToScore, int pointsToLose, 
            string challengeDescription, bool wasBeaten) 
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            PointsToScore = pointsToScore;
            PointsToLose = pointsToLose;
            ChallengeDescription = challengeDescription;
            WasBeaten = wasBeaten;

        }
        public override string ToString()
        {
            return string.Format("My name is {0}.\n\n{1}\n\n",
                Name, 
                ChallengeDescription
                );
        }



    }
}
