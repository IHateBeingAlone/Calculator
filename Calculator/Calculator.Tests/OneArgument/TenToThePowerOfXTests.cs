using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class TenToThePowerOfXTests
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TenToThePowerOfX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}