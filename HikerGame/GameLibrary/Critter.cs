using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Critter : Character
    {

        public string CritterDescription { get; set; }
        public int PointsToScore { get; set; }
        public int PointsToLose { get; set; }
        public bool DoesItBite { get; set; }

        public Critter() { }

        public Critter(string name, int hitChance, int block, int pointsToScore, int pointsToLose,
            string critterDescription, bool doesItBite)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            PointsToScore = pointsToScore;
            PointsToLose = pointsToLose;
            CritterDescription = critterDescription;
            DoesItBite = doesItBite;

        }
        public override string ToString()
        {
            return string.Format("Looks like we have a {0}.\n\n{1}\n\n",
                Name,
                CritterDescription
                );
        }
    }
}
