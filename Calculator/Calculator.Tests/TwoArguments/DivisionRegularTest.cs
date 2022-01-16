using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionRegularTests
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