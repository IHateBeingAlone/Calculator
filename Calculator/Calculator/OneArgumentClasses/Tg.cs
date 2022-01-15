using System;

namespace Calculator
{
    public class Tg: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}