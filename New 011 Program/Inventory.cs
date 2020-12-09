using System;

namespace Tamagotchi
{
    public class Inventory
    {
        public static int Coins  { get;  set; }
        public static int BasicFoodInventory { get;  set; }
        public static int PremiumFoodInventory { get;  set; }
        public static bool BallInventory { get;  set; }
        public static int BallUses { get;  set; }
        public static bool SqueakyToyInventory { get;  set; }
        public static int SqueakyToyUses { get;  set; }
        public static bool ChewToyInventory { get;  set; }
        public static int ChewToyUses { get;  set; }
        public static int CheapMedicineInventory  { get;  set; }
        public static int ExpensiveMedicineInventory { get;  set; }
        public void MenuOption()
        {
            
            Console.Clear();
            double RoundedTemp;

            Console.WriteLine("----------------- GAME PAUSED---------------------");
            Console.WriteLine("-------------------Inventory----------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Coins : {Coins}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Premium Food Owned: {PremiumFoodInventory}");
            Console.WriteLine($"Toy : Ball's Owned : {BallInventory}");
            Console.WriteLine($"Toy : Squeaky Toy's Owned : {SqueakyToyInventory}");
            Console.WriteLine($"Toy : Chew Toy's Owned : {ChewToyInventory}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Health : {Needs.Health} ");
            Console.WriteLine($"Hunger : {Needs.Hunger}");
            Console.WriteLine($"Mood : {Needs.Mood}");
            RoundedTemp = Math.Round(Needs.Temperature, 2);
            Console.WriteLine($"Temperature : {RoundedTemp}");
            Console.WriteLine("--------Press any key to return to the Menu-------");
            Console.ReadKey();
            return;
            
        }
    }
}