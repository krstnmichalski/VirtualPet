using System;

namespace Tamagotchi
{
    public class Play
    {

        public void MenuOption()
        {
            Console.Clear();
            double RoundedTemp;

            Console.WriteLine("----------------- GAME PAUSED---------------------");
            Console.WriteLine("-------------------Play Menu----------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("   What would you like to play with your pet?     ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("   No Toy   | Press 1 : Currently Own : Unlimited | +5 Mood");
            Console.WriteLine($" Ball Toy   | Press 2 : Currently Owned : {Inventory.BallInventory} | +20 Mood");
            Console.WriteLine($"Squeaky Toy | Press 3 : Currently Owned : {Inventory.SqueakyToyInventory} | +30 Mood");
            Console.WriteLine($" Chew toy   | Press 4 : Currently Owned : {Inventory.ChewToyInventory} | +50 Mood");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("         Press 5 To return to the Main Menu       ");      
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
                    NoToy();
                    return;
                case ConsoleKey.D2:
                    BallToy();
                    return;
                case ConsoleKey.D3:
                    SqueakyToy();
                    return;
                case ConsoleKey.D4:
                    ChewToy();
                    return;
                case ConsoleKey.D5:
                    return;
            }
            
            
            Console.ReadKey();
            return;
            
        }
        
        public void NoToy()
        {
            Console.Clear();
            Console.WriteLine("-----------Play : No Toy----------");
            Needs.Mood = Needs.Mood + 5;
            Console.WriteLine("You have played with your pet");
            Console.WriteLine($"Current Mood : {Needs.Mood}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Press any Key to return to the main menu.");
            Console.ReadKey();
            MenuOption();    
        }

        public void BallToy()
        {
            Console.Clear();
            Console.WriteLine("-----------Play : Ball Toy----------");
            if (Inventory.BallInventory == true)
            {
                Inventory.BallUses = Inventory.BallUses - 1;
                Needs.Mood = Needs.Mood + 20;
                Console.WriteLine("You have played with your pet");
                Console.WriteLine($"Current Mood : {Needs.Mood}");
                Console.WriteLine($"Uses Remaining : {Inventory.BallUses}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            else
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't own a Ball Toy");
                Console.WriteLine($"Current Mood : {Needs.Mood}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            Console.ReadKey();
            MenuOption();   
        }
        public void SqueakyToy()
        {
            Console.Clear();
            Console.WriteLine("-----------Play : Squeaky Toy----------");
            if (Inventory.SqueakyToyInventory == true)
            {
                Inventory.SqueakyToyUses = Inventory.SqueakyToyUses - 1;
                Needs.Mood = Needs.Mood + 30;
                Console.WriteLine("You have played with your pet");
                Console.WriteLine($"Current Mood : {Needs.Mood}");
                Console.WriteLine($"Uses Remaining : {Inventory.SqueakyToyUses}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            else
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't own a Squeaky Toy");
                Console.WriteLine($"Current Mood : {Needs.Mood}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            Console.ReadKey();
            MenuOption();   
            
        }
        public void ChewToy()
        {
            Console.Clear();
            Console.WriteLine("-----------Play : Chew Toy----------");
            if (Inventory.SqueakyToyInventory == true)
            {
                Inventory.ChewToyUses = Inventory.ChewToyUses - 1;
                Needs.Mood = Needs.Mood + 50;
                Console.WriteLine("You have played with your pet");
                Console.WriteLine($"Current Mood : {Needs.Mood}");
                Console.WriteLine($"Uses Remaining : {Inventory.ChewToyUses}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            else
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't own a Chew Toy");
                Console.WriteLine($"Current Mood : {Needs.Mood}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            Console.ReadKey();
            MenuOption();   
        }
    }
}