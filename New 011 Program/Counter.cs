using System;

namespace Tamagotchi
{
    public class Counter : RealTimeComponent
    {
        int startCount;
        int count;
        bool active = true;
        public int TickSpeed { get; set; }

        Needs PetNeeds = new Needs();
        public Counter(int startValue)
        {
            startCount = startValue;
        }

        public void Display()
        {
            double RoundedTemp;
            
            if (active)
            {
                //MenuDisplay
                Console.WriteLine($"Pet Name: {Program.petName} ");
                Console.WriteLine($"Time Alive (in seconds) : {count} ");
                Console.WriteLine($"Game Speed : {TickSpeed} ");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Menu : ");
                Console.WriteLine("1 : Feed");
                Console.WriteLine("2 : Play");
                Console.WriteLine("3 : Tend");
                Console.WriteLine("4 : Shop");
                Console.WriteLine("5 : Invetory");
                Console.WriteLine("6 : Exit");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press H for the HELP Menu");
                Console.WriteLine("Press P To Pause the game");
                //Console.WriteLine("Press arrow key UP to speed the game up");
                //Console.WriteLine("Press arrow key DOWN to slow the game down");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Health : {Needs.Health} ");
                Console.WriteLine($"Hunger : {Needs.Hunger}");
                Console.WriteLine($"Mood : {Needs.Mood}");
                RoundedTemp = Math.Round(Needs.Temperature, 2);
                Console.WriteLine($"Temperature : {RoundedTemp} °C");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Coins : {Inventory.Coins}");

                if (Needs.Hunger > 50)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Your Pet is hungry");
                }
                
                if (Needs.Mood < 50)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Your Pet is unhappy");
                }

                if (Needs.Health < 50)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Your Pet is not feeling too well");
                }
                
                if (Needs.Temperature < 10)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("The Room is too cold");
                }
                if (Needs.Temperature < 5)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("The Room is extrememly Cold");
                }
                if (Needs.Temperature > 25)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("The Room is too hot");
                }
                if (Needs.Temperature > 30)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("The Room is extrememly Hot");
                }
                if (Needs.Health <= 0)
                {
                    Simulation Simulation = new Simulation();
                    Console.Clear();
                    Simulation.EndGame();

                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"Your Pet {Program.petName} has passed away.");
                    Console.WriteLine($"Your Pet was alive for {count} seconds.");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Enter the escape key to Exit the program.");

                }
                
                //Sets the Needs Boundries
                
                if (Needs.Health > 100)
                {
                    Needs.Health = 100;
                }
                
                if (Needs.Hunger < 0)
                {
                    Needs.Hunger = 2;
                }
                if (Needs.Hunger >= 100)
                {
                    Needs.Hunger = 100;
                }
                
                if (Needs.Mood > 100)
                {
                    Needs.Mood = 100;
                }
                if (Needs.Mood <= 0)
                {
                    Needs.Mood = 2;
                }

            }
        }

        public void Initialise()
        {
            TickSpeed = 1;
            count = startCount;
        }

        public void Update()
        {
            if (count > 0)
            {
                count += TickSpeed;
            }
            else
            {
                active = false;
            }
        }
    }
}