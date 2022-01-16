using System;

namespace Calculator.OneArgument
{
    public class Sin: IOneArgumentCalculator
    {
        /// <summary>
        /// calculate sine function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}