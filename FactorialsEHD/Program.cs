using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialsEHD
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int parsedInput;
            
            if (args.Length < 1)
            {
                Console.Write("Please enter an int from 1 to 10,000: ");
                input = Console.ReadLine();
            }
            else
            {
                input = args[0];
            }
            if (!Int32.TryParse(input, out parsedInput))
            {
                Console.WriteLine("Usage:  FactorialsEHD <integer>");
            }
            else
            {
                try
                {
                    Console.WriteLine(FactorialsEHD.MathFunctions.FactorialCalc.Factorial(parsedInput));
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Input must be between 1 and 10,000");
                }
            }
#if (DEBUG)
                Console.ReadLine(); // so can see output directly from Visual Studio, but not needed when running from command line
#endif
        }



    }
}
