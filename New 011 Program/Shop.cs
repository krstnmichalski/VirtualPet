using System;

namespace Tamagotchi
{
    public class Shop
    {

        public void MenuOption()
        {
            
            Console.Clear();
            double RoundedTemp;

            Console.WriteLine("----------------- GAME PAUSED---------------------");
            Console.WriteLine("----------------------Shop------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Coins : {Inventory.Coins}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Buy Basic Food         | Press 1 : Currently Own :{Inventory.BasicFoodInventory} | Cost : 5 Coins | -15 OR -5 Hunger");
            Console.WriteLine($"Buy Premium Food       | Press 2 : Currently Own :{Inventory.PremiumFoodInventory} | Cost : 15 Coins | -20 OR -10 Hunger");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Buy Ball Toy           | Press 3 : Currently Own :{Inventory.BallInventory} | Cost : 15 Coins | +20 Mood");
            Console.WriteLine($"Buy Squeaky Toy        | Press 4 : Currently Own :{Inventory.SqueakyToyInventory} | Cost : 30 Coins | +30 Mood");
            Console.WriteLine($"Buy Chew Toy           | Press 5 : Currently Own :{Inventory.ChewToyInventory} | Cost : 50 Coins | +50 Mood");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Buy Cheap Medicine     | Press 6 : Currently Own :{Inventory.CheapMedicineInventory} | Cost : 25 Coins | +25 Health +25 Hunger");
            Console.WriteLine($"Buy Expensive Medicine | Press 7 : Currently Own :{Inventory.ExpensiveMedicineInventory} | Cost : 50 Coins | +50 Health +70 Hunger");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Press 8 To return to the Main Menu");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Health : {Needs.Health} ");
            Console.WriteLine($"Hunger : {Needs.Hunger}");
            Console.WriteLine($"Mood : {Needs.Mood}");
            RoundedTemp = Math.Round(Needs.Temperature, 2);
            Console.WriteLine($"Temperature : {RoundedTemp} °C");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    BuyBasicFood();
                    return;
                case ConsoleKey.D2:
                    BuyPremiumFood();
                    return;
                case ConsoleKey.D3:
                    BuyBallToy();
                    return;
                case ConsoleKey.D4:
                    BuySqueakyToy();
                    return;
                case ConsoleKey.D5:
                    BuyChewToy();
                    return;
                case ConsoleKey.D6:
                    BuyCheapMedicine();
                    return;
                case ConsoleKey.D7:
                    BuyExpensiveMedicine();
                    return;
                case ConsoleKey.D8:
                    return;
            }
            
            Console.ReadLine();           
        }
        public void BuyPremiumFood()
        {
            Console.Clear();
            Console.WriteLine("-----------Buy Premium Food----------");
            Console.WriteLine("Are you sure you want to buy 1 Premium Food?");
            Console.WriteLine("Press Y for Yes | Press N for No");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Y:
                    ConfirmPremiumFood();
                    return;
                case ConsoleKey.N:
                    MenuOption();
                    return;
            }
            Console.ReadKey();
            return;
        }
        
        public void ConfirmPremiumFood()
        {
            Console.Clear();
            Console.WriteLine("-----------Buy Premium Food----------");
            if (Inventory.Coins >= 15)
            {
                Inventory.Coins = Inventory.Coins  - 15;
                Inventory.PremiumFoodInventory = Inventory.PremiumFoodInventory + 1;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Amount of Premium Food currently Owned : {Inventory.PremiumFoodInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 15)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            
        }
        public void BuyBasicFood()
        {
            Console.Clear();
            Console.WriteLine("--------Buy Basic Food-------");
            if (Inventory.Coins >= 5)
            {
                Inventory.Coins = Inventory.Coins  - 5;
                Inventory.BasicFoodInventory = Inventory.BasicFoodInventory + 1;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Basic Food Owned : {Inventory.BasicFoodInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 5)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
        }

        public void BuyBallToy()
        {
            Console.Clear();
            Console.WriteLine("--------Buy Ball Toy-------");
            if (Inventory.Coins >= 15)
            {
                Inventory.Coins = Inventory.Coins  - 15;
                Inventory.BallInventory = true;
                Inventory.BallUses = 10;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Ball Toy Owned : {Inventory.BallInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine($"Uses Remaining : {Inventory.BallUses}");
                Console.WriteLine("After 10 Uses you will need to rebuy the item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 15)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
        }

        public void BuySqueakyToy()
        {
            Console.Clear();
            Console.WriteLine("--------Buy Squeaky Toy-------");
            if (Inventory.Coins >= 30)
            {
                Inventory.Coins = Inventory.Coins  - 30;
                Inventory.SqueakyToyInventory = true;
                Inventory.SqueakyToyUses = 10;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Squeaky Toy Owned : {Inventory.SqueakyToyInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine($"Uses Remaining : {Inventory.SqueakyToyUses}");
                Console.WriteLine("After 10 Uses you will need to rebuy the item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 30)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
        }

        public void BuyChewToy()
        {
            Console.Clear();
            Console.WriteLine("--------Buy Chew Toy-------");
            if (Inventory.Coins >= 50)
            {
                Inventory.Coins = Inventory.Coins  - 50;
                Inventory.ChewToyInventory = true;
                Inventory.ChewToyUses = 5;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Chew Toy Owned : {Inventory.ChewToyInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine($"Uses Remaining : {Inventory.ChewToyUses}");
                Console.WriteLine("After 5 Uses you will need to rebuy the item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 50)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }

        }
        public void BuyCheapMedicine()
        {
            Console.Clear();
            Console.WriteLine("--------Buy Cheap Medicine-------");
            if (Inventory.Coins >= 25)
            {
                Inventory.Coins = Inventory.Coins  - 25;
                Inventory.CheapMedicineInventory = Inventory.CheapMedicineInventory + 1;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Cheap Medicine Owned : {Inventory.CheapMedicineInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 25)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            
        }
        public void BuyExpensiveMedicine()
        {
            Console.Clear();
            Console.WriteLine("--------Buy Expensive Medicine-------");
            if (Inventory.Coins >= 50)
            {
                Inventory.Coins = Inventory.Coins  - 50;
                Inventory.ExpensiveMedicineInventory = Inventory.ExpensiveMedicineInventory + 1;;
                Console.WriteLine("Purchase Complete");
                Console.WriteLine($"Expensive Medicine Owned : {Inventory.ExpensiveMedicineInventory}");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.Coins < 50)
            {
                Console.WriteLine("Purchase Incomplete");
                Console.WriteLine("Not enough coins to buy item.");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }

        }
    }
}