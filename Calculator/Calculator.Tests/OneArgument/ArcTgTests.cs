using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ArcTgTests
    {
        [TestCase(1, 0.7854)]
        [TestCase(2, 1.1072)]
        [TestCase(3, 1.2491)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcTg();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}