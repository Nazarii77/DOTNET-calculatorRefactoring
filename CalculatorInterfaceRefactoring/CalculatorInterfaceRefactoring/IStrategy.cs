using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    interface IStrategy
    {
        string Calculate(string type, int num);
        string CalculateTypeOne(string type, int num);
    }
}
