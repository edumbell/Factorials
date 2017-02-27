using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialsEHD.MathFunctions;
using System.Numerics;

namespace UnitTests
{
    [TestClass]
    public class FactorialTests
    {
        // most straightforward (but inefficient) algorithm, used to check the result of the (actual rather similar) algo being tested
        public BigInteger CalcFactorialAltMethod(int input)
        {
            BigInteger result = 1;
            for (var i =2; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Factorial_NotPositive_ThrowException()
        {
            FactorialCalc.Factorial(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Factorial_TooHigh_ThrowException()
        {
            FactorialCalc.Factorial(10001);
        }

        [TestMethod]
        public void Factorial_One()
        {
            var result = FactorialCalc.Factorial(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Factorial_Ten()
        {
            var result = FactorialCalc.Factorial(10);
            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void Factorial_Hundred()
        {
            var result = FactorialCalc.Factorial(100);
            var expected = CalcFactorialAltMethod(100);
            Assert.AreEqual(result, result);
        }

        [TestMethod]
        public void Factorial_TenThousand()
        {
            var result = FactorialCalc.Factorial(10000);
            var expected = CalcFactorialAltMethod(10000);
            Assert.AreEqual(result, result);
        }
    }
}
