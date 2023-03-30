// using System;
// using static System.Console;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<CardHolder> cHolders = new List<CardHolder>();

//         void printOptions()
//         {
//             WriteLine("Choose an action to perform from the following menu:");
//             WriteLine("  1. Deposit");
//             WriteLine("  2. Withdraw");
//             WriteLine("  3. Get Balance");
//             WriteLine("  4. Exit");
//             Write("What would you like to do? ");
//         }

//         void deposit(CardHolder currentUser)
//         {
//             Write($"How much would you like to deposit? ");
//             double deposit = double.Parse(ReadLine());
//             currentUser.SetBalance(currentUser.GetBalance() + deposit);
//             WriteLine($"Thank you for your deposit of ${deposit}");
//             WriteLine($"\nYour balance is now: ${currentUser.GetBalance() + deposit}\n");
//         }

//         void withdraw(CardHolder currentUser)
//         {
//             Write("How much would you like to withdraw? ");
//             double withdrawal = double.Parse(ReadLine());
//             if (currentUser.GetBalance() < withdrawal)
//             {
//                 WriteLine($"\nInsufficient funds for this transaction!\n");
//             }

//             else
//             {
//                 currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
//                 WriteLine($"\nYour withdrawal was successful!.\n");
//             }
//         }

//         void balance(CardHolder currentUser)
//         {
//             WriteLine($"\nYour current balance is: ${currentUser.GetBalance()}\n");
//         }

//         cHolders.Add(new CardHolder("Abdul", "Malik", 777733399, 1242, 998.12));
//         cHolders.Add(new CardHolder("Lenny", "Kimbo", 0987439901, 8342, 1238.17));
//         cHolders.Add(new CardHolder("Jake", "Jacobson", 993459901, 9842, 98.87));
//         cHolders.Add(new CardHolder("Linda", "Mason", 633399901, 3442, 258.57));
        
//         WriteLine("Welcome to the simple ATM");
//         Write("Insert card to continue. ");
//         int debitCardNumber;
//         CardHolder currentUser;

//         while (true)
//         {
//             try
//             {
//                 debitCardNumber = int.Parse(ReadLine());
//                 currentUser = cHolders.FirstOrDefault(a => a.GetCardNumber() == debitCardNumber);
//                 if (currentUser != null)
//                 {
//                     break;
//                 }
//                 else
//                 {
//                     WriteLine("Card not recognized! Please try another card.");
//                 }
//             }
//             catch 
//             {
//                 WriteLine("Card not recognized! Please try another card.");
//             }
//         }

//         Write("Enter your PIN: ");
//         ConsoleKeyInfo key = ReadKey(true);
//         string piNumber = "";

//         while (true)
//         {
//             do
//             {
//                 key = ReadKey(true);
//                 if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
//                 {
//                     piNumber += key.KeyChar;
//                     Console.Write("*");
//                 }
//                 else if (key.Key == ConsoleKey.Backspace && piNumber.Length > 0)
//                 {
//                     piNumber = piNumber.Substring(0, (piNumber.Length - 1));
//                     Write("\b \b");
//                 }
//             } while (key.Key != ConsoleKey.Enter);

//             try
//             {
//                 if (currentUser.GetPIN().ToString() == piNumber)
//                 {
//                     break;
//                 }
//                 else
//                 {
//                     WriteLine("PIN returned incorrect! Please try again.");
//                 }
//             }
//             catch 
//             {
//                 WriteLine("PIN returned incorrect! Please try again.");
//             }
//         }

//         WriteLine($"\n\nWelcome {currentUser.GetFirstName()}\n"); 
//         int option = 0;

//         do
//         {
//             printOptions();

//             try {option = int.Parse(ReadLine());}
//             catch { }

//             switch (option)
//                 {
//                     case 1:
//                         deposit(currentUser);
//                     break;

//                     case 2:
//                         withdraw(currentUser);
//                     break;

//                     case 3:
//                         balance(currentUser);
//                     break;
                    
//                     default:
//                         WriteLine("Thank you have a nice day!");
//                     break;
//                 }            
//         } while (option != 4);
//     }
// }


// Console.WriteLine("This text will be displayed in red");
// Console.ResetColor();

// Display "Please wait" message
// Console.Write("Please wait while we load your menu");

Console.WriteLine("Loading"); 

// Simulate loading the menu
for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Thread.Sleep(500); // Wait for 500 milliseconds (0.5 seconds)
    Console.Write(".");
}

// Display "Done" message
Console.WriteLine();
Console.WriteLine("Done loading menu.");
