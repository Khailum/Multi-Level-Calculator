using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Calculator_OOP
{
    internal class Loop

    {
        public static void Continue()
        {
            //For Loop for the Loading screen:
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.Clear();
            Console.WriteLine("Thank you for waiting.");
        }

    }
}
