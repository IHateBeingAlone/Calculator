using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class PlusRegularTests
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