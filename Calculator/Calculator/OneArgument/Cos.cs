using System;

namespace Calculator.OneArgument
{
    public class Cos: IOneArgumentCalculator
    {
        /// <summary>
        /// calculate cosine function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}