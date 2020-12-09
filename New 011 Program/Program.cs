using System;

namespace Tamagotchi
{
    class Program
    {
        public static string petName = "";
        static void Main()
        {
            Simulation sim = new Simulation();
            //Starts The program
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-----------Welcome to Virtual Pet 2.0-------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("What would you like your pet to be called? : ");
            petName = Console.ReadLine();
            Console.WriteLine($"Your Pet is called: {petName} ");
            Console.WriteLine("Press enter to proceed");
            Console.ReadKey();
            Console.Clear();
            sim.Run();


        }
    }
}
