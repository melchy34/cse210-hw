 using System;

public class Fraction
{
    // Private fields for numerator and denominator
    private int top;
    private int bottom;

    // Constructor with no parameters - initializes fraction to 1/1
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    // Constructor with one parameter for the numerator - initializes denominator to 1
    public Fraction(int top)
    {
        this.top = top;
        bottom = 1;
    }

    // Constructor with two parameters for numerator and denominator
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom == 0 ? 1 : bottom; // Avoid division by zero by setting bottom to 1 if it's 0
    }

    // Getter and Setter for the numerator (top)
    public int Top
    {
        get { return top; }
        set { top = value; }
    }

    // Getter and Setter for the denominator (bottom)
    public int Bottom
    {
        get { return bottom; }
        set { bottom = value == 0 ? 1 : value; } // Avoid division by zero by setting bottom to 1 if it's 0
    }

    // Method to return the fraction as a string in the form "numerator/denominator"
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}
