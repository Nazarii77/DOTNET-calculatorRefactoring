using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    public interface ICalculatorInterface
    {
        public string Calculate(string type, int num);
    }
}
