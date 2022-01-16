using System;

namespace Calculator
{
    public class ArcCtg : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 1/Math.Atan(firstArgument);
        }
    }
}