using Calculator;
using NUnit.Framework;

namespace Calculator.Tests.SimpleTwoArgumentsTests
{
   [TestFixture]
   public class MinusTests
    {
        [Test]
        public void CalculateTest()
     {
           // ���������������� ��������
          ITwoArgumentsCalculator calcultor = new Minus();
          double actual = calcultor.Calculate(6, 2);
          Assert.AreEqual(4, actual);
      }
   }

}