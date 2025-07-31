using System;


using System.Numerics;

namespace Multi_Level_Calculator_OOP
{
    internal class ActCalcs
    {
        public static void ActualCalcs()
        {
            
            // Results from Calculations class:
            int numCalculations = Calculations.NumOfCalcs();  // Get the number of calculations once

            // Initialize the results array:
            double[] results = new double[numCalculations];  // Array to store calculation results
            Console.WriteLine($"\nThere will be {numCalculations} calculations.");

            // This is a loop for the amount of calculations you want to input:
            for (int i = 0; i < numCalculations; i++)
            {
                // First number input
                double num1 = 0;
                int tries = 0;
                while (tries < 3)
                {
                    Console.WriteLine("Enter first number: ");
                    if (double.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    else
                    {
                        tries++;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid number.");

                        if (tries == 3)
                        {
                            Console.WriteLine("Too many invalid attempts. Exiting program...");
                            Console.ResetColor();
                            return;
                        }
                    }
                }

                // Reset tries for second number
                double num2 = 0;
                tries = 0;
                while (tries < 3)
                {
                    Console.WriteLine("Enter second number: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                    {
                        break;
                    }
                    else
                    {
                        tries++;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a valid number.");

                        if (tries == 3)
                        {
                            Console.WriteLine("Too many invalid attempts. Exiting program...");
                            Console.ResetColor();
                            return;
                        }
                    }
                }

                // Operator input
                char op = ' '; 

               tries = 0;
                while (tries < 3)
                {
                    Console.Write("Enter an operator (+, -, *, /): ");
                    op = Console.ReadKey().KeyChar;
                    Console.WriteLine(); 

                    if (op == '+' || op == '-' || op == '*' || op == '/')
                        break; // Valid input, exit loop

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                    
                    tries++;
                }

                if (tries == 3)
                {
                    Console.WriteLine("Too many invalid attempts. Exiting program...");
                    Console.ResetColor();
                    return;
                }

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Division by zero is not allowed!");
                            Console.ResetColor();
                            i--;  // Re-attempt this iteration
                            continue;
                        }
                        break;
                }

                // Storing the results from all calculations in the array:
                results[i] = result;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                Console.ResetColor();

                // Safety check: Ensure results are not 0
                if (results == null || results.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No results available.");
                    Console.ResetColor();
                    return;
                }

                // Summary of all calculations:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                
                Console.WriteLine("\n                                   === Summary of Calculations ===                         \nYour results will get stored in this summary after each calculation.");
                Console.WriteLine("|  #  |  Result  |");
                Console.WriteLine("|-----|----------|");

                for (int k = 0; k <= i; k++)  
                {
                    Console.WriteLine($"| {k + 1,2} |{results[k],7}|");
                }

                Console.WriteLine(" ");
                Console.WriteLine("*** Press Enter to continue/end the program ***");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.ResetColor();
            }
        }
    }
}
