using System;
using static System.Console;

public class MenuOptions
{
    public MenuOptions()
    {

    }

    public void PrintOptions()
    {
        WriteLine($"------Online Test Drive Boooking-----");
        WriteLine($"Select from the following menu options");
        WriteLine("          1. Enter Vehicle Details");
        WriteLine("          2. List Entered Vehicles");
        WriteLine("          3. Save Listed Vehicles");
        WriteLine("          4. Exit");
        WriteLine("------What would you like to do?------- ");
    }
}