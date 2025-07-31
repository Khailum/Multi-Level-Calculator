using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Calculator_OOP
{
    public class Calculations
    {
        public static int NumOfCalcs()
        { 
            //Declaration:
            int numCalculations;

            Console.Write("Enter the number of calculations you want to perform: ");

            if (!int.TryParse(Console.ReadLine(), out numCalculations) || numCalculations <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number: ");
                return 0;
            }
            return numCalculations;
        }
    }
}
