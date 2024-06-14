using System;

namespace OOP2_Spotivy
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. View all songs");
                Console.WriteLine("2. View all albums");
                Console.WriteLine("3. View all artists");
                Console.WriteLine("4. Create a playlist");
                Console.WriteLine("5. View your playlists");
                Console.WriteLine("6. View friends");
                Console.WriteLine("7. Close Program");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        Console.WriteLine("Closing program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
