using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    public interface ICalculatorInterface
    {
        //Here I declare a method which I will implement in future classes that are inherited from ICalculatorInterface
        string Calculate(string type, int num);
    }
}
