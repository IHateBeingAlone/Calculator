using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplicationRegularTests
    {
    [Test]
    public void CalculateTest()
    {
        // ןמהדמעמגטעוכüםûו הויסעגטÿ
        ITwoArgumentsCalculator calcultor = new Multiplication();
        double actual = calcultor.Calculate(6, 2);
        Assert.AreEqual(12, actual);
    }
    }

}