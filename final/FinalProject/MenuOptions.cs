using System;
using static System.Console;

public class MenuOptions
{
    public MenuOptions()
    {

    }

    public void PrintOptions()
    {
        WriteLine($"    Online Test Drive Boooking");
        WriteLine($"Select one of the following menu options");
        WriteLine("  1. Enter Vehicle Details");
        WriteLine("  2. List Entered Vehicles");
        WriteLine("  3. Save Listed Vehicles");
        WriteLine("  4. Exit");
        Write("What would you like to do? ");
    }
}