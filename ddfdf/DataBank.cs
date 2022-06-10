using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddfdf
{
    static class DataBank
    {
        //Main data
        public static int day = 1;
        public static double gold = 22100;
        public static double wood = 22200;
        public static double stone = 22200;
        public static int human = 5;
        public static double food = 20;
        public static double minusFood = human;
        public static int freeHuman = human;
        //Data for find food
        public static int humantowork;
        public static bool isReadyToFood = false;
        public static bool isReadyToWood = false;
        public static bool isReadyToStone = false;

        //Moves
        public static int moves = 5;

        //Price for buildings
        public static List<int> all_price = new List<int>() 
        { 
            500, 200, 300, 300, 200, 100, 100, 500, 300, 600, 500, 500, 700, 700, 700, 400, 1000, 1000 
        };

        //Bonuses from buildings and upgrades
        public static Dictionary<string, int> upgrades = new Dictionary<string, int>()
        {
            {"Sawmill", 0},
            {"Quarry", 0 },
            {"Farm", 0 },
            {"Forge", 0 },
            {"Market", 0},
            {"Bank",0 },
            {"City_hall", 0 },
            {"Port", 0 },
            {"Barracks",0 }
        };
        public static List<int> state_upgrade = new List<int>()
        {
            1,1,1,1,1,1,1,1,1
        };


    }
}
