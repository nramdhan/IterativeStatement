// Iterative Statements Project by: Nicholas Ramdhan
// Date Created: 02.10.2022
// This program will run as a conversion table from CAD to USD 



using System;

namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Below is the conversion value formula for CAD to USD 
            decimal conversionValue = 0.792367M;

            // This is the beginning of the program, asking the user for input
            Console.WriteLine("Please input a value between 5 and 25 to convert to USD");
            var isInt = int.TryParse(Console.ReadLine(), out var increment);

            // This will test to see if the input is within the range asked 
            while (increment > 25 || increment < 5 || !isInt)
            {
                // This is the message if it is an invalid input
                Console.WriteLine("ERROR! You've entered an invalid value. Please try again with an input between 5 and 25.");
                isInt = int.TryParse(Console.ReadLine(), out increment);

            }


            // This is a for loop to begin at 0 and not to exceed 200 (CAD)
            for (int i = 0; i <= (200 / increment); i++)
            {
                Console.WriteLine($"{i * increment}\t{i * increment * conversionValue}");
            }
        }
    }
}

