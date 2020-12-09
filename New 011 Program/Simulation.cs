using System;
using System.Threading;

namespace Tamagotchi
{

    public enum AppState
    {
        Running,
        Help,
        Paused,
        Exiting
    }

    class Simulation : RealTimeComponent
    {
        //private bool appRunning = true;
        AppState appState = AppState.Running;
        Counter counter = new Counter(1);

        Needs PetNeeds = new Needs();

        Feed FeedPet = new Feed();

        Inventory Inventory = new Inventory();

        Shop Shop = new Shop();

        Play PlayPet = new Play();

        Tend TendPet = new Tend();

        public Simulation()
        {
            
        }

        public void Run()
        {
            Initialise();
            

            do
            {
                CheckKeyInput();

                Needs.Hunger += 1;
                Needs.Mood -= 1;
                Needs.Temperature -= 0.01;
                Inventory.Coins += 1;

                //hungry
                if (Needs.Hunger >= 50)
                {
                    Needs.Health = Needs.Health - 1;
                }
                // very hungry
                if (Needs.Hunger >= 70)
                {
                    Needs.Health = Needs.Health - 1;
                }
                //High Temp
                if (Needs.Temperature >= 25)
                {
                    Needs.Mood = Needs.Mood - 1;
                }
                //Low Temp
                if (Needs.Temperature <= 10)
                {
                    Needs.Mood = Needs.Mood - 1;
                }
                //Very Cold Temp
                if (Needs.Temperature <= 5)
                {
                    Needs.Health = Needs.Health - 1;
                }
                //Very Hot Temp
                if (Needs.Temperature >= 30)
                {
                    Needs.Health = Needs.Health - 1;
                }

                //Toy Expire check
                if (Inventory.BallUses == 0)
                {
                    Inventory.BallInventory = false;
                }
                
                if (Inventory.SqueakyToyUses == 0)
                {
                    Inventory.SqueakyToyInventory = false;
                }

                if (Inventory.ChewToyUses == 0)
                {
                    Inventory.ChewToyInventory = false;
                }
                

                switch (appState)
                {
                    case AppState.Running:
                        Update();
                        Display();
                        break;
                    case AppState.Paused:
                        break;
                    case AppState.Help:
                        DisplayHelp();
                        break;
                    default:
                        break;
                    
                    
                }
                
                
                Thread.Sleep(17500/10);
            } while (appState != AppState.Exiting);
        }
        public void EndGame()
        {
            appState = AppState.Paused;
        }
        public void NewGame()
        {
            Needs.Health = 100;
            Needs.Mood = 100;
            Needs.Hunger = 0;
            Needs.Temperature = 18.60;
            Inventory.Coins = 0;
            Inventory.BasicFoodInventory = 0;
            Inventory.PremiumFoodInventory = 0;
            Inventory.BallInventory = false;
            Inventory.SqueakyToyInventory = false;
            Inventory.ChewToyInventory = false;
            Inventory.CheapMedicineInventory = 0;
            Inventory.ExpensiveMedicineInventory = 0;
            Display();
        }
        public void ExitGame()
        {
            appState = AppState.Exiting;
        }

        public void DisplayHelp()
        {
            Console.Clear();
            Console.WriteLine("----------------- GAME PAUSED---------------------");
            Console.WriteLine("-------------------Help Menu----------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("If the Pet Hunger goes above 50 the pet will start losing health");
            Console.WriteLine("Once it goes over 70 this will significantly increase ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("If the Pet Mood goes under 50 the pet will not eat as much");   
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("If the termperature goes below 10°C or above 25°C");
            Console.WriteLine("The Mood of the pet will go down");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("If the termperature goes below 5°C or above 30°C");
            Console.WriteLine("The Health of the pet will go down");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("If the Pet health Reaches 0 The pet will pass away");
            Console.WriteLine("And the user would need to restart the game");
            Console.WriteLine("Medicine can be used to Heal the pet.");
            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
            appState = AppState.Running;
            Console.Clear();
            counter.Display();
        }

        public void Initialise()
        {
            Console.CursorVisible = false;
            Console.Clear();
            counter.Initialise();
        }

        public void CheckKeyInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    counter.TickSpeed++;
                }

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    counter.TickSpeed--;
                }

                //Exit Button
                if (keyPressed == ConsoleKey.D6)
                {
                    appState = AppState.Exiting;
                }
                
                //Feed Button
                if (keyPressed == ConsoleKey.D1)
                {
                    FeedPet.MenuOption();
                }
                
                //Play Button
                if (keyPressed == ConsoleKey.D2)
                {
                    PlayPet.MenuOption();
                }
                
                //Tend Button
                if (keyPressed == ConsoleKey.D3)
                {
                    TendPet.MenuOption();
                }
                
                //Shop Button
                if (keyPressed == ConsoleKey.D4)
                {
                    Shop.MenuOption();
                }
                
                //Inventory button
                if (keyPressed == ConsoleKey.D5)
                {
                    Inventory.MenuOption();
                }

                if (keyPressed == ConsoleKey.R)
                {
                    counter.Initialise();
                }

                if (keyPressed == ConsoleKey.H)
                {
                    appState = AppState.Help;
                }

                if (keyPressed == ConsoleKey.P)
                {
                    if (appState != AppState.Paused)
                    {
                        appState = AppState.Paused;
                    }
                    else if (appState == AppState.Paused)
                    {
                        appState = AppState.Running;
                    }

                }
            }
        }

        public void Update()
        {
            counter.Update();
        }

        public void Display()
        {
            Console.Clear();
            counter.Display();
        }
    }
}
