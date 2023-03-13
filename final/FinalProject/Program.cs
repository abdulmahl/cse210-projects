using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        var options = new MenuOptions();

        int option = 0;

        do
        {
            options.PrintOptions();
            Write("Option: ");
            option = int.Parse(ReadLine());

            switch (option)
            {
                case 1:
                    var vehicle = new Vehicle();
                    vehicle.GetBodyType();
                    vehicle.GetMake();
                    vehicle.GetModel();
                break;
                
                default:
                break;
            }


            
        } while (option != 6);
    }
}