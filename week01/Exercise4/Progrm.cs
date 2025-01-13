using System;
using System.Collections.Generic;  // Needed to use the List<T> class

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Ask the user for a series of numbers and append them to a list
        List<int> numbers = new List<int>();  // Create a new list to store numbers

        while (true)  // Continue asking for numbers until the user enters 0
        {
            Console.Write("Enter a number (0 to stop): ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;  // Stop the loop when the user enters 0
            }
            else
            {
                numbers.Add(number);  // Add the number to the list
            }
        }

        // Step 2: Compute the sum of the numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;  // Add each number to the sum
        }

        // Step 3: Compute the average of the numbers
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        // Step 4: Find the maximum number in the list
        int max = numbers.Count > 0 ? numbers[0] : 0;  // Assume the first number is the max initially
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;  // Update the max if a larger number is found
            }
        }

        // Output the results
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}