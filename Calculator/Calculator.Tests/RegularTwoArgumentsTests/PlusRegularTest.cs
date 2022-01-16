using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.SimpleTwoArgumentsTests
{
    [TestFixture]
    public class PlusTests
    {
        [Test]
        public void CalculateTest()
        {
            // ןמהדמעמגטעוכüםûו הויסעגטÿ
            ITwoArgumentsCalculator calcultor = new Plus();
            double actual = calcultor.Calculate(6, 2);
            Assert.AreEqual(8, actual);
        }
    }

}