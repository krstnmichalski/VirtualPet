using System;

namespace Tamagotchi
{
    
    public class Needs
    {
        public static int Health  { get;  set; }
        public static int Hunger  { get; set; }
        public static int Mood   { get;  set; }
        public static double Temperature   { get;  set; }

        public Needs()
        {
            Health = 100;
            Hunger = 0;
            Mood = 100;
            Temperature = 18.60;
        }
    }
}