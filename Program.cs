using System;
using Multi_Level_Calculator_OOP;

namespace MyApp
{
    internal class Program
    {
         static void Main(string[] args)
         {
            //Introduction including a loading screen:
            Console.WriteLine("WELCOME TO KHAILUM'S MULTI-LEVEL CALCULATOR!");
            Console.WriteLine("Press enter to continue ;)");
            Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Please bare with me while I transport you to the next screen.");

            //Class for the loading screen:
            Loop.Continue();

            //Class for the number of calculations a user wants to use:
            //Calculations.NumOfCalcs();

            //Class for the calculations AS WELL AS the results:
            ActCalcs.ActualCalcs();

            Console.ReadKey();
         }
        
    }
}