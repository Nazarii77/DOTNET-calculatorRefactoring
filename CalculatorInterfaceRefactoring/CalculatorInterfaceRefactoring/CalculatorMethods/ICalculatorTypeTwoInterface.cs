using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring.CalculatorMethods
{
    public interface ICalculatorTypeTwoInterface
    {
        string CalculateTypeOne(string type, int num);
        public string CalculateTypeTwo(string type, int num);
    }
}
