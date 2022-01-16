using System;

namespace Calculator
{
    public class TengradeX : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}