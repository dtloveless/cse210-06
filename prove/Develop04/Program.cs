using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity Breathing = new BreathingActivity();
        ReflectionActivity Reflection = new ReflectionActivity();
        ListingActivity Listing = new ListingActivity();

        Console.Clear();

        bool quit = false;
        while (!quit) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string selection = Console.ReadLine();

            switch (selection) {
                case "1":
                    Breathing.Breathe();
                    Console.Clear();
                    break;
                case "2":
                    Reflection.Reflect();
                    Console.Clear();
                    break;
                case "3":
                    Listing.List();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness Tool!\n");
                    quit = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number (1-4).\n");
                    break;
            }
        }
    }
}