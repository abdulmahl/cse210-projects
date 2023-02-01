using System;
using static System.Console;


public class Fraction
{
    // Two private attributes for this class.
    private int _top;
    private int _bottom;

    // Constructor that takes no - arguments.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    // Constructor that takes one parameter.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    // Constructor that takes two parameter.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Get the value of top.
    public int GetTop()
    {
        return _top;
    }    

    // Manipulate the value of top
    public void SetTop(int top)
    {
        _top = top;
    }
    // Get value of bottom.
    public int GetBottom()
    {
        return _bottom;
    }
    // Manipulate value of bottom.
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    // Create method that returns the form of fraction as a string, "(3 / 4)".
    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    // Create method that returns double of top and bottom as a decimal.
    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}