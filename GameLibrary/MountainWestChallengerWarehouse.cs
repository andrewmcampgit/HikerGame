using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class MountainWestChallengerWarehouse
    {
        public static Challenger GetChallenger()
        {
            Random rand = new Random();

            Challenger c1 = new Challenger("Surfer Buzz", 50, 50, rand.Next(1, 100), rand.Next(10, 21),
                "Whats up bro??? Wasss Upppp? My names Buzz but you can call me dude Buzz. My friends and I " +
                "went surfing last night to catch some gnarly dusk waves and I lost my board out in the ocean. " +
                "Do you think you could help me find it? Press Enter to try!", false);
            Challenger c2 = new Challenger("Surfer Buzz's Buddy", 50, 50, rand.Next(1, 100), rand.Next(10, 21),
                "Whats up bro??? Wasss Upppp? I'm Buzz's friend and you can call me Buzz's friend. " +
                "I lost track track of my homeboy Buzz.\n\n " +
                "Do you think you could help me find him? Press Enter to try!", false);
            Challenger c3 = new Challenger("Actor George Flooney", 23, 70, rand.Next(1, 100), rand.Next(10, 21),
                "Hello there! I'm a famous celebrity.... maybe you've heard of me....Flooney.....George Flooney. I was renting out one of my hundreds of AirBnB's and lost the number to" +
                "my cleaning maid service. You look like a real go-getter. Do you think you could clean it before my next guests arrive? Press Enter to try? \n\n ", false);
            Challenger c4 = new Challenger("Activist Forest Rights Hiker", 23, 40, rand.Next(1, 100), rand.Next(10, 21),
                "TREES ARE THE EARTHS FRIENDS. TREESS ARE THE EARTHS FRIENDS. TREES ARE THE EA.......ohh.... I didn't realize you are the only one standing there. My name is Geneva Wonderstar and I love our planets trees." +
                "There are 91 billion trees surrounding us and we nearly never recognize their impact to us. Especially those lumberjacks across the ridge over there cutting all my friends down. Hey if you can steel their saws" +
                "I can make sure its worth your while. Can you lend me a hand? Press Enter to try!\n\n "
                , false);

            List<Challenger> challengerList = new List<Challenger> { c1, c2, c3, c4 };

            Random randNbr = new Random();
            int pickChallenger = rand.Next(challengerList.Count);
            Challenger mountainWestChallenger = challengerList[pickChallenger];

            

            
                return mountainWestChallenger;
            

        }

    }
}
