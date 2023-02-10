using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>(); // list to hold user selected scriptures

        Console.Clear();
        Console.WriteLine("Let's select a few of your favorite verses of scripture to memorize!");
        
        // Get multiple scriptures from user
        bool addScriptures = true;
        while(addScriptures) {
            // Get book from user
            Console.Write("Enter a book of scripture: ");
            string book = Console.ReadLine();
            
            // Get chapter from user
            int chapter = 0;
            bool looksGood = false;
            while (!looksGood) {
                Console.Write("What chapter? ");
                string chapterString = Console.ReadLine();
                // Input validation
                looksGood = int.TryParse(chapterString, out chapter);
                if (!looksGood) {
                    Console.WriteLine("Please enter a number.");
                }
            }
            
            // Get verse(s) from user
            int startVerse = 0;
            int endVerse = 0;
            looksGood = false;
            while (!looksGood) {
                Console.Write("What verse(s)? ");
                string verseString = Console.ReadLine();
                
                // Parse for range of verses vs single number
                if (verseString.Contains('-')) {
                    string[] verseRange = verseString.Split('-');
                    bool goodStart = int.TryParse(verseRange[0], out startVerse);
                    bool goodEnd = int.TryParse(verseRange[1], out endVerse);
                    if (goodStart && goodEnd) {looksGood = true;}
                } else {
                    looksGood = int.TryParse(verseString, out startVerse);
                }
                
                // input validation
                if (!looksGood) {
                    Console.WriteLine("Please enter a number or range of numbers 'a-b'.");
                }
            }
            
            // Get verse text
            Console.WriteLine("Please paste the contents of the selected verse(s) of scripture: ");
            string verseText = Console.ReadLine();

            // Assemble scripture from user input
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            Scripture scripture = new Scripture(reference, verseText);

            // Add to library
            library.Add(scripture);

            // Option to stop adding verses here with input validation
            looksGood = false;
            while(!looksGood) {
                Console.Write("Would you like to add another? (y/n): ");
                string response = Console.ReadLine();
                if (response == "n") {
                    addScriptures = false;
                    looksGood = true;
                } else if (response == "y") {
                    looksGood = true;
                } else {
                    Console.WriteLine("Please enter 'y' for yes or 'n' for no.");
                }
            }
        }
        
        // Loops through each scripture, replacing words with '_'s until memorized or user quits
        foreach (Scripture scripture in library) {
            Console.Clear();
            scripture.Display();

            string userChoice;
            while (true) {
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                userChoice = Console.ReadLine();
                if (userChoice == "quit") {
                    break;
                } else {
                    Console.Clear();
                    if (scripture.IsCompletelyHidden()) {
                        break;
                    } else {
                        scripture.HideWords(3);
                        scripture.Display();
                    }
                }
            }
            if (userChoice == "quit") {
                break;
            }
        }
    }
}