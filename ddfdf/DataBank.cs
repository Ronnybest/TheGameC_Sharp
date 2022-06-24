
using System.Collections.Generic;

namespace ddfdf
{
    static class DataBank
    {
        public static void SetDefault()
        {
            day = 1;
            gold = 22100;
            wood = 22200;
            stone = 22200;
            human = 20;
            food = 50;
            minusFood = human;
            freeHuman = human;
            //Data for find food
            isReadyToFood = false;
            isReadyToWood = false;
            isReadyToStone = false;
            humantowork = 0;
            moves = 5;
            count_days_to_die = 0;
            all_price = new List<int> { 500, 200, 300, 300, 200, 100, 100, 500, 300, 600, 500, 500, 700, 700, 700, 400, 1000, 1000 };
            upgrades = new Dictionary<string, int>()
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
            state_upgrade = new List<int>()
            {
                1,1,1,1,1,1,1,1,1
            };
            isShopBuild = false; isCityHallBuild = false;
            isSawmilBuild = false; isBankBuild = false; isQuarryBuild = false; isFarmBuild = false;
            isForgeBuild = false; isPortBuild = false; isBarracksBuild = false; isMedCenterBuild = false;

            //Bonuses and events
            foodBonus = 1d;
            isCaravanHere = false;
            CaravanDays = 0;
    }
        //Main data
        public static int day = 1;
        public static double gold = 22100;
        public static double wood = 22200;
        public static double stone = 22200;
        public static int human = 20;
        public static double food = 50;
        public static double minusFood = human;
        public static int freeHuman = human;
        //Data for find food
        public static int humantowork;
        public static bool isReadyToFood = false;
        public static bool isReadyToWood = false;
        public static bool isReadyToStone = false;

        //Moves
        public static int moves = 5;

        public static int count_days_to_die = 0;

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

        // Checkers for buildings button
        public static bool isShopBuild = false, isCityHallBuild = false,
            isSawmilBuild = false, isBankBuild = false, isQuarryBuild = false, isFarmBuild = false,
            isForgeBuild = false, isPortBuild = false, isBarracksBuild = false, isMedCenterBuild = false;

        //Bonuses and events
        public static double foodBonus = 1d;
        public static double woodInWinter = 1.3;
        public static bool isCaravanHere = false;
        public static int CaravanDays = 0;
        public static bool alreadyFoodEvent = false;
        public static short SeasonForFoodEvent = 0;


    }
}
