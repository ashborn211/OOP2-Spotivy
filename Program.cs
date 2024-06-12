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
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Close Program");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You chose Option 1");
                        break;
                    case "2":
                        Console.WriteLine("You chose Option 2");
                        break;
                    case "3":
                        Console.WriteLine("Closing program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                Console.WriteLine(); // Just to add a blank line for readability
            }
        }
    }
}
