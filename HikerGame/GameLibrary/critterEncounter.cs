using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class CritterEncounter
    {
        public static void critterMeeting(Player player, Critter theCritter)
        {
            ;
            Random rand = new Random();

            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(30);

            if (diceRoll < theCritter.Block)
            {
                player.GameScore -= diceRoll;
                Console.WriteLine("You got too close and lost {0} points!", diceRoll);

            }
            if (theCritter.DoesItBite == true)
            {
                Console.WriteLine($"\nThat {theCritter.Name} wasn't very nice. You lost {theCritter.PointsToLose} life. Your total life is {player.Life - theCritter.PointsToLose}. ");
                player.Life -= theCritter.PointsToLose;

            }

            else
            {
                player.GameScore += diceRoll;
                Console.WriteLine("You had a wonderful nature experience and won {0} points!", diceRoll);
            }





        }
    }
}
