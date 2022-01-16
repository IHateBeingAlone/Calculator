using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class NToThePowerOfXTests
    {
        [TestCase(4, 2, 16)]
        [TestCase(8, 3, 512)]
        [TestCase(2, 5, 32)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Calculator.TwoArguments.NToThePowerOfX();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}