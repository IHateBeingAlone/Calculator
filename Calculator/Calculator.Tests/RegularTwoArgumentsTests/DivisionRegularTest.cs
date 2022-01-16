using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.SimpleTwoArgumentsTests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calcultor = new Division();
            double actual = calcultor.Calculate(6, 2);
            Assert.AreEqual(3, actual);
        }
    }

}