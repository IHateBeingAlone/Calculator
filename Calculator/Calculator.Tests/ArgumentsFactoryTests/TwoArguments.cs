using System;
using NUnit.Framework;

namespace Calculator.Tests.ArgumentsFactoryTests
{
    public class CalculatorTwoArguments
    {
        [TestCase("Plus", typeof(Plus))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}