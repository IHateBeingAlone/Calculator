using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class LgXTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.3010)]
        [TestCase(3, 0.4771)]
        public void CalculateTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("LgX");
            double actualResult = calculator.Calculate(4);
            Assert.AreEqual(0.6021, actualResult, 0.0001);
        }

        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("LgX");
            Assert.Throws<Exception>(() => calculator.Calculate(-5));
        }
    }
}