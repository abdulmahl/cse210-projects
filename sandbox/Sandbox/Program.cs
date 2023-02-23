// using System;
// using static System.Console;
// using System.Diagnostics;



// class Program
// {
//     static void Main(string[] args)
//     {
//         int count = 4;
//         while (count > -0)
//         {
//             Write("Look...");
//             Write(count + "\r");
//             count--;
//             Thread.Sleep(300);
//         }
//         ReadLine();


//         // WriteLine("Blu\re");
//     }   
// } 

using System;
using System.Threading;

class CountdownTimer {
    static void Main() {
        int seconds = 9; // set the number of seconds to count down
        while (seconds > 0) 
        {
            Console.Write(seconds + "\r");
            seconds--;
            Thread.Sleep(500); // sleep for one second
        }
    }
}
