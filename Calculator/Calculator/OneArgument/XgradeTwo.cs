using System;

namespace Calculator
{
    public class XgradeTwo : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}