using System;

namespace Calculator.OneArgument
{
    public class LgX : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate of the decimal logarithm
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap (0;+infinity) </param>
        /// <returns> result any number </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0 )
            {
                throw new Exception("Error! Does not fall into the range");
            }
            return Math.Log10(firstArgument);
        }
    }
}