using System;

namespace Tamagotchi
{
    public class Tend
    {

        public void MenuOption()
        {
            Console.Clear();
            double RoundedTemp;

            Console.WriteLine("----------------- GAME PAUSED---------------------");
            Console.WriteLine("-------------------Tend Menu----------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("   Additional Options for Tending to the Pet      ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Press 1 To Use Cheap Medicine |Owned : {Inventory.CheapMedicineInventory} | +25 Health +25 Hunger");
            Console.WriteLine($"Press 2 To Use Cheap Medicine |Owned : {Inventory.CheapMedicineInventory} | +50 Health +70 Hunger");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Press 3 Increase Temperature by 1 °C | Cost : 5");
            Console.WriteLine("Press 4 Lower Temperature by 1 °C | Cost : 5");
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
                    CheapMedicine();
                    return;
                case ConsoleKey.D2:
                    ExpensiveMedicine();
                    return;
                case ConsoleKey.D3:
                    IncreaseTemperature();
                    return;
                case ConsoleKey.D4:
                    DecreaseTemperature();
                    return;
                case ConsoleKey.D5:
                    return;
            }
            
            Console.ReadKey();
            return;
            
        }
        
        public void CheapMedicine()
        {
            Console.Clear();
            Console.WriteLine("-----------USE : Cheap Medicine----------");
            if (Inventory.CheapMedicineInventory >= 1)
            {
                Inventory.CheapMedicineInventory = Inventory.CheapMedicineInventory - 1;
                Needs.Health = Needs.Health + 25;
                Needs.Hunger = Needs.Hunger + 25;
                Console.WriteLine("You used Cheap Medicine");
                Console.WriteLine($"Current Health : {Needs.Health}");
                Console.WriteLine($"Current Hunger : {Needs.Hunger}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");   
            }
            else
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't own Cheap Medicine");
                Console.WriteLine($"Current Health : {Needs.Health}");
                Console.WriteLine($"Current Hunger : {Needs.Hunger}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");   
            }
            Console.ReadKey();
            MenuOption(); 
        }

        public void ExpensiveMedicine()
        {
            Console.Clear();
            Console.WriteLine("-----------USE : Expensive Medicine----------");
            if (Inventory.ExpensiveMedicineInventory >= 1)
            {
                Inventory.ExpensiveMedicineInventory = Inventory.ExpensiveMedicineInventory - 1;
                Needs.Health = Needs.Health + 50;
                Needs.Hunger = Needs.Hunger + 70;
                Console.WriteLine("You used Expensive Medicine");
                Console.WriteLine($"Current Health : {Needs.Health}");
                Console.WriteLine($"Current Hunger : {Needs.Hunger}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
            }
            else
            {
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't own Expensive Medicine");
                Console.WriteLine($"Current Health : {Needs.Health}");
                Console.WriteLine($"Current Hunger : {Needs.Hunger}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");  
            }
            Console.ReadKey();
            MenuOption(); 
        }
        public void IncreaseTemperature()
        {
            Console.Clear();
            Console.WriteLine("-----------Increase : Temperature----------");
            if (Inventory.Coins >= 5)
            {
                double RoundedTemp;
                Needs.Temperature = Needs.Temperature + 1;
                RoundedTemp = Math.Round(Needs.Temperature, 2);
                Inventory.Coins = Inventory.Coins - 5;
                Console.WriteLine("You have Increased the temperature");
                Console.WriteLine($"Current Temperature : {RoundedTemp} °C");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");

            }
            else
            {
                double RoundedTemp;
                RoundedTemp = Math.Round(Needs.Temperature, 2);
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't have enough coins");
                Console.WriteLine($"Current Temperature : {RoundedTemp} °C");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
 
            }
            Console.ReadKey();
            MenuOption();        
        }
        public void DecreaseTemperature()
        {
            Console.Clear();
            Console.WriteLine("-----------Decrease : Temperature----------");
            if (Inventory.Coins >= 5)
            {
                double RoundedTemp;
                Needs.Temperature = Needs.Temperature - 1;
                RoundedTemp = Math.Round(Needs.Temperature, 2);
                Inventory.Coins = Inventory.Coins - 5;
                Console.WriteLine("You have Decreased the temperature");
                Console.WriteLine($"Current Temperature : {RoundedTemp} °C");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");
 
            }
            else
            {
                double RoundedTemp;
                RoundedTemp = Math.Round(Needs.Temperature, 2);
                Console.WriteLine("----------------ERROR-------------------");
                Console.WriteLine("You don't have enough coins");
                Console.WriteLine($"Current Temperature : {RoundedTemp} °C");
                Console.WriteLine($"Coins remaining : {Inventory.Coins}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any Key to return to the main menu.");

            }
            Console.ReadKey();
            MenuOption();    
        }
    }
}