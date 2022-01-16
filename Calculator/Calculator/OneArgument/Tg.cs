using System;

namespace Calculator
{
    public class Tg: IOneArgumentCalculator
    {
        /// <summary>
        /// calculate tg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}