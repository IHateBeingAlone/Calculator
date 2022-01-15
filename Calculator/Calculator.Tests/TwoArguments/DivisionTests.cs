using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivisoinTests
    {
        [TestCase(15, 6, 2.5)]
        [TestCase(18, 6, 3)]
        [TestCase(27, 6, 4.5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}