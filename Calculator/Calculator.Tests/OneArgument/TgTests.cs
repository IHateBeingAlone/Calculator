using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class TgTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.5574)]
        [TestCase(7, 0.8715)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Tg();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}