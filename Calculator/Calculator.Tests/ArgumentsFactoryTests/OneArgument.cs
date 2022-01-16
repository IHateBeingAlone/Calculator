using System;
using NUnit.Framework;

namespace Calculator.Tests.ArgumentsFactoryTests
{
    public class CalculatorOneArgument
    {
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Abs", typeof(Abs))]
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Tg", typeof(Tg))]
        [TestCase("Ctg", typeof(Ctg))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}