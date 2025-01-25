using System;

class Program
{
    static void Main()
    {
        // Example usage of the classes
        Reference reference = new Reference("John", 3, 16);  // John 3:16
        string scriptureText = "For God so loved the world that he gave his only begotten Son";

        // Create a scripture
        Scripture scripture = new Scripture(reference, scriptureText);

        Random rand = new Random();

        // Display the scripture and keep hiding words until all are hidden
        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a random word and display the scripture again
            scripture.HideRandomWord(rand);
        }

        // Display the final state of the scripture with all words hidden
        scripture.Display();
        Console.WriteLine("All words are now hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}
