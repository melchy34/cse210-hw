using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the magic number: ");
        int magicNumber = int.Parse(Console.ReadLine(); 

        Console.Write("Guess the magic number: ");
        int userGuess = int.Parse(Console.ReadLine()); 

        if (userGuess == magicNumber)
        {
            Console.WriteLine("Congratulations! You guessed the magic number.");
        }
        else if (userGuess < magicNumber)
        {
            Console.WriteLine("Guess higher!");
        }
        else
        {
            Console.WriteLine("Guess lower!");

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}