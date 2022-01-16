using System;

namespace Calculator
{
    public class ArcTg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}