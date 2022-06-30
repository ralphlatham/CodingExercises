using NUnit.Framework;
using System;
using System.Linq;

namespace StringCalculator.Kata
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,5,9", 17)]
        [TestCase("1.2, 3.4,5.7,6.8,12", 29.1)]
        [TestCase("1\n2, 3", 6)]
        //[TestCase("1, \n", 1)]
        [TestCase("//;\n1;2", 3)]
        public void Test1(string numberList, decimal expectedResult)
        {
            decimal actualResult = Add(numberList);

            Assert.That(actualResult == expectedResult);
        }

        public decimal Add(string Number)
        {
            decimal result = 0;

            if (Number == string.Empty)
            {
                return result;
            }

            Number = Number.Replace("\n", ",");

            string delimiter = "";

            if (Number.StartsWith("//"))
            {
                delimiter = Number.Substring(2, 1);
                Number = Number.Remove(0, 3);
                Number = Number.Replace(delimiter, ",");
            }

            string[] numbersString = Number.Split(",", StringSplitOptions.RemoveEmptyEntries);
            decimal[] numbers = Array.ConvertAll(numbersString, x => decimal.Parse(x));

            return numbers.Sum();
        }
    }
}