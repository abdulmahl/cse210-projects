using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
       var make = new Vehicle();
       make.SetTypeVehicle();
       WriteLine($"You have chosen to test-drive a: {make.GetTypeVehicle()}");
    }
}