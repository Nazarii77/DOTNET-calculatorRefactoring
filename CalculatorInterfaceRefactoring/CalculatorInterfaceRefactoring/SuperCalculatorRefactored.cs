using System;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{
    class SuperCalculatorRefactored : SuperCalculator,  IStrategy
    {   //DRY principle Do Not Repeat Yourself
        public void logStart(string type)
        {
            Console.WriteLine(String.Format(Constants.calcExecutingConstant, char.ToUpper(type[0]) + type.Substring(1)));
        }
        // Here is my implementation of the Calculate Method for SuperCalculatorRefactored as I can not touch the original
        public string Calculate(string type, int num)
        {
            //DRY principle Do Not Repeat Yourself
            if (type != "" && type != null)
            {
                logStart(type);
                return $"{Constants.resultIsConstant} {num + Constants.numberNames.FirstOrDefault(x => x.Value == type).Key}";
            }
            return "";
        }
    }
}
