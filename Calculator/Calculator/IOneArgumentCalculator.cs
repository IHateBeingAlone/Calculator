using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public interface IOneArgumentCalculator
    {
        double Calculate(double firstArgument);
    }
}