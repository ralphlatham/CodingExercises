using NUnit.Framework;

namespace FizzBuzz.Kata
{
    public class Tests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(11, "11")]
        [TestCase(12, "Fizz")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(16, "16")]
        [TestCase(17, "17")]
        [TestCase(18, "Fizz")]
        [TestCase(19, "19")]
        [TestCase(20, "Buzz")]

        public void TestFizzBuzz(int number, string result)
        {
            var printer = new PrintingClass();
            var printedValue = printer.Print(number);

            Assert.That(printedValue == result);
        }
    }

    internal class PrintingClass
    {
        public PrintingClass()
        {
        }

        internal string Print(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            else if (number % 3 == 0)
            {
                return "Fizz";
            }

            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}