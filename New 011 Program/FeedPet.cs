using System;

namespace Tamagotchi
{
    public class Feed
    {

        public void MenuOption()
        {
            Console.Clear();
            double RoundedTemp;

            Console.WriteLine("----------------- GAME PAUSED---------------------");
            Console.WriteLine("-------------------Feed Menu----------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("    What food would you like to give your pet?    ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Basic Food    | Press 1 : Currently Own : {Inventory.BasicFoodInventory} | -10 OR -5 Hunger");
            Console.WriteLine($"Premium Food | Press 2 : Currently Own : {Inventory.PremiumFoodInventory} | -20 OR -10 Hunger");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("       Press 3 To return to the Main Menu         ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Health : {Needs.Health} ");
            Console.WriteLine($"Hunger : {Needs.Hunger}");
            Console.WriteLine($"Mood : {Needs.Mood}");
            RoundedTemp = Math.Round(Needs.Temperature, 2);
            Console.WriteLine($"Temperature : {RoundedTemp} °C");
            Console.WriteLine($"Coins : {Inventory.Coins}");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    BasicFood();
                    return;
                case ConsoleKey.D2:
                    PremiumFood();
                    return;
                case ConsoleKey.D3:
                    return;
            }
            
            Console.ReadKey();
            return;
        }
        
        public void BasicFood()
        {
            Console.Clear();
            Console.WriteLine("-----------Eat : Basic Food----------");
            if (Inventory.BasicFoodInventory >= 1)
            {
                if (Needs.Mood >= 50)
                {
                    Needs.Hunger = Needs.Hunger - 10;
                }
                else
                {
                    Needs.Hunger = Needs.Hunger - 5;
                }
                Inventory.BasicFoodInventory = Inventory.BasicFoodInventory - 1;
                Console.WriteLine("Basic Food Consumed");
                Console.WriteLine($"Current Hunger : {Needs.Hunger}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            else if (Inventory.PremiumFoodInventory < 1)
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You dont currently own any Basic Food");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            Console.ReadKey();
            MenuOption();
            
        }

        public void PremiumFood()
        {
            Console.Clear();
            Console.WriteLine("-----------Eat : Premium Food----------");
            if (Inventory.PremiumFoodInventory >= 1)
            {
                if (Needs.Mood >= 50)
                {
                    Needs.Hunger = Needs.Hunger - 20;
                }
                else 
                {
                    Needs.Hunger = Needs.Hunger - 10;
                }
                Inventory.PremiumFoodInventory = Inventory.PremiumFoodInventory - 1;
                Console.WriteLine("Premium Food Consumed");
                Console.WriteLine($"Amount of Premium Food Left : {Inventory.PremiumFoodInventory}");
                Console.WriteLine($"Current Hunger : {Needs.Hunger}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            else if(Inventory.PremiumFoodInventory < 1)
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You dont currently own any Premium Food");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
                Console.ReadKey();
                MenuOption();
            }
            
        }
    }
}