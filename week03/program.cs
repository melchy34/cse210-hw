using System;

class Program
{
    static void Main()
    {
        // Test the constructors
        Fraction frac1 = new Fraction(); // 1/1
        Fraction frac2 = new Fraction(6); // 6/1
        Fraction frac3 = new Fraction(6, 7); // 6/7

        // Display the fractions using GetFractionString()
        Console.WriteLine("Fraction 1: " + frac1.GetFractionString()); // Should display "1/1"
        Console.WriteLine("Fraction 2: " + frac2.GetFractionString()); // Should display "6/1"
        Console.WriteLine("Fraction 3: " + frac3.GetFractionString()); // Should display "6/7"

        // Display the decimal values using GetDecimalValue()
        Console.WriteLine("Decimal of Fraction 1: " + frac1.GetDecimalValue()); // Should display 1.0
        Console.WriteLine("Decimal of Fraction 2: " + frac2.GetDecimalValue()); // Should display 6.0
        Console.WriteLine("Decimal of Fraction 3: " + frac3.GetDecimalValue()); // Should display ~0.8571

        // Test setters and getters
        frac1.Top = 5;
        frac1.Bottom = 4;

        // Display updated fraction
        Console.WriteLine("Updated Fraction 1: " + frac1.GetFractionString()); // Should display "5/4"
        Console.WriteLine("Updated Decimal of Fraction 1: " + frac1.GetDecimalValue()); // Should display 1.25
    }
}
