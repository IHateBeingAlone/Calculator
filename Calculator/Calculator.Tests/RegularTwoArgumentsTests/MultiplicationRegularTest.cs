using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.SimpleTwoArgumentsTests
{
    [TestFixture]
    public class MultiplicationTests
    {
    [Test]
    public void CalculateTest()
    {
        // ���������������� ��������
        ITwoArgumentsCalculator calcultor = new Multiplication();
        double actual = calcultor.Calculate(6, 2);
        Assert.AreEqual(12, actual);
    }
    }

}