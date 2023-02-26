/***************************************************************
Class:      CSE 210 Brother Moseley
Assignment: Unit 06 Develop: Mindfulness Program
Author:     Daniel Loveless
Description:
    This Mindfulness Program presents its user with different 
    mindfulness activities they may choose to practice for a 
    user-determined amount of time. It has an interactive menu
    and input validation with user friendly formatting. This
    program made use of the principle of inheritence with well
    defined classes that have thoughtfully included methods and
    attributes shared amongst similar classes. To go above and 
    beyond the core requirements, there are several different 
    animation types used throughout the program all incorporated
    into the Pause() method of the Activity parent class as well
    as input validaion throughout.
****************************************************************/

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
            // Menu Options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string selection = Console.ReadLine();

            // Selection Behavior
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
                    // Input Validation
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number (1-4).\n");
                    break;
            }
        }
    }
}