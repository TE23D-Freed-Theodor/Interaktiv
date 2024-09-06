using System;

class Program
{
    static void Main()
    {
        string heavy_armor;

        Console.WriteLine("Do they have anti-air?");
        string anti_air = Console.ReadLine();

        if (anti_air.ToLower() == "yes") 
        {
            Console.WriteLine("Do they have Railroad Guns?");
            string railroad = Console.ReadLine();

            if (railroad.ToLower() == "no")
            {
                Console.WriteLine("Attack with railroad guns");
                Console.ReadLine();
            }
            else if (railroad.ToLower() == "yes")
            {
                Console.WriteLine("Are they otherwise heavily defended?");
                string strong_defence = Console.ReadLine();

                if (strong_defence.ToLower() == "yes")
                {
                    Console.WriteLine("Retreat");
                }
                else if (strong_defence.ToLower() == "no")
                {
                    Console.WriteLine("Are they defending with nothing but railroad guns and anti air?");
                    string no_defence = Console.ReadLine();

                    if (no_defence.ToLower() == "yes")
                    {
                        Console.WriteLine("Attack with medium tanks");
                        Console.ReadLine();
                    }
                    else if (no_defence.ToLower() == "no")
                    {
                        Console.WriteLine("Are they defending with light armored targets?");
                        string light_armor = Console.ReadLine();

                        if (light_armor.ToLower() == "yes")
                        {
                            Console.WriteLine("Attack with light tanks");
                            Console.ReadLine();
                        }
                        else if (light_armor.ToLower() == "no") 
                        {
                            Console.WriteLine("Attack with motorized infantry");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
        else if (anti_air.ToLower() == "no")
        {
            Console.WriteLine("Are they mostly heavily armored?");
            heavy_armor = Console.ReadLine();

            if (heavy_armor.ToLower() == "no") 
            {
                Console.WriteLine("Use tactical bombers");
            }
            else if (heavy_armor.ToLower() == "yes")
            {
                Console.WriteLine("Use attack bombers");
            }
        }
        Console.ReadLine();
    }
}
