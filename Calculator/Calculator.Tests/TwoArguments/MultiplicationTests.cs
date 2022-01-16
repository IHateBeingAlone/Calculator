using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(4, 8, 32)]
        [TestCase(6, 9, 54)]
        [TestCase(12, 12, 144)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}