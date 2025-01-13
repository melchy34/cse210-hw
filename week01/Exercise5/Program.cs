using System;

class Program
{
    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to square the number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result: user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, your favorite number squared is: {squaredNumber}");
    }

    // Main function to call the other functions
    static void Main(string[] args)
    {
        // Call DisplayWelcome to greet the user
        DisplayWelcome();

        // Call PromptUserName to get the user's name
        string userName = PromptUserName();

        // Call PromptUserNumber to get the user's favorite number
        int userNumber = PromptUserNumber();

        // Call SquareNumber to calculate the square of the number
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult to display the result to the user
        DisplayResult(userName, squaredNumber);
    }
}