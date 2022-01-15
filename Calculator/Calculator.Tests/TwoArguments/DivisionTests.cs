using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivisoinTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Division();
            double actual = calculator.Calculate(4, 7);
            Assert.AreEqual(28, actual);
        }
    }
}