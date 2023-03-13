using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            var menu = new MenuOptions();
            menu.PrintOptions();
            option = int.Parse(ReadLine());
            Clear();

            switch (option)
                {
                    case 1:
                        var vehicle = new Vehicle();
                            vehicle.SetBodyType();
                            vehicle.SetMake();
                            vehicle.SetModel();
                    break;

                    case 2:
                    break;

                    case 3:
                    break;
                    
                    default:
                    break;
                }            
        } while (option != 4);
    }
}