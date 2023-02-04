using System;


public class Fraction
{
    private int topNumbers;
    private int bottomNumbers;
    public Fraction()
    {
        topNumbers = 1;
        bottomNumbers = 1;
    }
    public Fraction(int wholeNumber)
    {
        topNumbers = wholeNumber;
        bottomNumbers = 1;

    }
    public Fraction(int top, int bottom)
    {
        topNumbers = top;
        bottomNumbers = bottom;
    }
     public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{topNumbers}/{bottomNumbers}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)topNumbers / (double)bottomNumbers;
    }
}