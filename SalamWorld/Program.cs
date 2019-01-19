using System;

namespace SalamWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start ...
            string name = "Alhasan";
            Console.WriteLine("Salam World! I am {0} ^_^", name);
            Console.WriteLine("\nWould you like to be a friend?");
            Console.WriteLine("\tY - Yes");
            Console.WriteLine("\tN - No");
            Console.Write("Your choice? ");
            do
            {
                string choice = Console.ReadLine();
                choice.ToLower();
                if (choice == "y" || choice == "n")
                {
                    if (choice == "y")
                    {
                        Console.WriteLine("\nSalam new friend ^_^");
                    }
                    else
                    {
                        Console.WriteLine("\nThat's right, maybe next time ;)");
                    }
                    break;
                }
                Console.Write("Please your choice? (Y/N) ");
            } while (true);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
