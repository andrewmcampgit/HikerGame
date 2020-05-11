//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GameLibrary
//{
//    public class CritterWarehouse
//    {

//        public static Critter GetCritter()
//        {
//            Random rand = new Random();

//            Critter critter1 = new Critter("SongBird", 0, 0, 30, 0,
//                "A lovely tune. A melody to soften the heart. Isn't it nice to hear the sweet sound of mother nature.",
//                false);
//            Critter critter2 = new Critter("Grizzly Bear", 80, 50, 95, 50,
//                "Fierce. A loud growl. Should you run or should you be as still as a rock?\nWhatever you choose may determine life or death....",
//                true);


//            List<Critter> critterList = new List<Critter> { critter1, critter2 };

//            Random randNbr = new Random();
//            int pickCritter = rand.Next(critterList.Count);
//            Critter critterSelected = critterList[pickCritter];


//            if (critterList.Count == 0)
//            {
//                Console.WriteLine("There are no more critters for this region. Try a different option.");

//            }
//            else
//            {
//                critterList.Remove(critterSelected);

//            }


//            return critterSelected;

//        }
//    }
//}

//