using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace FactorialsEHD.MathFunctions
{
    public static class FactorialCalc
    {

        // adapted from: http://www.luschny.de/math/factorial/FastFactorialFunctions.htm
        static BigInteger RecFact(long start, long n)
        {
            //Console.WriteLine(start + " : " + n);
            long i;
            if (n <= 16)
            {
                BigInteger r = new BigInteger(start);
                for (i = start + 1; i < start + n; i++) r *= i;
                return r;
            }
            i = n / 2;
            return RecFact(start, i) * RecFact(start + i, n - i);
        }
        public static BigInteger Factorial(long n)
        {
            if (n < 1 || n > 10000)
                throw new ArgumentOutOfRangeException("Factorial requires an integer between 1 and 10,000");
            return RecFact(1, n);
        }
    }
}
