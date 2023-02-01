using System;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        // int fr1 = fraction1.GetTop() / fraction1.GetBottom();
        // fraction1.SetTop(9);
        // fraction1.SetBottom(3);
        // int fr1 = fraction1.GetTop() / fraction1.GetBottom();
        WriteLine(fraction1.GetFractionString());
        WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        // int fr2 = fraction2.GetTop() / fraction2.GetBottom();
        // fraction2.SetTop(18);
        // fraction2.SetBottom(3);
        // int fr2 = fraction2.GetTop() / fraction2.GetBottom();
        WriteLine(fraction2.GetFractionString());
        WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3,4);
        // int fr3 = fraction3.GetTop() / fraction3.GetBottom();
        // fraction3.SetTop(28);
        // fraction3.SetBottom(7);
        // int fr3 = fraction3.GetTop() / fraction3.GetBottom();
        WriteLine(fraction3.GetFractionString());
        WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        WriteLine(fraction4.GetFractionString());
        WriteLine(fraction4.GetDecimalValue());
    }
}